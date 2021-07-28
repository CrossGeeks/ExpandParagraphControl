using ExpandParagraphControl.ViewModels;
using Xamarin.Forms;

namespace ExpandParagraphControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
