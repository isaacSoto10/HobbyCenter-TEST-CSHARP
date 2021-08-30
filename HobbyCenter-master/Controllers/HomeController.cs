using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using HobbyCenter.Models;

namespace HobbyCenter.Controllers
{
    public class HomeController : Controller
    {   
        private MyContext DbContext;

        public HomeController (MyContext context)
        {
        DbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            int? session = HttpContext.Session.GetInt32("UserId");
            if(session == null)
            {
                return View("Index"); 
                
            }
            return RedirectToAction("Dashboard");   
        }
        


        [HttpPost("Register")]
        public IActionResult Register(User user) 
        {
            if(ModelState.IsValid)
            {
                if(DbContext.Users.Any(i => i.UserName == user.UserName))
                {
                    ModelState.AddModelError("UserName", "Username is already in Use! Try Another one");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                DbContext.Users.Add(user);
                DbContext.SaveChanges();
                HttpContext.Session.SetInt32("userId", user.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("Login")]
        public IActionResult Login(Login person)
        {
            if(ModelState.IsValid)
            {
                User oneUser = DbContext.Users.FirstOrDefault(u => u.UserName == person.UserLogin);
                if (oneUser == null)
                {
                    ModelState.AddModelError("UserName", "User Name has not found been found.");
                    return View("Index");
                }
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(person, oneUser.Password, person.PasswordLogin);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Password typed didnt work. Please try again.");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", oneUser.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");

            if(UserId == null)
            {
                return RedirectToAction("Index");
            }

            List<Hobby> AllHobbys = DbContext.Hobbys
            .Include(h => h.HobbyLiker)
            .Include(h => h.HobbyOwner)
            .ToList();
            User user = DbContext.Users.FirstOrDefault(i => i.UserId == UserId);
            return View(AllHobbys);
        }

        [HttpGet("New")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("Create")]
        public IActionResult Create(Hobby formData)
        {
            if(ModelState.IsValid){
            formData.UserId=(int)HttpContext.Session.GetInt32("UserId");
            DbContext.Add(formData);
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard");
            }
            return View("New", formData);
        }

[HttpGet("Details/{id}")]
        public IActionResult Detail(int id)
        {
            Hobby RetrievedHobby = DbContext.Hobbys
            .Include(hobby => hobby.HobbyLiker)
                .ThenInclude(enthusiast => enthusiast.User)
            .Include(hobby => hobby.HobbyOwner)
            .SingleOrDefault(hobby => hobby.HobbyId == id);
            return View("Details", RetrievedHobby);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("AddHobby/{id}")]
        public IActionResult AddHobby(int id)
        {
    
             //Retrieve an the specific hobby you want to become an Enthusiast of
            //Create an Instance of Enthusiast
            Enthusiast newEnthusiast = new Enthusiast
            {
                HobbyId = id,
                UserId=(int)HttpContext.Session.GetInt32("UserId")
            };
            //Add user to as Enthusiast
            DbContext.Add(newEnthusiast);
            //Save instance of Enthusiast
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }   
    }
}