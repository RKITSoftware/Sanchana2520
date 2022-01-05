using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http_Verbs_.Controllers
{
    [RoutePrefix("api/values")]
    public class languagesController : ApiController
    {
        //creating list
        static List<string> languages = new List<string>() {   
            "C#","ASP.NET","MVC"  
              }; 

       
        [Route("")] 
        //This gives result to GET method without parameter
        public IEnumerable<string> Get()
        {
            return languages; 
        
        }

        [Route("{int:id}")]
        public string Get(int id)
        {
            return languages[id];  
        }

        
        //used to create new item
        [Route("")]
        public void Post([FromBody]string value)
        {

            languages.Add(value); 
        }

        
        [Route("int:id")] 
        //used to update an item

        public void Put(int id, [FromBody]string value)
        {
            languages[id] = value;  
        }

        [Route("int:id")]   
        //used to remove an item
         [HttpDelete]

        public void Delete(int id)
        {
            languages.RemoveAt(id);
        }
    }
}
