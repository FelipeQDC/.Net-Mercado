using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd_DesafioAPI.Classes
{
    internal class TokenController
    {  
            [JsonProperty(PropertyName = "token")]
            public string Token { get; set; }
            [JsonProperty(PropertyName = "Role")]
            public string Role { get; set; }
            [JsonProperty(PropertyName = "Name")]
            public string Name { get; set; }
    }

    public static class TokenGlobal
    {
        public static string TokenGlobalString = "";

        public static string NamenGlobalString = "";
    }
}
