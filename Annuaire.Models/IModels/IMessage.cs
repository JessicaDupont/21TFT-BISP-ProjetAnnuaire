using Annuaire.Models.Bases;
using System;

namespace Annuaire.Models.IModels
{
    public interface IMessage : IModel, IAlerte
    {
        public IUser Emetteur { get; set; }
        public DateTime Envoi { get; set; }
        public string Message { get; set; }
    }
}