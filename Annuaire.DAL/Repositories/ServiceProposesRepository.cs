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

namespace Annuaire.DAL.Repositories
{
    public class ServiceProposesRepository : RepositoryBase, IServiceProposesRepository
    {
        private ServiceMapping mapService;

        public ServiceProposesRepository() : base()
        {
            mapService = new ServiceMapping();
        }

        public IServicePropose Create(IService model)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Create(IServicePropose model)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Delete(IService model)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Delete(IServicePropose model)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Read()
        {
            Command cmd = new Command("" +
                "select * from [Services] " +
                "where EstDemande = 0 "
                , false);
            IEnumerable<IServicePropose> result = connect.ExecuteReader(cmd, reader => (IServicePropose)mapService.Mapping(reader));
            return result;
        }

        public IEnumerable<IServicePropose> Search(string champ, bool valeur)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(string champ, int valeur)
        {
            if (champ.Equals("CategorieId"))
            { 
                Command cmd = new Command("" +
                    "select * from [Services] " +
                    "where EstDemande = 0 " +
                    "and CategorieId = @catId ", false);
                cmd.AddParameter("catId", valeur);
                IEnumerable<IServicePropose> result = connect.ExecuteReader(cmd, reader => (IServicePropose)mapService.Mapping(reader));
                return result;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(string champ, string valeur)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(string champ, DateTime valeur)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(string champ, TimeSpan valeur)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(IDictionary<string, object> filtres)
        {
            throw new NotImplementedException();
        }

        public IServicePropose Update(int id, IServicePropose model)
        {
            throw new NotImplementedException();
        }
    }
}
