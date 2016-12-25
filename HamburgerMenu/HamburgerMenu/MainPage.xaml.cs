using Microsoft.Toolkit.Uwp.UI.Animations;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

//Created and Designed by Vijay Nirmal

namespace HamburgerMenu
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            HamburgerMenu.IsPaneOpen = !HamburgerMenu.IsPaneOpen;
        }

        private void HamburgerMenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SplitViewPane_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (e.Cumulative.Translation.X < -50)
            {
                HamburgerMenu.IsPaneOpen = false;
            }

            if (e.Cumulative.Translation.X > 50)
            {
                HamburgerMenu.IsPaneOpen = true;
            }
        }

        private void SplitViewOpener_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (e.Cumulative.Translation.X > 50)
            {
                HamburgerMenu.IsPaneOpen = true;
            }
        }
    }
}
