using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
namespace TPN1_Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method="GET";
            request.ContentType = "aplication/json";
            request.Accept = "aplication/json";
            try
            {
                WebResponse response = request.GetResponse();
                Stream strReader = response.GetResponseStream();
                if(strReader == null)return;
                StreamReader objReader = new StreamReader(strReader);
                string responseBody = objReader.ReadToEnd();
                Root myDeserializedClass = JsonSerializer.Deserialize<Root>(responseBody);
                System.Console.WriteLine("Listado de Provincias Argentinas: ");
                foreach (var item in myDeserializedClass.Provincias)
                {
                    System.Console.WriteLine($"\t ID: {item.Id}, Nombre: {item.Nombre}\n");
                }
            } 
            catch(Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");    
            }
        }
    }
}
