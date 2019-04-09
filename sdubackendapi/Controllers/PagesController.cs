using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Umbraco.Core.Services;
using sdubackendapi.Models;

namespace sdubackendapi.Controllers
{
    public class PagesController : ApiController
    {
        Page[] pages = new Page[]
        {
            new Page { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Page { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Page { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Page> GetAllPages()
        {
            return pages;
        }

        public IHttpActionResult GetPage(int id)
        {
            var page = pages.FirstOrDefault((p) => p.Id == id);
            if (page == null)
            {
                return NotFound();
            }
            return Ok(page);
        }
    }
}