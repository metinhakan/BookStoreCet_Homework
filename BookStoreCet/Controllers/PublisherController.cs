using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreCet.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreCet.Controllers
{
    public class PublisherController : Controller
    {
        ApplicationDbContext dbContext;
        public PublisherController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public IActionResult Index()
        {
            List<Publisher> publishers = dbContext.Publisher.ToList();
            return View(publishers);
        }


        public IActionResult Details(int id)
        {
            var publisher = dbContext.Publisher.Find(id);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }
    }
}