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
    }
}
