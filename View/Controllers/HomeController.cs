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
            ComunicadoController controller = new ComunicadoController();

            List<Comunicado> lst = controller.Listar();

            return View(lst);
        }

        public ActionResult Emergencia()
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

        //---- Sindico

        public ActionResult ListaSindico()
        {
            //Instancia a controller de RN (SERVICE)
            SindicoController controller = new SindicoController();

            List<Sindico> lst = controller.Listar();

            return View(lst);
        }

        public ActionResult VisualizarSindico(int id)
        {
            SindicoController controller = new SindicoController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        public ActionResult InserirSindico()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirSindico(Sindico registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            SindicoController controller = new SindicoController();
            controller.Inserir(registro);
            return RedirectToAction("ListaSindico");
        }

        public ActionResult EditarSindico(int id)
        {
            SindicoController controller = new SindicoController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        [HttpPost]
        public ActionResult EditarSindico(Sindico registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            SindicoController controller = new SindicoController();
            controller.Atualizar(registro);

            return RedirectToAction("ListaSindico");
        }

        public ActionResult ExcluirSindico(int id)
        {
            SindicoController controller = new SindicoController();
            var registro = controller.Buscar(id);

            return View(registro);
        }


        [HttpPost, ActionName("ExcluirSindico")]
        public ActionResult ExcluirSindicoConfirmar(int id)
        {
            SindicoController controller = new SindicoController();
            controller.Excluir(id);

            return RedirectToAction("ListaSindico");
        }


        //----- Comunicado

        public ActionResult ListarComunicado()
        {
            //Instancia a controller de RN (SERVICE)
            ComunicadoController controller = new ComunicadoController();

            List<Comunicado> lst = controller.Listar();

            return View(lst);
        }


        public ActionResult VisualizarComunicado(int id)
        {
            ComunicadoController controller = new ComunicadoController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        public ActionResult InserirComunicado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirComunicado(Comunicado registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            ComunicadoController controller = new ComunicadoController();
            controller.Inserir(registro);
            return RedirectToAction("ListarComunicado");
        }

        public ActionResult EditarComunicado(int id)
        {
            ComunicadoController controller = new ComunicadoController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        [HttpPost]
        public ActionResult EditarComunicado(Comunicado registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            ComunicadoController controller = new ComunicadoController();
            controller.Atualizar(registro);

            return RedirectToAction("ListarComunicado");
        }


        public ActionResult ExcluirComunicado(int id)
        {
            ComunicadoController controller = new ComunicadoController();
            var registro = controller.Buscar(id);

            return View(registro);
        }


        [HttpPost, ActionName("ExcluirComunicado")]
        public ActionResult ExcluirComunicadoConfirmar(int id)
        {
            ComunicadoController controller = new ComunicadoController();
            controller.Excluir(id);

            return RedirectToAction("ListarComunicado");
        }

        //----- Reserva
        public ActionResult ListaReserva()
        {
            //Instancia a controller de RN (SERVICE)
            ReservaController controller = new ReservaController();

            List<Reserva> lst = controller.Listar();

            return View(lst);
        }


        public ActionResult VisualizarReserva(int id)
        {
            ReservaController controller = new ReservaController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        public ActionResult InserirReserva()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirReserva(Reserva registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            ReservaController controller = new ReservaController();
            controller.Inserir(registro);
            return RedirectToAction("ListaReserva");
        }


        public ActionResult EditarReserva(int id)
        {
            ReservaController controller = new ReservaController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        [HttpPost]
        public ActionResult EditarReserva(Reserva registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            ReservaController controller = new ReservaController();
            controller.Atualizar(registro);

            return RedirectToAction("ListaReserva");
        }

        public ActionResult ExcluirReserva(int id)
        {
            ReservaController controller = new ReservaController();
            var registro = controller.Buscar(id);

            return View(registro);
        }


        [HttpPost, ActionName("ExcluirReserva")]
        public ActionResult ExcluirReservaConfirmar(int id)
        {
            ReservaController controller = new ReservaController();
            controller.Excluir(id);

            return RedirectToAction("ListaReserva");
        }

        //----- Ocorrencia
        public ActionResult ListaOcorrencia()
        {
            //Instancia a controller de RN (SERVICE)
            OcorrenciaController controller = new OcorrenciaController();

            List<Ocorrencia> lst = controller.Listar();

            return View(lst);
        }


        public ActionResult VisualizarOcorrencia(int id)
        {
            OcorrenciaController controller = new OcorrenciaController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        public ActionResult InserirOcorrencia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirOcorrencia(Ocorrencia registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            OcorrenciaController controller = new OcorrenciaController();
            controller.Inserir(registro);
            return RedirectToAction("ListaOcorrencia");
        }


        public ActionResult EditarOcorrencia(int id)
        {
            OcorrenciaController controller = new OcorrenciaController();
            var registro = controller.Buscar(id);

            return View(registro);
        }

        [HttpPost]
        public ActionResult EditarOcorrencia(Ocorrencia registro)
        {
            if (!ModelState.IsValid)
            {
                return View(registro);
            }

            OcorrenciaController controller = new OcorrenciaController();
            controller.Atualizar(registro);

            return RedirectToAction("ListaOcorrencia");
        }

        public ActionResult ExcluirOcorrencia(int id)
        {
            OcorrenciaController controller = new OcorrenciaController();
            var registro = controller.Buscar(id);

            return View(registro);
        }


        [HttpPost, ActionName("ExcluirOcorrencia")]
        public ActionResult ExcluirOcorrenciaConfirmar(int id)
        {
            OcorrenciaController controller = new OcorrenciaController();
            controller.Excluir(id);

            return RedirectToAction("ListaOcorrencia");
        }



    }
}