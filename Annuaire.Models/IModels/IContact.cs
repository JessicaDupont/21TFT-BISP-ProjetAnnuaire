using Annuaire.Models.Bases;
using ToolIca.Enums;

namespace Annuaire.Models.IModels
{
    public interface IContact : IModel, IAlerte
    {
        public ModesContact Type { get; set; }
        public string Valeur { get; set; }
        public Visibilites Visibilite { get; set; }
    }
}