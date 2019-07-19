using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvs.Models;

namespace SalesWebMvs.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department{ Id = 1, Name = "Eletronics"});
            list.Add(new Department{ Id = 2, Name = "Fashion"});


            // Para enviar dados do controle para a View , Basta colocar a lista do tipo da classe , dentro dos parametros da view
            return View(list);
        }
    }
}