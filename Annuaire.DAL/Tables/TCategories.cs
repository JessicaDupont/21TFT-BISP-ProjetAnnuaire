using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class TCategories : ITable
    {
        public string NomTable => "[Categories]";
        public string Id => "Id";
        public string Nom => "Nom";
        public string Description => "Description";
        public string CategorieParent => "Categorie_Parent";
    }
}