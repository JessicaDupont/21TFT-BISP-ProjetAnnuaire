using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models
{
    public class Personne : IPersonne
    {
        public Personne() 
        {
            DonneesRecuperees = false;
        }
        public Personne(int id) : this()
        {
            Id = id;
        }

        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }
        public bool EstSignaler { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public int Age { get; }
        public IRegion Region { get; set; }
        public string Description { get; set; }
        public float NoteMoyenne { get; set; }

        public IEnumerable<IContact> Contacts()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IService> ServicesDemandes()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IPrestation> PrestationsRecues()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IEvaluation> EvaluationsRecues()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IEvaluation> EvaluationsDonnees()
        {
            throw new NotImplementedException();
        }
    }
}
