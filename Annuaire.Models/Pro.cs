using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models
{
    public class Pro : IPro
    {
        public Pro() { }
        public Pro(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public bool EstSignaler { get; set; }

        public string Nom { get; set; }
        public DateTime DateDeCreation { get; set; }
        public int Anciennete { get; }
        public IEnumerable<IRegion> Regions { get; set; }
        public string Description { get; set; }
        public float NoteMoyenne { get; set; }
        public string InformationsLegales { get; set; }
        public string Horaires { get; set; }

        public IEnumerable<IContact> Contacts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEvaluation> EvaluationsDonnees()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEvaluation> EvaluationsRecues()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IService> ServicesProposes()
        {
            throw new NotImplementedException();
        }
    }
}
