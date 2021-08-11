using Annuaire.Models.Bases;

namespace Annuaire.Models.IModels
{
    public interface IEvaluation : IModel, IAlerte
    {
        public IPrestation Prestation { get; set; }
        public IUser Auteur { get; set; }
        public bool AuteurEstPro { get; set; }
        public IUser Utilisateur { get; set; }
        public int Note { get; set; }
        public string Commentaire { get; set; }
    }
}