using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.V2
{
    public class Conexao
    {
        private static Conexao _conexao { get; set; }

        public string DataBasePath { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        private Conexao()
        {

        }

        public static Conexao GetInstance()
        {
            if (_conexao == null)
                _conexao = new Conexao();

            return _conexao;
        }
    }
}