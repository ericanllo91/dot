using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test2.Controllers
{
    public class HelloController : Controller
    {
        public String Index()
        {
            return "hello";
        }

        public String Mindex(String name, int times=10)
        {
            return $"byebye {name}";
        }
    }
}