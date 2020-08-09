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
            Globals.FormattedText.InvertText(TextCanvas);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextCanvas.AppendText(",");
            SPFlag = true;
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
    }
}
