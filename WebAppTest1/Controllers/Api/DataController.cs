using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace WebAppTest1.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private string _baseUrl;

        public DataController()
        {
            _baseUrl = "https://localhost:44361/";
        }


        [HttpPut("UploadPic")]
        public bool UploadPic(string basee64pic)
        {
            var guid = new Guid();
            var filename = guid.ToString();

            //make a function that save pic here

            return true;
        }

        [HttpGet("GetVideoUrl")]
        public string GetVideoUrl()
        {

            return $@"{_baseUrl}/video/videotest1.mp4";
        }



    }
}
