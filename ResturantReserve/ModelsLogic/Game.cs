using Microsoft.Maui.Controls;
using ResturantReserve.Models;

namespace ResturantReserve.ModelsLogic
{
    internal class Game : GameModel
    {
        internal Game()
        {
            HostName = new User().Name;
            Created = DateTime.Now;
        }

        public override void SetDocument(Action<System.Threading.Tasks.Task> OnComplete)
        {
            Id = fbd.SetDocument(this, Keys.GamesCollection, Id, OnComplete);
        }


    }
}

