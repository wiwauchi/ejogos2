using EJOGOS2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS2.Controllers
{
    public class EquipeController : Controller
    {

        //actionresult representa os varios codigos http
        // https://developer.mozilla.or/pt-BR/docs/Web?HTTP/Status

        Equipe equipeModel = new Equipe();


        public IActionResult Index()
        {
            //ViewBag = reserva de espaço para armazenar inf para recuperar na VIEW
            // tem a função de carregar as informações da Controller para a VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
