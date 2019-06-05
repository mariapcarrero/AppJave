using System;
using Newtonsoft.Json;

namespace JaverianaCali.Models.Restful
{
    public class RestfulAuthenticationModel
    {

        [JsonProperty("valido")]
        private bool isValido;

        [JsonProperty("nombre")]
        private string nombre;

        [JsonProperty("apellido")]
        private string apellido;

        [JsonProperty("periodo")]
        private string periodo;

        [JsonProperty("emplid")]
        private string emplid;

        [JsonProperty("x-t6519fdd1s5q")]
        private string token;

        public RestfulAuthenticationModel()
        {
        }

        public string Token { get => token; set => token = value; }
        public string Emplid { get => emplid; set => emplid = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool IsValido { get => isValido; set => isValido = value; }
    }
}
