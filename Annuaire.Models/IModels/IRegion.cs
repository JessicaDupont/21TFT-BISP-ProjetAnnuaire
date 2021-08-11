using Annuaire.Models.Bases;
using ToolIca.Geographie;

namespace Annuaire.Models.IModels
{
    public interface IRegion : IModel
    {
        public Continents Continent { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
    }
}