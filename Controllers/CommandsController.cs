using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommandsHub.Models;
using CommandsHub.Data;

namespace CommandsHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        
        // private readonly MockRepo _repository = new MockRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands() {
            var commands = _repository.GetAppCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandbyId(int id) {
            var command = _repository.GetCommandbyId(id);
            return Ok(command);
        }
    }
}