using System.Web.Script.Serialization;

namespace CX_WebApi1.Models
{
    public class StringModel
    {
        public string texto { get; set; }

        public override string ToString() => new JavaScriptSerializer().Serialize(this);
    }
}