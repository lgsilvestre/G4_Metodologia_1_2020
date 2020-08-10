using CapsulaScript.Model;
using CapsulaScript.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CapsulaScript.View
{
    /// <summary>
    /// Interaction logic for InputView.xaml
    /// </summary>
    public partial class InputView : UserControl
    {
        public InputView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CanvasViewModel vm = (canvas.DataContext as CanvasViewModel);
            if(vm.ControlPointVisibility == Visibility.Visible)
            {
                vm.ControlPointVisibility = Visibility.Collapsed;
            }
            else
            {
                vm.ControlPointVisibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }

        private void Button_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                // Why is button.ContextMenu.DataContext null? ... when right click is O.K. but leftdown is N.G.
                button.ContextMenu.DataContext = button.DataContext;
                button.ContextMenu.IsOpen = true;
            }
        }
        private void Menu_item1(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
        private void Menu_item2(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
        private void Menu_item3(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
        private void Menu_item4(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
        private void Menu_item5(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
        private void Menu_item6(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
        private void Menu_item7(object sender, RoutedEventArgs e)
        {
            Globals.FormattedText.InvertText(TextCanvas);
        }
    }
}
