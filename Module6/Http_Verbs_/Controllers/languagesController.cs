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
        
        /// <summary>
        /// Get()
        /// method return List laguages
        /// which would contain the elements in list
        /// </summary>
        /// <returns>List of type languages</returns>
        [Route("{int:id}")]
        public string Get(int id)
        {
            return languages[id];  
        }

        /// <summary>
        /// method to add languages in list
        /// </summary>
        /// <param name="id">
        /// which contains list of languages
        /// </param>
        [Route("")]
        public void Post([FromBody]string value)
        {
            languages.Add(value); 
        }

        /// <summary>
        /// method to edit list
        /// </summary>
        /// <param name="id">
        /// id would be taken from URI and then value is taken from body
        /// </param>
        [Route("int:id")] 
        //used to update an item
        public void Put(int id, [FromBody]string value)
        {
            languages[id] = value;  
        }
        
        /// <summary>
        /// Delete(int id)
        /// method to remove item from the list
        /// id would be matched using the id given by the user
        /// where, id is taken from URI
        /// </summary>
        /// <param name="id">id is unique identity of language to be deleted</param>
        [Route("int:id")]   
        //used to remove an item
         [HttpDelete]
         public void Delete(int id)
        {
            languages.RemoveAt(id);
        }
    }
}
