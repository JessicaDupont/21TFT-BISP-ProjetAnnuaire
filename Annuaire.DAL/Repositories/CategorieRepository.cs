using Annuaire.DAL.Mapping;
using Annuaire.DAL.Repositories.Bases;
using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.DataBases.Repositories;

namespace Annuaire.DAL.Repositories
{
    public class CategorieRepository : RepositoryBase, ICategorieRepository
    {
        private readonly CategorieMapping mapCategorie;

        public CategorieRepository() : base()
        {
            mapCategorie = new CategorieMapping();
        }

        public IEnumerable<ICategorie> Search(Filtre filtre)
        {
            //Trouver les categories enfants
            if (filtre.Champ.Equals("Enfants"))
            {
                Command cmd = new Command("select * from [Categories]", false);
                IEnumerable<ICategorie> toutes = connect.ExecuteReader(
                    cmd, 
                    reader => mapCategorie.Mapping(reader));
                var r = ObtenirEnfants(toutes, (int)filtre.Valeur);
                IEnumerable<ICategorie> result = toutes.Where(x => r.Contains(x.Id));
                return result;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<ICategorie> Search(IEnumerable<Filtre> filtres)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<int> ObtenirEnfants(IEnumerable<ICategorie> toutes, int valeur)
        {
            List<int> result = new List<int>();
            //on ajoute la catégorie sélectionnée
            result.Add(toutes
                .Where(x => x.Id == valeur)
                .Select(x => x.Id)
                .First());
            //on trouve ses enfants
            IEnumerable<ICategorie> enfants = toutes.Where(x => x.Parent?.Id == valeur);
            //pour chaque enfant, on trouve son petit-enfant et on les ajoute
            foreach (ICategorie cat in enfants)
            {
                result.AddRange(ObtenirEnfants(toutes, cat.Id));
            }
            return result;
        }

    }
}
