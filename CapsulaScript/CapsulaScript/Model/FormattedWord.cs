using CapsulaScript.MVVMHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsulaScript.Model
{
    public class FormattedWord : OnPropertyChangedBase
    {

        private string _Word;
        public string Word
        {
            get { return _Word; }
            set
            {
                if (_Word == value) return;
                _Word = value;
                OnPropertyChanged();
            }
        }

        private int _FontSize;
        public int FontSize
        {
            get { return _FontSize; }
            set
            {
                if (_FontSize == value) return;
                _FontSize = value;
                OnPropertyChanged();
            }
        }

        private string _FontWeight;
        public string FontWeight
        {
            get { return _FontWeight; }
            set
            {
                if (_FontWeight == value) return;
                _FontWeight = value;
                OnPropertyChanged();
            }
        }

        private string _FontStyle;
        public string FontStyle
        {
            get { return _FontStyle; }
            set
            {
                if (_FontStyle == value) return;
                _FontStyle = value;
                OnPropertyChanged();
            }
        }

        private bool _Underline;
        public bool Underline
        {
            get { return _Underline; }
            set
            {
                if (_Underline == value) return;
                _Underline = value;
                OnPropertyChanged();
            }
        }
    }
}
