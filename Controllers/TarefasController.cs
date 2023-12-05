// using Organization_List.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organization_List.Data;

namespace Organization_List.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class Tarefas : ControllerBase
    {
        private readonly DataContext _context;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTarefa(int id)
        {
            try
            {
                Tarefas t = await _context.TB_Tarefa;


            }
            catch
            {
                return null;
            }
        }
    }
}