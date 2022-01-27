using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Data
{
    public class DatabaseInfo
    {
        public static string ObterDadosConexaoBanco()
        {
            return "Server=localhost\\SQLEXPRESS;Database=Markov;User Id=sa;Password=1234;";
        }
    }
}
