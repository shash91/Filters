using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [SimpleMessage(Message ="A",Order =2)]
        [SimpleMessage(Message ="B",Order =1)]
        public String Index()
        {
            return "Action Method is running";
       
        }
    }
}