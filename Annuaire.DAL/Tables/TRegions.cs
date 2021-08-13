using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class TRegions : ITable
    {
        public TRegions()
        {
            Pays = new TPays();
        }
        public string NomTable => "[Regions]";
        public string Id => "Id";
        public string CodePostal => "Code_Postal";
        public string Ville => "Ville";
        public string PaysId => "Pays";
        public TPays Pays { get; set; }
    }
}