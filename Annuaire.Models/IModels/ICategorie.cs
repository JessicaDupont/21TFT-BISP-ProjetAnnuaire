using Annuaire.Models.Bases;

namespace Annuaire.Models.IModels
{
    public interface ICategorie : IModel
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public ICategorie Parent { get; set; }
    }
}