﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCenterComputer.Backend.Data;
using MyCenterComputer.Shared.Entities;
namespace MyCenterComputer.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCenterComputersController : ControllerBase
    {
        
        private readonly DataContext _context;

        public MyCenterComputersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.CenterComputers.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var computer = _context.CenterComputers.FirstOrDefault(x => x.Id == id);
            if (computer == null)
            {
                return NotFound();
            }
            return Ok(computer);
        }


        [HttpPost]
        public IActionResult Post(MyCenter computer)
        {
            _context.Add(computer);
            _context.SaveChanges();
            return Ok(computer);
        }



        [HttpPut]
        public IActionResult Put(MyCenter computer)
        {
            
            var Mycomputer = _context.CenterComputers.FirstOrDefault(x => x.Id == computer.Id);
            if (computer == null)
            {
                return NotFound();
            }
            computer.Type = Mycomputer.Type;
            computer.Brand = Mycomputer.Brand;
            computer.Name = Mycomputer.Name;
            computer.LastName = Mycomputer.LastName;
            computer.Phone = Mycomputer.Phone;
            computer.Email = Mycomputer.Email;
            computer.Diagnosis = Mycomputer.Diagnosis;
            computer.Coments = Mycomputer.Coments;
            computer.Status = Mycomputer.Status;
            computer.Value = Mycomputer.Value;
            computer.DateStarted = Mycomputer.DateStarted;
            computer.DateFinished = Mycomputer.DateFinished;

            _context.Update(computer);
            _context.SaveChanges();
            return Ok(computer);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var Mycomputer = _context.CenterComputers.FirstOrDefault(x => x.Id == id);
            if (Mycomputer == null)
            {
                return NotFound();
            }
            _context.Remove(Mycomputer);
            _context.SaveChanges();
            return NoContent();
        }
    }
}