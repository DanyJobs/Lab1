using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCPlantilla.Utilerias;
using System.Web.UI;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["datavideo"] = BaseHelper.ejecutarConsulta("select * from video", CommandType.Text);          
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Modificar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }


        // POST
        [HttpPost]
        public ActionResult InsertarVideo(int idVideo,
            string titulo,
            int reproducciones,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@titulo", titulo));
            Parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO Video VALUES(@idVideo,@titulo,@reproducciones,@url)", CommandType.Text, Parametros);  
            return View("Mensaje");
        }
        [HttpPost]
        public ActionResult ModificarVideo(int idVideo,
            string titulo,
            int reproducciones,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@titulo", titulo));
            Parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("Update Video SET titulo=@titulo,reproducciones=@reproducciones,url=@url where idVideo=@idVideo", CommandType.Text, Parametros);
            return View("Mensaje");
        }

        [HttpPost]
        public ActionResult EliminarVideo(int idVideo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));           
            BaseHelper.ejecutarSentencia("DELETE FROM VIDEO WHERE idvideo=@idVideo", CommandType.Text, Parametros);
            return View("Mensaje");
        }


    }
}
