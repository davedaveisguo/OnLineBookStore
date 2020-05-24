
using BulkyBookII.DataAccess.Data;
using BulkyBookII.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BulkyBookII.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }




        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            // user table
            var userList = _db.ApplicationUsers.Include(u => u.Company).ToList();
            // middle table
            var userRole = _db.UserRoles.ToList();
            // role table 
            var roles = _db.Roles.ToList();

            // modify the role in user object
            foreach (var user in userList)
            {
                var roleId = userRole.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                user.Role = roles.FirstOrDefault(u => u.Id == roleId).Name;
                if (user.Company == null)
                {
                    user.Company = new Company()
                    {
                        Name = ""
                    };
                }
            }

            return Json(new { data = userList });
        }


        [HttpPost]
        public IActionResult LockUnLock([FromBody] string id)
        {
            var objFromDb = _db.ApplicationUsers.FirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while lock/unlock" });
            }
            if (objFromDb.LockoutEnd != null && objFromDb.LockoutEnd > DateTime.Now)
            {
                // user is locked and we need unlock them
                objFromDb.LockoutEnd = DateTime.Now;
            }
            else
            {
                objFromDb.LockoutEnd = DateTime.Now.AddYears(100);
            }
            _db.SaveChanges();
            return Json(new { success = true, message = "operation successfully" });

        }
        #endregion


    }
}
