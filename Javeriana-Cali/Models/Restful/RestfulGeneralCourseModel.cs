using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JaverianaCali.Models.Restful
{
    public class RestfulGeneralCourseModel
    {

        [JsonProperty("coda")]
        private String id;

        [JsonProperty("nom")]
        private String name;

        [JsonProperty("notp")]
        private String parcialGrade;

        [JsonProperty("porci")]
        private String absence;

        [JsonProperty("horario")]
        private List<RestfulScheduleModel> schedule;
         
        public RestfulGeneralCourseModel()
        {
        }

        public string Name { get => name; set => name = value; }
        public string ParcialGrade { get => parcialGrade; set => parcialGrade = value; }
        public string Absence { get => absence; set => absence = value; }
        public string Id { get => id; set => id = value; }
        public List<RestfulScheduleModel> Schedule { get => schedule; set => schedule = value; }
    }
}
