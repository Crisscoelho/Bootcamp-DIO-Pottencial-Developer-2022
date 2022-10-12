using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Pottencial.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    

    public class Usuario : ControllerBase
    
    {
        [HttpGet("ObterDataHoraAtual")] 
        public IActionResult ObterDatahora()
        {
                var obj = new
                {
                    Data = DateTime.Now.ToLongDateString(),
                    Hora = DateTime.Now.ToShortTimeString()
                };

                return Ok(obj);
            }

            [HttpGet("Apresentar/{nome}")]
            public IActionResult Apresentar(string nome)

            {
                var mensagem = $"Olá {nome}, seja benvindo!";
                return Ok(new { mensagem });
            }
        }
    }
    
