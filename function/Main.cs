using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace Function
{
    public static class Main
    {
        [FunctionName(nameof(HelloSWA))]
        public static IActionResult HelloSWA([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, 
        ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return new OkObjectResult(new Model.Response() { Message = "Welcome to Azure Static Web and Azure Functions!"});
        }
    }
}
