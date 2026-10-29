using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RPGAPI.Controllers
{ 
    [ApiController]
    [Route("controller")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonagemHabilidadesController(DataContext context)
        {
            _context = context;
        }

      [HttpPost]
     public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidade)
        {
            try
            {
             Personagem personagem = await _context.TB_PERSONAGENS 
             .Include(p => p.Arma)
             .Include(p => p.PesonagemHabilidades).ThenInclude(ps => ps.Habilidade)
              
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }    
    }
    
}