using Annuaire.Models.Bases;
using System;
using System.Collections.Generic;

namespace Annuaire.Models.IModels
{
    public interface IPersonne : IModel, IAlerte
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public int Age { get; }
        public IRegion Region { get; set; }
        public string Description { get; set; }
        public float NoteMoyenne { get; set; }

        public IEnumerable<IContact> Contacts();
        public IEnumerable<IService> ServicesDemandes();
        public IEnumerable<IPrestation> PrestationsRecues();
        public IEnumerable<IEvaluation> EvaluationsRecues();
        public IEnumerable<IEvaluation> EvaluationsDonnees();
    }
}