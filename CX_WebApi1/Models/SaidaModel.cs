using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace CX_WebApi1.Models
{
    public class SaidaModel
    {
        public bool palindromo { get; set; }
        public Dictionary<char, int> ocorrencias_caracteres { get; set; } = new Dictionary<char, int>();

        public override string ToString() => new JavaScriptSerializer().Serialize(this);
    }
}