namespace Objet.Views
{
    public partial class LoginBuisnessPage : ContentPage
    {
        public LoginBuisnessPage(LoginBuisnessViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "LocaLost Buisness";
            BindingContext = viewModel;
        }
    }
}
