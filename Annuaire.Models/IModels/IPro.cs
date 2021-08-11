using Annuaire.Models.Bases;
using System;
using System.Collections.Generic;

namespace Annuaire.Models.IModels
{
    public interface IPro : IModel, IAlerte
    {
        public string Nom { get; set; }
        public DateTime DateDeCreation { get; set; }
        public int Anciennete { get; }
        public IEnumerable<IRegion> Regions { get; set; }
        public string Description { get; set; }
        public float NoteMoyenne { get; set; }
        public string InformationsLegales { get; set; }
        public string Horaires { get; set; }

        public IEnumerable<IContact> Contacts();
        public IEnumerable<IService> ServicesProposes();
        public IEnumerable<IEvaluation> EvaluationsRecues();
        public IEnumerable<IEvaluation> EvaluationsDonnees();
    }
}