using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using ApirestFEVK.Models;

namespace ApirestFEVK.Services
{
    public static class ResponseService
    {

        public static Response validarFacura(string estado, string mensaje)
        {
            Response response = new Response()
            { 
                status = estado,
                message = mensaje
             };

            return response;
        }


    }
}
