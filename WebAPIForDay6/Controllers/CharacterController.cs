using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIForDay6.Modules;

namespace WebAPIForDay6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        List<ComedyCharacters> characters = new List<ComedyCharacters>();
        public CharacterController()
        {
            characters.Add(new ComedyCharacters() { id = 1, name = "Mr.Lavangam", email = "lavangamAlda@paris.com", password = "parisAlda@25" });
            characters.Add(new ComedyCharacters() { id = 2, name = "Bunk Seenu", email = "bunkSeenu@arrogant.in", password = "Kerosene" });
        }
        [HttpGet]
        [Route("getcharacters")]
        public ActionResult<List<ComedyCharacters>> Get()
        {
            return characters;
        }

        [HttpGet]
        [Route("getcharactersbyid")]
        public ActionResult<ComedyCharacters> Get(int id)
        {
            return characters.Find(x=> x.id == id);
        }
        [HttpPost]
        [Route("postcharacter")]
        public ActionResult<ComedyCharacters> Post([FromBody] ComedyCharacters character)
        {
            characters.Add(character);
            return character;
        }

        [HttpPut]
        [Route("editcharacter")]
        public ActionResult<ComedyCharacters> edit([FromBody] ComedyCharacters character)
        {
            var charc = characters.Find(x => x.id == character.id);
            charc.name = character.name;
            charc.email = character.email;
            charc.password = character.password;
            return character;
        }
    }
}
