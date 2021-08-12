using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models.Bases
{
    public interface IModel : ToolIca.Models.Bases.IModelBase
    {
        //public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }
    }
}
