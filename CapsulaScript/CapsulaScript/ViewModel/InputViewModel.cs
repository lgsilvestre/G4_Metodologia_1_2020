using CapsulaScript.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapsulaScript.ViewModel
{
    public class InputViewModel : ViewModelBase
    {
        public InputViewModel()
        {
            Coordinate = "0,0";
        }

        private string _Input;
        public string Input
        {
            get { return _Input; }
            set
            {
                if (_Input == value) return;
                _Input = value;
                Globals.FormattedText.Text = value;
                OnPropertyChanged();
            }
        }

        private int _Rotation;
        public int Rotation
        {
            get { return _Rotation; }
            set
            {
                if (_Rotation == value) return;
                _Rotation = value;
                OnPropertyChanged();
            }
        }


        private string _Coordinate;
        public string Coordinate
        {
            get { return _Coordinate; }
            set
            {
                if (_Coordinate == value) return;
                _Coordinate = value;
                string[] strList = Coordinate.Split(new char[] { ',' });
                TranslationX = Int32.Parse(strList[0]);
                TranslationY = Int32.Parse(strList[1]);
                Console.WriteLine();
                OnPropertyChanged();
            }
        }

        private int _TranslationX;
        public int TranslationX
        {
            get { return _TranslationX; }
            set
            {
                if (_TranslationX == value) return;
                _TranslationX = value;
                Globals.FormattedText.TranslationX = value;
                OnPropertyChanged();
            }
        }

        private int _TranslationY;
        public int TranslationY
        {
            get { return _TranslationY; }
            set
            {
                if (_TranslationY == value) return;
                _TranslationY = value;
                Globals.FormattedText.TranslationY = value;
                OnPropertyChanged();
            }
        }

        private string _Expresion;
        public string Expresion
        {
            get { return _Expresion; }
            set
            {
                if (_Expresion == value) return;
                _Expresion = value;
                Globals.Expression.Expresion = value;
                OnPropertyChanged();
            }
        }
    }
}
