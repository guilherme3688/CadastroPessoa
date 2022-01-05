using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string InsertPessoa(Pessoa pes)
        {       
            try
            {
                using (PessoaEntities db = new PessoaEntities())
                {
                    db.Pessoas.Add(pes);
                    db.SaveChanges();
                    return "Pessoa cadastrada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                string ex2 = ex.Message;
                return ex2;
               
            }

        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Autor: Guilherme R P Silva";

            return View();
        }

    }
}