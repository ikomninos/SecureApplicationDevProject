using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureApplicationDevProject.Controllers


{

    [Authorize(Roles = "Administrator")]
    public class AdmnCntrller : Controller
    {
        public string Index()
        {
            return "Welcome to Administrator View";
        }
    }
}
