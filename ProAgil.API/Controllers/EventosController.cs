using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class EventosController : ControllerBase
    {
        //Get Valores

        [HttpGet]

        public ActionResult<IEnumerable<Evento>> get()

        {
            return new Evento[] {
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular",
                    Local = "São Paulo",
                    Lote = "1º Lote",
                    QtdePessoas = 250

                }
             };
        }


        
    }
}