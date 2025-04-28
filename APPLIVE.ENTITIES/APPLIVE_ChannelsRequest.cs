using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLIVE.ENTITIES
{
    public class APPLIVE_ChannelsRequest
    {
        public string Search { get; set; } = "defaultSearch";   // Valor predeterminado
        public string Country { get; set; } = "defaultCountry"; // Valor predeterminado
        public string Category { get; set; } = "defaultCategory";
    }
}
