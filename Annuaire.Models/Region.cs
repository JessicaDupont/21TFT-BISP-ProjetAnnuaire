using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.Enums;

namespace Annuaire.Models
{
    public class Region : IRegion
    {
        public Region() 
        {
            DonneesRecuperees = false;
        }
        public Region(int id) : this()
        {
            Id = id;
        }
        public Region(int id, int codePostal, string ville, string pays, string continent)
        {
            Id = id;
            CodePostal = codePostal;
            Ville = ville;
            Pays = pays;
            Continent = (Continents)Enum.Parse(typeof(Continents), continent);
            DonneesRecuperees = true;
        }

        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }

        public Continents Continent { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
    }
}
