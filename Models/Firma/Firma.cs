using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FirmaDigital.Models.Firma
{
    [DataContract]
    public class Firma
    {
        [DataMember(Name = "firma")]
        public IFormFile Firma_ { get; set; }
    }
}
