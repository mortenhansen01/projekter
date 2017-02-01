using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        // GET: Store/Browse
        public string Browse()
        {
            return "Hello from Browse.Index()";
        }
        // GET: Store/Details
        public string Details()
        {
            return "Hello from Browse.Details()";
        }
    }
}