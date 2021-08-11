using Annuaire.Models.Bases;

namespace Annuaire.Models.IModels
{
    public interface IService : IModel, IAlerte
    {
        public ICategorie Categorie { get; set; }
        public string Pourquoi { get; set; }
        public string Prix { get; set; }
    }
}