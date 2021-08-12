using Annuaire.DAL.Mapping;
using Annuaire.DAL.Repositories.Bases;
using Annuaire.Models;
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
    public class ServiceProposesRepository : RepositoryBase, IServiceProposesRepository
    {
        private ServiceMapping mapService;

        public ServiceProposesRepository() : base()
        {
            mapService = new ServiceMapping();
        }

        public IServicePropose Create(IServicePropose model)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Delete(IServicePropose model)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Read()
        {
            Command cmd = new Command(
                "select * from [Services] " +
                "where EstDemande = 0 "
                , false);
            IEnumerable<IServicePropose> result = connect.ExecuteReader(
                cmd, 
                reader => (IServicePropose)mapService.Mapping(reader));
            return result;
        }

        public IServicePropose Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(Filtre filtre)
        {
            if (filtre.Champ.Equals("CategorieId"))
            {
                //faire la recherche sur toutes les categories
                Command cmd = new Command("" +
                    "select * from [Services] " +
                    "where EstDemande = 0 " +
                    "and CategorieId = @catId ", false);
                cmd.AddParameter("catId", filtre.Valeur);
                IEnumerable<IServicePropose> result = connect.ExecuteReader(cmd, reader => (IServicePropose)mapService.Mapping(reader));
                return result;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(IEnumerable<Filtre> filtres)
        {
            IList<IServicePropose> result = new List<IServicePropose>();
            IEnumerable<IServicePropose> tous;
            Command cmd = new Command(
                "select * from [Services] where EstDemande = 0",
                false);
            tous = connect.ExecuteReader(
                cmd,
                reader => (IServicePropose)mapService.Mapping(reader));
            foreach (Filtre filtre in filtres)
            {
                switch (filtre.Champ)
                {
                    case "CategorieId":
                        var t = tous.Where(x => x.Categorie.Id == (int)filtre.Valeur);
                        result.Concat(t);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return result;
        }

        public IServicePropose Update(int id, IServicePropose model)
        {
            throw new NotImplementedException();
        }
    }
}
