using Plugin.CloudFirestore;
using ResturantReserve.ModelsLogic;
using System.Collections.ObjectModel;

namespace ResturantReserve.Models
{
    internal class GamesModel
    {
        protected FbData fbd = new();
        protected IListenerRegistration? ilr;

        public bool IsBusy { get; set; }
        public ObservableCollection<Game>? GamesList { get; set; } = [];

        public EventHandler<bool>? OnGameAdded;
        public EventHandler? OnGamesChanged;
    }
}
