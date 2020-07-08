using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using ApirestFEVK.Models;

namespace ApirestFEVK
{
    public class Utility
    {

        static public async Task<string> ReadContent(HttpRequest request)
        {
            string body = "";
            request.EnableBuffering();
            try
            {
                using (var reader = new StreamReader(request.Body, System.Text.Encoding.UTF8, true, 4096, true))
                {
                    body = await reader.ReadToEndAsync().ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                body = String.Format("error: {0}", ex.Message);
            }
            finally
            {
                // rewind for next middleware.
                request.Body.Position = 0;
            }
            return body;
        }

        // static public transformarJsonObject()



        static public string crearJsonFactura(string body)
        {
            string result = "ok";
            try
            {
                var rs = JsonConvert.DeserializeObject<ObjetosSAP>(body);

                //Id Doc 
                IdDoc idDoc = new IdDoc();
                idDoc.TipoDTE = "33"; //*habra una query con formatos donde enviaremos el tipo
                idDoc.Folio = 0;
                idDoc.FchEmis = retornarResult(rs, "OINV", "DocDate"); //*transformar fecha
                idDoc.IndNoRebaja = 0;
                idDoc.TipoDespacho = 0;
                idDoc.IndTraslado = 0;
                idDoc.TpoImpresion = "N";
                idDoc.IndServicio = 0;
                idDoc.MntBruto = 0;
                idDoc.TpoTranCompra = 0;  //*forma parte de la estructura del addon que actualmente no tengo crear pestaña addon
                idDoc.TpoTranVenta = 0;   //*forma parte de la estructura del addon que actualmente no tengo crear pestaña addon
                idDoc.FmaPago = 0;  //*int.Parse(retornarResult(rs, "OCTG", "U_FmaPago"));  traerme la tabla 
                idDoc.FmaPagExp = 0; //para documentos de exportacion
                idDoc.FchCancel = ""; // para exportacion
                idDoc.MntCancel = 0; //para exportacion  
                idDoc.SaldoInsol = 0; // campo opcional con valor 0 en SP Y VW
                    idDoc.MntPagos[0].FchPago = retornarResult(rs, "OINV", "DocDueDate");
                    idDoc.MntPagos[0].MntPago = retornarResult(rs, "OINV", "DocTotal");
                    idDoc.MntPagos[0].GlosaPagos = retornarResult(rs, "OCTG", "PymntGroup"); //* traerme tabla
                idDoc.MedioPago = ""; //campo opcional 
                idDoc.TpoCtaPago = "";  //campo en DTE lleva nombre: TipoCtaPago preguntar Daniel
                idDoc.NumCtaPago = "";  //opcional
                idDoc.TermPagoCdg = "";  // opcional
                idDoc.TermPagoGlosa = ""; //opcional
                idDoc.TermPagoDias = 0; //opcional
                idDoc.FchVenc = retornarResult(rs, "OINV", "DocDueDate");

                //

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                result = ex.Message;
            }

            return result;
        }


       

        static public string retornarResult(ObjetosSAP objetosSAP, string objeto, string campo )
        {
            IList<Cell> list;
            try
            {
                switch (objeto)
                {
                    case "OINV":
                        list = objetosSAP.OINV.dbDataSources.rows.row.cells.cell;
                        break;
                    case "INV1":
                        list = objetosSAP.INV1.dbDataSources.rows.row.cells.cell;
                        break;
                    case "OCRD":
                        list = objetosSAP.OCRD.dbDataSources.rows.row.cells.cell;
                        break;
                    default:
                        return "Objeto no encontrado";
                }
        
                for (int  i = 0; i<list.Count;i++)
                {
                    if (list[i].uid == campo)
                        return list[i].value;
                }

                return ("Campo: " + campo + " no encontrado en objeto: "+ objeto);
            }
            catch (Exception ex)
            {
                return ("exception retornarResult: " + ex.Message);
            }
        }





    }
}
