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

        private void TextCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            int caretIndex = (sender as TextBox).CaretIndex;
            //Console.WriteLine(caretIndex);
            if (caretIndex > 0)
            {
                //Console.WriteLine((sender as TextBox).Text[caretIndex - 1]);
                char newChar = (sender as TextBox).Text[caretIndex - 1];
                if (!(Char.IsLetter(newChar) || Char.IsWhiteSpace(newChar)))
                {
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(caretIndex - 1, 1);
                    (sender as TextBox).CaretIndex = caretIndex - 1;
                }
            }
        }

        private void TextCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            int caretIndex = (sender as TextBox).CaretIndex;
            Console.WriteLine(caretIndex);
            if (caretIndex > 0)
            {
                Console.WriteLine((sender as TextBox).Text[caretIndex - 1]);
                char prevChar = (sender as TextBox).Text[caretIndex - 1];
                if (!(Char.IsLetter(prevChar) || Char.IsWhiteSpace(prevChar)))
                {
                    if((sender as TextBox).Text.Length != caretIndex || !SPFlag)
                    {
                        (sender as TextBox).Text = (sender as TextBox).Text.Remove(caretIndex - 1, 1);
                        (sender as TextBox).CaretIndex = caretIndex - 1;
                    }
                    SPFlag = false;
                }
            }
        }

        private bool IsValidSPChar(char character)
        {
            switch (character)
            {
                case '«':
                    return true;
                case '»':
                    return true;
                case '“':
                    return true;
                case '”':
                    return true;
                case '.':
                    return true;
                default:
                    return false;
            }
        }
    }
}
