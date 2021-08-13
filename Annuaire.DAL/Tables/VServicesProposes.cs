using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class VServicesProposes : ITable
    {
        public string NomTable => "[ServicesProposes]";
        public string ServiceId => "ServiceId";
        public string CategorieId => "CategorieId";
        public string UserId => "UserId";
        public string Pourquoi => "Pourquoi";
        public string Prix => "Prix";
        public string FraisDeDeplacement => "Frais";
        public string RegionId => "RegionId";
        public string CodePostal => "Code_Postal";
        public string Ville => "Ville";
        public string Pays => "Pays";
        public string ContinentTextEnum => "Continent";
        public string Alerte => "Alerte";
    }
}
