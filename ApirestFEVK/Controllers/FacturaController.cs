using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ApirestFEVK.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApirestFEVK.Controllers
{
    [Route("api/[controller]")]
    public class FacturaController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/<controller>
        [HttpPost("validar1")]
        public string validarFactura1()
        {
            var result = "ok";
            try
            {
                HttpRequest request = this.Request;
                HttpResponse response = this.Response;
                var stream = new StreamReader(request.Body);
                var body = stream.ReadToEnd();
                Newtonsoft.Json.Linq.JObject jsonSAP = Newtonsoft.Json.Linq.JObject.Parse(body);
                   
            }
            catch(Exception ex)
            {
                result = "validar Factura excepcion: " + ex.Message;
            }
            return result;

        }


        // POST api/<controller>
        [HttpPost("validar")]
        public string validarFactura([FromBody] object value)
        {
            var result = "ok";
            try
            {
                Newtonsoft.Json.Linq.JObject jsonSAP = Newtonsoft.Json.Linq.JObject.Parse(value.ToString());
            }
            catch (Exception ex)
            {
                result = "validar Factura excepcion: " + ex.Message;
            }

            //la idea es recibir un objeto completo y luego disgregar por cada clase ejmp(OINV, OCRD, ETC)
            return result;
        }


        [HttpPost("validarDocumento1")]
        public async Task<string> validarDocumento1(String documento)
        {
            Utility.crearJsonFactura(documento);

            return "ok";
        }

        [HttpPost("validarDocumento")]
        public async Task<string> validarDocumento()
        {
            var result = "ok";
            try
            {
                HttpRequest request = this.Request;
                string body = await Utility.ReadContent(request);
                Utility.crearJsonFactura(body);

                // var rs = JsonConvert.DeserializeObject<ObjetosSAP>(body);
               
                //Newtonsoft.Json.Linq.JObject jsonSAP = Newtonsoft.Json.Linq.JObject.Parse(body.ToString());
            }
            catch (Exception ex)
            {
                result = "validarDocumento excepcion: " + ex.Message;
            }

            return result;
        }


    }
}
