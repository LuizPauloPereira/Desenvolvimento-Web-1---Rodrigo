using Desenvolvimento_Web_1___Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desenvolvimento_Web_1___Rodrigo.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        public ActionResult Index()
        {
            return View(Loop());
        }

        public List<Funcao> Loop()
        {
            List<Funcao> listaFuncoes = new List<Funcao>();
            listaFuncoes.Add(new Funcao { Id = 1, Descricao = "Advogado" });
            listaFuncoes.Add(new Funcao { Id = 2, Descricao = "Médico" });
            listaFuncoes.Add(new Funcao { Id = 3, Descricao = "Arquiteto" });
            listaFuncoes.Add(new Funcao { Id = 4, Descricao = "Dj de ambulância" });
            listaFuncoes.Add(new Funcao { Id = 5, Descricao = "Empurrador de pessoas" });
            listaFuncoes.Add(new Funcao { Id = 6, Descricao = "Ordenhador de cobras" });
            listaFuncoes.Add(new Funcao { Id = 7, Descricao = "Dormidor profissional" });
            listaFuncoes.Add(new Funcao { Id = 8, Descricao = "Mergulhador de golf" });
            listaFuncoes.Add(new Funcao { Id = 9, Descricao = "Sereia" });
            listaFuncoes.Add(new Funcao { Id = 10, Descricao = "Provador de caixões" });
            listaFuncoes.Add(new Funcao { Id = 11, Descricao = "Xeirador de axilas" });
            listaFuncoes.Add(new Funcao { Id = 12, Descricao = "Passador de cabo wireless" });
            listaFuncoes.Add(new Funcao { Id = 13, Descricao = "Bombeiro submarino" });
            listaFuncoes.Add(new Funcao { Id = 14, Descricao = "Piloto de elefante" });
            listaFuncoes.Add(new Funcao { Id = 15, Descricao = "Boneco inflável" });
            listaFuncoes.Add(new Funcao { Id = 16, Descricao = "Coçador de costas" });

            return listaFuncoes;
        }
    }
}