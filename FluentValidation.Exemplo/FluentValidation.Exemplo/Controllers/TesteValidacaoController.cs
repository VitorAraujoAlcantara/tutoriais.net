using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Exemplo.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FluentValidation.Exemplo.Controllers
{
    [Route("api/[controller]")]
    public class TesteValidacaoController : Controller
    {
        private readonly AbstractValidator<FiltrosDto> validator;

        public TesteValidacaoController(AbstractValidator<FiltrosDto> validator)
        {
            this.validator = validator;
        }


        // GET: api/values
        [HttpGet]
        public IActionResult Get([FromQuery] FiltrosDto filtro)
        {
            var validacao = validator.Validate(filtro);

            if ( ! validacao.IsValid)
            {
                return BadRequest(validacao.Errors);
            }

            return  Ok( new string[] { "value1", "value2" });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
