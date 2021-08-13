using Annuaire.DAL.Mapping;
using Annuaire.DAL.Repositories.Bases;
using Annuaire.DAL.Tables;
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
        private readonly VServicesProposes table;
        private ServiceMapping mapService;
        private readonly string requete;

        public ServiceProposesRepository() : base()
        {
            table = new VServicesProposes();
            mapService = new ServiceMapping();
            requete = "select * from " + table.NomTable;
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
            Command cmd = new Command(requete , false);
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
            throw new NotImplementedException();
        }

        public IEnumerable<IServicePropose> Search(IEnumerable<Filtre> filtres)
        {
            //creation de la requete
            string requeteSearch = requete + "where ";
            foreach (Filtre filtre in filtres)
            {
                switch (filtre.Champ)
                {
                    case "CategorieId":
                        requeteSearch += "("+table.CategorieId+" = "+filtre.Valeur+") or ";
                        break;
                    case "RegionId":
                        requeteSearch += "("+table.RegionId+" = " + filtre.Valeur + ") or ";
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            requeteSearch += "(1=1) " +
                "order by s.Id ";

            //recupération des résultats
            Command cmd = new Command(requeteSearch, false);
            IEnumerable<IServicePropose> liste =  connect.ExecuteReader(
                cmd,
                reader => (IServicePropose)mapService.Mapping(reader));

            return NettoyageRegions(liste);
        }

        public IServicePropose Update(int id, IServicePropose model)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<IServicePropose> NettoyageRegions(IEnumerable<IServicePropose> liste)
        {
            IDictionary<int, IServicePropose> result = new Dictionary<int, IServicePropose>();
            foreach (var item in liste)
            {
                if (result.ContainsKey(item.Id))
                {
                    //ajout region a la classe
                    result[item.Id].Regions.ToList().Add(item.Regions.First());
                }
                else
                {
                    //création du result
                    result.Add(item.Id, item);
                }
            }
            return result.Values;
        }
    }
}
