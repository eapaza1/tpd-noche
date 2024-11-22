using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Diagnostics;
using Newtonsoft.Json;


namespace TpdNoche.servicios
{
    public class ApiService
    {
        private const string TOKEN = "599759f090449b051bf2d0b9b34200c71383cbc3994343636653c2ac3419b5cb";

        private readonly HttpClient http;

        public ApiService()
        {
            http = new HttpClient();
            http.BaseAddress = new Uri("https://apiperu.dev/api/");
            http.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", TOKEN);
        }

        public async Task<DataDniResponse> getByDni(string nrodni)
        {
            var data = new { dni = nrodni };

            string dataJson=JsonConvert.SerializeObject(data);
            HttpContent body= new StringContent(dataJson,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await http.PostAsync("dni",body);
            //
            if (response.IsSuccessStatusCode)
            {
                string resultado= await response.Content.ReadAsStringAsync();
                var  objeto = JsonConvert
                    .DeserializeObject<ResponseApiDev<DataDniResponse>>(resultado);
                if (objeto.Success)
                {
                    return objeto.Data;
                    
                }
                else
                {
                    throw new Exception("no hay data para la consulta");
                }
            }
            else
            {
                throw new Exception("error en la conexion"+response.StatusCode);
            }
        }


        public async Task<DataRucResponse> getByRuc(string nroruc)
        {
            var data = new { ruc = nroruc };

            string dataJson = JsonConvert.SerializeObject(data);
            HttpContent body = new StringContent(dataJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await http.PostAsync("ruc", body);
            //
            if (response.IsSuccessStatusCode)
            {
                string resultado = await response.Content.ReadAsStringAsync();
                var objeto = JsonConvert
                    .DeserializeObject<ResponseApiDev<DataRucResponse>>(resultado);
                if (objeto.Success)
                {
                    return objeto.Data;
                }
                else
                {
                    throw new Exception("no hay data para la consulta");
                }
            }
            else
            {
                throw new Exception("error en la conexion" + response.StatusCode);
            }
        }

    }
}
