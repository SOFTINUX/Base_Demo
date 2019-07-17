// Copyright © 2017-2019 SOFTINUX. All rights reserved.
// Licensed under the MIT License, Version 2.0. See LICENSE file in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    /// <summary>
    /// API controller with no support of Views. RESTful.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<string>), 200)]
        public ActionResult<IEnumerable<string>> GetValues()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id_}")]
        [ProducesResponseType(typeof(string), 200)]
        public ActionResult<string> GetValue(int id_)
        {
            return $"value{id_}";
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(201)]
        public IActionResult Post([FromBody] string value_)
        {
            return StatusCode(201, value_);
        }

        // POST api/values
        [HttpPatch]
        public IActionResult Patch([FromBody] string value_)
        {
            return StatusCode(200, value_);
        }

        // PUT api/values/5
        [HttpPut("{id_}")]
        public IActionResult Put(int id_, [FromBody] string value_)
        {
            return StatusCode(200, $"{id_}: {value_}");
        }

        // DELETE api/values/5
        [HttpDelete("{id_}")]
        public IActionResult Delete(int id_)
        {
            return StatusCode(200, id_);
        }
    }
}
