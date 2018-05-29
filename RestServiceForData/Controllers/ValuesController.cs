using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestServiceForData.Models;

namespace RestServiceForData.Controllers
{
   
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IMediaItemRepository mediaRepo;

        public ValuesController(IMediaItemRepository media)
        {
            mediaRepo = media;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<MediaItem> Get()
        {
            return mediaRepo.MediaItems.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var res = mediaRepo.GetById(id);
            if(res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]MediaItem value)
        {
            if (value == null)
                return BadRequest();
            if (value.Id != 0 && mediaRepo.GetById(value.Id) == null)
                return NotFound();

            mediaRepo.SaveMediaItems(value);
            return CreatedAtAction("Get", new { id = value.Id },value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
