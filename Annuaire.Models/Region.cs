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
        public Region() { }
        public Region(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public Continents Continent { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
    }
}
