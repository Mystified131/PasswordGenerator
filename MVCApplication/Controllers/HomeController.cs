﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{
  
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            List<string> emptylist = new List<string>();
            emptylist.Add(" ");

            resultViewModel.RandomPassword = emptylist;

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {

                RandomValue qbert = new RandomValue("qbert");

                resultViewModel.RandomPassword = qbert.RandomPassword(resultViewModel.quant);

                return View(resultViewModel);
            }

            return Redirect("/Home/Error");
        }

    }



}
