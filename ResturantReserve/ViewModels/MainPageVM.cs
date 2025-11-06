using ResturantReserve.Models;
using ResturantReserve.ModelsLogic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ResturantReserve.ViewModels
{
    internal class MainPageVM : ObservableObject
    {
        private readonly User user = new();
        private readonly Games games = new();
        public ICommand AddGameCommand => new Command(AddGame);
        public bool IsBusy => games.IsBusy;
        public ObservableCollection<Game>? GamesList => games.GamesList;

        public MainPageVM()
        {
            games.OnGameAdded += OnGameAdded;
            games.OnGamesChanged += OnGamesChanged;
        }
        public string UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;

            }
        }

        private void AddGame()
        {
            games.AddGame();
            OnPropertyChanged(nameof(IsBusy));
        }
        private void OnGamesChanged(object? sender, EventArgs e)
        {
            OnPropertyChanged(nameof(GamesList));
        }
        private void OnGameAdded(object? sender, bool e)
        {
            OnPropertyChanged(nameof(IsBusy));
        }
        internal void AddSnapshotListener()
        {
            games.AddSnapshotListener();
        }
        internal void RemoveSnapshotListener()
        {
            games.RemoveSnapshotListener();
        }
    }
}

