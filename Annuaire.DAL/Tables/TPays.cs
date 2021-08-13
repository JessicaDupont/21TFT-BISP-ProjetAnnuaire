using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class TPays : ITable
    {
        public string NomTable => "[Pays]";
        public string Id => "Id";
        public string Nom => "Nom";
        public string ContinentIdEnum => "Continent";
    }
}