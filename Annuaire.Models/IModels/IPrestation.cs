using Annuaire.Models.Bases;
using System;

namespace Annuaire.Models.IModels
{
    public interface IPrestation : IModel, IAlerte
    {
        public ICategorie Categorie { get; set; }
        public IPersonne Client { get; set; }
        public IPro Prestataire { get; set; }
        public IRegion Ville { get; set; }
        public string Adresse { get; set; }
        public float PrixHeure { get; set; }
        public DateTime Debut { get; set; }
        public TimeSpan Duree { get; set; }
    }
}