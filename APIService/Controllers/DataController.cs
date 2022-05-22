using APIService.Model;
using APIService.Service.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IdataService _idataService;
        public DataController(IdataService idataService)
        {
            _idataService = idataService;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(FormData formData)
        {
            return Ok(_idataService.AddData(formData));
        }
        [HttpGet]
        [Route("read")]
        public IActionResult Read()
        {
            return Ok(_idataService.Read());
        }
    }
}
