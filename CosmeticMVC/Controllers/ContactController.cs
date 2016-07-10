﻿using DataLayer.DataAccessObj;
using DataLayer.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmeticMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Send(string name, string mobile, string address, string email, string content)
        {
            var feedback = new Feedback()
            {
                Name = name,
                Email = email,
                CreatedDate = DateTime.Now,
                Phone = mobile,
                Content = content,
                Address = address
            };
            int id = new ContactDao().InsertFeedBack(feedback);
            //if (id > 0)
            //{
            //    return Json(new
            //    {
            //        status = true
            //    });
            //    //send mail
            //}

            //else
            //    return Json(new
            //    {
            //        status = false
            //    });
            return Json(new
            {
                status = true
            });
        }
    }
}