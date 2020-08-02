using CapsulaScript.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsulaScript.ViewModel
{
    public class InputViewModel : ViewModelBase
    {

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

        private Double _Rotation;
        public Double Rotation
        {
            get { return _Rotation; }
            set
            {
                if (_Rotation == value) return;
                _Rotation = value;
                Globals.FormattedText.Rotation = value;
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
                Globals.FormattedText.TranslationY = value;
                _TranslationY = value;
                OnPropertyChanged();
            }
        }
    }
}
