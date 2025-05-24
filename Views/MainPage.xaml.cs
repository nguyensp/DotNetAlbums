using MostPlayedAlbums.ViewModels;
using System.Windows.Input;

namespace MostPlayedAlbums
{
    public partial class MainPage : ContentPage
    {
        private readonly AlbumViewModel _viewModel;

        public MainPage(AlbumViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
            
            // Create refresh command
            RefreshCommand = new Command(async () => await _viewModel.FetchAlbumsAsync());
        }

        public ICommand RefreshCommand { get; }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.FetchAlbumsAsync();
        }
    }
}