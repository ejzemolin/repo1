using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CX_WebApi1.Models
{
    public class Erro
    {
        public string mensagemErro { get; set; }
        public string detalhe { get; set; }
        public override string ToString() => $"{mensagemErro} - {detalhe}";
    }
}