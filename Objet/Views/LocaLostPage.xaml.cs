using System.Reflection;

namespace Objet.Views
{
    public partial class LocaLostPage : ContentPage
    {
        public LocaLostPage(LocaLostViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "LocaLost";
            BindingContext = viewModel;
        }
        }
    }

