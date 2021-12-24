using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http_Verbs_.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        static List<string> languages = new List<string>() {   
            "C#","ASP.NET","MVC"  
              }; 

        // GET api/values
        [Route("")]  //This gives result to GET method without parameter
        public IEnumerable<string> Get()
        {
            return languages; 
           // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("{int:id}")]
        public string Get(int id)
        {
            return languages[id];  
        }

        // POST api/values
        //used to create new item
        [Route("")]
        public void Post([FromBody]string value)
        {

            languages.Add(value); 
        }

        // PUT api/values/5
        [Route("int:id")]  //used to update an item
        public void Put(int id, [FromBody]string value)
        {
            languages[id] = value;  
        }

        // DELETE api/values/5
        [Route("int:id")]    //used to remove an item
         [HttpDelete]
        public void Delete(int id)
        {
            languages.RemoveAt(id);
        }
    }
}
