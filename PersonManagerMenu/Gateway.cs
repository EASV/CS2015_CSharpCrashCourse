using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PersonManagerMenu
{
    public class Gateway
    {
        public IEnumerable<Person> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("https://easv-person.herokuapp.com/api/persons/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Person>>().Result;
            }
        }

        public Person Add(Person person)
        {
            using (var client = new HttpClient())
            {
                var formatter = new JsonMediaTypeFormatter();
                formatter.SerializerSettings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                HttpResponseMessage response =
                    client.PostAsync("https://easv-person.herokuapp.com/api/persons/", person, formatter).Result;
                return response.Content.ReadAsAsync<Person>().Result;
            }
        }
    }
}
