using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestAPI_PickPoint.BLL;
using RestAPI_PickPoint.Dtos;
using RestAPI_PickPoint.Models;

namespace RestAPI_PickPoint.Controllers
{
    [Route("api/postamats")]
    [ApiController]
    public class PostamatController : Controller
    {
        private readonly IPostamatLogic _logic;
        private readonly IMapper _mapper;

        public PostamatController(IPostamatLogic logic, IMapper mapper)
        {
            _logic = logic;
            _mapper = mapper;
        }

        //  api/postamats
        [HttpGet]
        public ActionResult<IEnumerable<PostamatReadDto>> GetAllPostamats()
        {
            var postamats = _logic.GetAllPostamats();
            return Ok(_mapper.Map<IEnumerable<PostamatReadDto>>(postamats));
        }
        //  api/postamats/1
        [HttpGet("{number}")]
        public ActionResult<Postamat> GetPostamatByNumber(int number)
        {
            Postamat postamat = _logic.GetPostamatByNumber(number);
            if (postamat != null)
            {
                return Ok(_mapper.Map<PostamatReadDto>(postamat));
            }
            return NotFound();
        }
    }
}
