using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCore_WebApi.Models;
using NetCore_WebApi.Models.Sql;
using Newtonsoft.Json;

namespace NetCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZkwDataController : ControllerBase
    {
        private readonly ZkwDataContext _dataContext;

        public ZkwDataController(ZkwDataContext context)
        {
            _dataContext = context;
        }

        //GET: api/<controller>
        [HttpGet]
        public JsonResult Get()
        {
            JsonResult json = new JsonResult(_dataContext.DeviceClassify);
            return json;
        }

        //GET api/values/5
        [HttpGet("{ClassifyId}")]
        public JsonResult Get(string ClassifyId)
        {
            JsonResult json = new JsonResult(
                _dataContext.DeviceClassify
                .FromSql(DeviceClassifySql
                .GetDataById("sys_classify_id", ClassifyId))
                );
            return json;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
