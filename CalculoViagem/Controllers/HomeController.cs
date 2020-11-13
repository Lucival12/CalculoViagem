using CalculoViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CalculoViagem.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("calcular-viagem")]
        public IHttpActionResult CalcularDistanciaLitro([FromUri] double kmLitro,DateTime tempo,double velocidade)
        {            

            var returno = new CalculoViagemModel
            {                
                KmLitro = kmLitro,
                Tempo = tempo,
                Velocidade = velocidade,
                Distancia = tempo.TimeOfDay.TotalHours * velocidade,

            };
            returno.LitrosUsado = returno.Distancia / returno.KmLitro;


            return Json(returno);

        //https://localhost:44301/api/home/calcular-viagem?kmLitro=1&&tempo=02:00&&velocidade=54
        }
    }
}
