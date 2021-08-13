using Annuaire.DAL.Tables;
using Annuaire.Models;
using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.DataBases.ADO.Mapping;

namespace Annuaire.DAL.Mapping
{
    public class ServiceMapping : IMapping<DbDataReader, IService>
    {
        private readonly TServices table = new TServices();
        private readonly VServicesProposes vueP = new VServicesProposes();

        public DbDataReader Mapping(IService model)
        {
            throw new NotImplementedException();
        }

        public IService Mapping(DbDataReader data)
        {
            if ((bool)data["EstDemande"])
            {
                IServiceDemande result = new ServiceDemande((int)data[table.ServiceId]);
                result.Adresse = data[table.Adresse] == DBNull.Value ? null : (string)data[table.Adresse];
                result.Auteur = new Personne((int)data[table.UserId]);
                result.Categorie = new Categorie((int)data[table.CategorieId]);
                result.EstSignaler = (bool)data[table.Alerte];
                result.Pourquoi = (string)data[table.Pourquoi];
                result.Prix = data[table.Prix] == DBNull.Value ? null : (string)data[table.Prix];
                result.QuandCombien = data[table.QuandCombien] == DBNull.Value ? null : (string)data[table.QuandCombien];
                result.Ville = data[table.RegionId] == DBNull.Value ? null : new Region((int)data[table.RegionId]);
                result.DonneesRecuperees = true;
                return result;
            }
            else 
            {
                IServicePropose result = new ServicePropose((int)data[vueP.ServiceId]);
                //result.Auteur = new Pro((int)data["UserId"]);
                //result.Categorie = new Categorie((int)data["CategorieId"]);
                //result.EstSignaler = (bool)data["Alerte"];
                //result.Pourquoi = (string)data["Pourquoi"];
                //result.Prix = data["Prix"] == DBNull.Value ? null : (string)data["Prix"];
                result.Regions.ToList().Add(new Region(
                    (int)data[vueP.RegionId], 
                    (int)data[vueP.CodePostal],
                    (string)data[vueP.Ville],
                    (string)data[vueP.Pays],
                    (string)data[vueP.ContinentTextEnum]));
                //result.DonneesRecuperees = true;
                return result;
            }
        }
    }
}
