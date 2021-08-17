using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using WebApplication3.Data;
using MyJsonApi.Models;
//using MyJsonApi.JsonFolder;
using Newtonsoft.Json;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {
       
 
       
       
       
        [HttpGet]
         
        public object GetFruit()
        {
            
                string allText = System.IO.File.ReadAllText(@"C:\Windows\Api\MyJsonApi\JsonFolder\Web.json");

                object jsonObject = JsonConvert.DeserializeObject<Fruits>(allText);
                return (jsonObject);
            }
             
           
            }}