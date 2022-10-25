using App3.Core;
using App3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App3.Repositories
{
    public class CobradoresRepository
    {
        const string Url = "https://cosmopolitaweb.azurewebsites.net/api/apicobradores";
        /// <summary>
        /// Método que agrega una actividad de manera asincrónica
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public async Task<Cobrador> AddAsync(string apellido_nombre)
        {
            //creamos un objeto del tipo Actividad con los parámetros que llegan
            Cobrador cobrador = new Cobrador()
            {
                Apellido_Nombre = apellido_nombre
            };

            //creamos un objeto HttpClient
            HttpClient client = Helper.ObtenerClienteHttpApiPropia();

            //enviamos por POST el objeto que creamos a la URL de la API
            var response = await client.PostAsync(Url,
                new StringContent(
                    JsonConvert.SerializeObject(cobrador),
                    Encoding.UTF8, "application/json"));

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Cobrador>(
                await response.Content.ReadAsStringAsync());
        }
        /// <summary>
        /// método que elimina una actividad y devuelve verdadero o falso si lo pudo hacer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int id)
        {
            HttpClient client = Helper.ObtenerClienteHttpApiPropia();
            var response = await client.DeleteAsync(Url + "/" + id);
            return response.IsSuccessStatusCode;
        }
        /// <summary>
        /// modifica una actividad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> PutAsync(string apellido_nombre, int id)
        {
            HttpClient client = Helper.ObtenerClienteHttpApiPropia();
            Cobrador cobrador = new Cobrador()
            {
                Id = id,
                Apellido_Nombre = apellido_nombre
            };
            var response = await client.PutAsync(Url + "/" + id, new StringContent(JsonConvert.SerializeObject(cobrador), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }

        /// <summary>
        /// obtiene todas las actividades
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Cobrador>> GetAllAsync()
        {
            HttpClient client = Helper.ObtenerClienteHttpApiPropia();
            var response = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Cobrador>>(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Cobrador> GetByIdAsync(int id)
        {
            HttpClient client = Helper.ObtenerClienteHttpApiPropia();
            var response = await client.GetStringAsync(Url + "/" + id);
            return JsonConvert.DeserializeObject<Cobrador>(response);
        }
    }
}
