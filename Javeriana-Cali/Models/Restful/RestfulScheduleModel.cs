using System;
using Newtonsoft.Json;

namespace JaverianaCali.Models.Restful
{
    public class RestfulScheduleModel
    {
        [JsonProperty("feci")]
        private String initialDate;

        [JsonProperty("fecf")]
        private String endDate;

        [JsonProperty("saln")]
        private String classroom;

        [JsonProperty("doc")]
        private String teacher = "No asignado";

        [JsonProperty("dia")]
        private String day;

        public RestfulScheduleModel() {
        }

        public string InitialDate { get => initialDate; set => initialDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Classroom { get => classroom; set => classroom = value; }
        public string Teacher { get => teacher; set => teacher = value; }
        public string Day { get => day; set => day = value; }
    }
}
