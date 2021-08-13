using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class TServices : ITable
    {
        public TServices()
        {
            Categories = new TCategories();
            Users = new TUsers();
            Regions = new TRegions();
            RegionsUsers = new TRegionsUsers();
        }
        public string NomTable => "[Services]";
        public string ServiceId => "Id";
        public string CategorieId => "CatgorieId";
        public TCategories Categories { get; set; }
        public string UserId => "UserId";
        public TUsers Users { get; set; }
        public string EstUneDemande => "EstDemande";
        public string RegionId => "RegionId";
        public TRegions Regions { get; set; }
        public TRegionsUsers RegionsUsers { get; set; }
        public string Adresse => "Adresse";
        public string Pourquoi => "Pourquoi";
        public string QuandCombien => "QuandCombien";
        public string Prix => "Prix";
        public string Alerte => "Alerte";
    }
}
