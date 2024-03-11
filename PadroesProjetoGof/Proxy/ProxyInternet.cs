using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //Proxy
    public class ProxyInternet : Internet
    {
        private Internet internet = new RealInternet();

        private static readonly List<string> sitesPermitidos =
          new List<string>()
            {
               "pt.wikipedia.org",
               "abc.com.br",
               "def.net",
            };

        public override void Conexao(string host)
        {
           if(!sitesPermitidos.Contains(host.ToLower()))
           {
                throw new Exception("### Acesso negado ###\n");
           }
          internet.Conexao(host);
        }
    }
}
