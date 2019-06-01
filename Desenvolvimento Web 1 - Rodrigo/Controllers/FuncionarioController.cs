using Desenvolvimento_Web_1___Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desenvolvimento_Web_1___Rodrigo.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            return View(listaFuncionarios);
        }

        public ActionResult Create()
        {
            FuncaoController cc = new FuncaoController();

            ViewBag.FuncaoId = new SelectList(cc.Loop(), "Id", "Descricao");

            return View();
        }
    }
}