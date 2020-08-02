using CapsulaScript.MVVMHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsulaScript.Model
{
    public class FormattedText : OnPropertyChangedBase
    {

        private string _Text;
        public string Text
        {
            get { return _Text; }
            set
            {
                if (_Text == value) return;
                _Text = value;
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
                OnPropertyChanged();
            }
        }

        private List<FormattedWord> _Words;
        public List<FormattedWord> Words
        {
            get { return _Words; }
            set
            {
                if (_Words == value) return;
                _Words = value;
                OnPropertyChanged();
            }
        }
    }
}
