using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace MyApps.Views
{
    public partial class HomePage : Xamarin.Forms.TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}
