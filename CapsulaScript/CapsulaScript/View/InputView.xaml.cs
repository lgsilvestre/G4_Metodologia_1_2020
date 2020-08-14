using CapsulaScript.Model;
using CapsulaScript.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            SPFlag = false;
        }


        public bool SPFlag { get; set; }

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
            Globals.FormattedText.InvertText();
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
            AppendStringToInput("«");
        }
        private void Menu_item2(object sender, RoutedEventArgs e)
        {
            AppendStringToInput("»");
        }
        private void Menu_item3(object sender, RoutedEventArgs e)
        {
            AppendStringToInput("“");
        }
        private void Menu_item4(object sender, RoutedEventArgs e)
        {
            AppendStringToInput("”");
        }
        private void Menu_item5(object sender, RoutedEventArgs e)
        {
            AppendStringToInput("'");
        }
        private void Menu_item6(object sender, RoutedEventArgs e)
        {
            AppendStringToInput("'");
        }
        private void Menu_item7(object sender, RoutedEventArgs e)
        {
            AppendStringToInput("...");
        }

        private void AppendStringToInput(string str)
        {
            TextCanvas.AppendText(str);
            TextCanvas.CaretIndex += str.Length;
            SPFlag = true;
        }

        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Globals.canvasWidth = canvas.ActualWidth;
            Globals.canvasHeight = canvas.ActualHeight;
        }

        private void TextCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsValidKey(e))
                e.Handled = true;
        }

        private void TextCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text.Contains("´"))
            {
                text = text.Replace("´", "");
                (sender as TextBox).Text = text;
                (sender as TextBox).CaretIndex = text.Length;
            }
        }

        private bool IsValidKey(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Q:
                    return true;
                case Key.W:
                    return true;
                case Key.E:
                    return true;
                case Key.R:
                    return true;
                case Key.T:
                    return true;
                case Key.Y:
                    return true;
                case Key.U:
                    return true;
                case Key.I:
                    return true;
                case Key.O:
                    return true;
                case Key.P:
                    return true;
                case Key.A:
                    return true;
                case Key.S:
                    return true;
                case Key.D:
                    return true;
                case Key.F:
                    return true;
                case Key.G:
                    return true;
                case Key.H:
                    return true;
                case Key.J:
                    return true;
                case Key.K:
                    return true;
                case Key.L:
                    return true;
                case Key.Oem3:
                    return true;
                case Key.Z:
                    return true;
                case Key.X:
                    return true;
                case Key.C:
                    return true;
                case Key.V:
                    return true;
                case Key.B:
                    return true;
                case Key.N:
                    return true;
                case Key.M:
                    return true;
                case Key.Oem1:
                    return true;
                case Key.DeadCharProcessed:
                    return true;
                default:
                    return false;
            }
        }

        
    }
}
