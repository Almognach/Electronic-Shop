﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Electro_Shop.Data;
using Electro_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Electro_Shop.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly ILogger<ContactUsController> _logger;
        private readonly BranchContext _context;

        public ContactUsController(ILogger<ContactUsController> logger, BranchContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            var branches = _context.branches.ToList();
            return View(branches);
        }
     
    }
}
