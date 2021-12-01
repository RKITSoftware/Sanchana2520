using Parameter_binding.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Parameter_binding.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("file1")]
        [HttpGet]
        public List<List<Parameter>> Get(int id)
        {
            var list = new List<List<Parameter>>();

            var parameter_list = new List<Parameter>
			{
				new Parameter {Id1 = 1, Id2 = 2},
				new Parameter {Id1 = 5, Id2 = 7}
				
			};

            list.Add(parameter_list);
            list.Add(parameter_list);
            return list;
        }

        //Sending simple parameters in the Url
        
        [Route("File2")]
        [HttpGet]
        public string Get_Parameters(int id1, long id2)
        {
            return "value";
        }

        //Sending an object in the Url 
       
        [Route("File3/{id1}/{id2}/{id3}")]
        [HttpGet]
        public string Get_Parameters_AttributeRouting(int id1, long id2)
        {
            return "value";
        }

        //Sending simple parameters using attribute routing
        
        [Route("File4")]
        [HttpGet]
        public string GetWithUri([FromUri] Parameter parameter_Obj)
        {
            return "value:" + parameter_Obj.Id1;
        }
        
        [Route("File5")]
        [HttpPost]
        public string GetWithBody([FromBody] Parameter Obj_parameter)
        {
            return "value:" + Obj_parameter.Id1;
        }

        //Sending a simple list in the Url 

        [Route("File6")]
        [HttpGet]
        public string GetListFromUri([FromUri] List<int> Obj_parameter)
        {
            if (Obj_parameter != null)
            {
                return "Length:" + Obj_parameter.Count;
            }

            return "NULL";
        }

    }
}
