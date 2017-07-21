using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreSleepApp;
using Microsoft.AspNetCore.Mvc;
using SleepApp.Models;

namespace SleepApp.Controllers
{
    public class HomeController : Controller
    {
        UserViewModel model = new UserViewModel();
        public IActionResult Index()
        {
            UserViewModel model = new UserViewModel();

            model.user = new UserModel();

            return View(model);
        }

        public IActionResult AddUser()
        {
            UserModel model = new UserModel();
            return View(model);
        }

        public IActionResult SaveUser(UserViewModel model)
        {

            using (var context = new EFCoreSleepAppContext())
            {

                if (model.user.id > 0)
                {
                    context.Update(model.user);
                } else {
                    context.Add(model.user);
                }

                context.SaveChanges(); //similar to a push

                return RedirectToAction("DisplayUser");
            }
        }

        public IActionResult DisplayUser()
        {
            using (var context = new EFCoreSleepAppContext())
            {
                SaveUserViewModel saveUserModel = new SaveUserViewModel();
                saveUserModel.user = context.UserModel.ToList();
                
                return View(saveUserModel);
            }
        }

        public IActionResult RemoveUser(int Id)
        {
            using (var context = new EFCoreSleepAppContext())
            {
                UserModel model = context.UserModel.Where(x => x.id == Id).FirstOrDefault();
                context.Remove(model);
                context.SaveChanges();
            }

            ViewData["id"] = Id;
            return RedirectToAction("DisplayUser");
        }

        public IActionResult EditUser(int Id)
        {
            using (var context = new EFCoreSleepAppContext())
            {
                UserViewModel model = new UserViewModel();
                model.user = context.UserModel.Where(x => x.id == Id).FirstOrDefault();
                return View(model);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
