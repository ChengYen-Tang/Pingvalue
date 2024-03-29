﻿using Pingvalue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pingvalue.Controllers
{
    [Authorize]
    public class ConfigController : Controller
    {
        // GET: Config
        public ActionResult Index()
        {
            return View(new ConfigViewModels {
                LineGroupToken = AppConfig.LineGroupToken,
                LineRetornMessage = AppConfig.LineRetornMessage,
                LineToken = AppConfig.LineToken
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ConfigViewModels Config)
        {
            if (ModelState.IsValid)
            {
                AppConfig.LineGroupToken = Config.LineGroupToken;
                AppConfig.LineToken = Config.LineToken;
                AppConfig.LineRetornMessage = Config.LineRetornMessage;
                AppConfig.SaveConfig();
                return RedirectToAction("Index");
            }

            return View(Config);
        }
    }
}