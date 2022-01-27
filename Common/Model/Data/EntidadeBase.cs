using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Data
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
    }
}
