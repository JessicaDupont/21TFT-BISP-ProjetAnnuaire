using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Tables
{
    public class TUsers : ITable
    {
        public string NomTable => "[Users]";
        public string Id => "Id";
        public string DateInscription => "Inscription";
        public string DateLastConnexion => "Connexion";
        public string RoleIdEnum => "Role";
        public string MethodeDeConnexion => "MethodeDeConnexion";
        public string Login => "Login";
        public string PassWord => "Mdp";
        public string CommentaireMode => "CommentaireModeration";
    }
}