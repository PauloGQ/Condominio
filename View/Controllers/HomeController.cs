using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            //Instancia a controller de RN (SERVICE)
            MoradorController controller = new MoradorController();

            List<Morador> lst = controller.Listar();

            return View(lst);
        }


        public ActionResult ListaMorador()
        {
            //Instancia a controller de RN (SERVICE)
            MoradorController controller = new MoradorController();

            List<Morador> lst = controller.Listar();

            return View(lst);
        }


        public ActionResult VisualizarMorador(int id)
        {
            MoradorController controller = new MoradorController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        public ActionResult InserirMorador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirMorador(Morador registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            MoradorController controller = new MoradorController();
            controller.Inserir(registro);
            return RedirectToAction("ListaMorador");
        }


        public ActionResult EditarMorador(int id)
        {
            MoradorController controller = new MoradorController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        [HttpPost]
        public ActionResult EditarMorador(Morador registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            MoradorController controller = new MoradorController();
            controller.Atualizar(registro);

            return RedirectToAction("ListaMorador");
        }

        public ActionResult ExcluirMorador(int id)
        {
            MoradorController controller = new MoradorController();
            var registro = controller.Buscar(id);

            return View(registro);
        }


        [HttpPost, ActionName("ExcluirMorador")]
        public ActionResult ExcluirMoradorConfirmar(int id)
        {
            MoradorController controller = new MoradorController();
            controller.Excluir(id);

            return RedirectToAction("ListaMorador");
        }


    }
    }