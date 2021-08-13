using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class TRegionsUsers : ITable
    {
        public string NomTable => "[Regions_Users]";
        public string UserId => "UserId";
        public string RegionId => "RegionId";
        public string Frais => "frais";
        public string EstUnProfessionnel => "est_pro";

    }
}
