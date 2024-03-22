using System.Collections.Generic;
using System.Web.Http;

namespace CX_WebApi1.Controllers
{
    [Route("api/manipulacao-string")]
    public class StringController : ApiController
    {
        /// <summary>
        /// Fornece a verificação se o campo texto é palíndromo.
        /// </summary>
        /// <param name="entrada">Formato de Entrada (JSON): {"texto":"string de entrada"}</param>
        public dynamic Post([FromBody]Models.StringModel entrada)
        {
            if (!(entrada is Models.StringModel))
            {
                return new Models.Erro() { mensagemErro = "Ocorreu um erro.",
                    detalhe = "Não foi possível realizar a análise: O parâmetro de entrada não está no formato esperado." };
            }

            if (string.IsNullOrEmpty(entrada.texto))
            {
                return new Models.Erro() { mensagemErro = "Ocorreu um erro.",
                    detalhe = "Não é possível realizar a análise: O texto de entrada está nulo ou vazio." };
            }

            var saida = new Models.SaidaModel();
            saida.palindromo = true;
            string stringAnalisar = entrada.texto;

            for (int i = 0; i < stringAnalisar.Length; i++)
            {
                var caracterDaVez = stringAnalisar[i];
                if (saida.ocorrencias_caracteres.ContainsKey(caracterDaVez))
                {
                    saida.ocorrencias_caracteres[caracterDaVez]++;
                }
                else
                {
                    saida.ocorrencias_caracteres.Add(caracterDaVez, 1);
                }

                int j = stringAnalisar.Length - i - 1;
                if (!caracterDaVez.Equals(stringAnalisar[j]))
                {
                    saida.palindromo = false;
                }
            }

            return saida;
        }
    }
}