using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace SauceDemo.Tests.API
{
    public class RegressTests
    {
        [Test]
        public void GetUser()
        {
            //Create rest-client instance
            var client = new RestClient("https://reqres.in");

            // create a restRequest with endpoint and type
            var request = new RestRequest("/api/users/2", Method.Get);

            // execute request and get response 
            var response = client.Execute(request);

            //check whether the request was successfull 
            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content); 
            }
            else
            {
                Console.WriteLine($"Request failed: {response.ErrorMessage}");    
            }
        }

        [Test]
        public void CreateUser()
        {
            var client = new RestClient("https://reqres.in");

            var request = new RestRequest("/api/users", Method.Post);

            // set request paramemeter 
            request.AddHeader("Content-Type", "application/json");

            // add body
            var body = "{\"name\": \"morpheus\",\"job\": \"leader\" }";
            request.AddBody(body);

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine($"Request failed: {response.ErrorMessage}");
            }
        }
    }
}