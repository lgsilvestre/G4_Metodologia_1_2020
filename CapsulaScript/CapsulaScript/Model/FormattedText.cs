using CapsulaScript.MVVMHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapsulaScript.Model
{
    public class FormattedText : OnPropertyChangedBase
    {
        public FormattedText()
        {
            Words = new ObservableCollection<FormattedWord>();                
        }

        private string _Text;
        public string Text
        {
            get { return _Text; }
            set
            {
                if (_Text == value) return;
                _Text = value;
                SplitText();
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

        private ObservableCollection<FormattedWord> _Words;
        public ObservableCollection<FormattedWord> Words
        {
            get { return _Words; }
            set
            {
                if (_Words == value) return;
                _Words = value;
                OnPropertyChanged();
            }
        }

        private void SplitText()
        {
            Text = Regex.Replace(Text, @"\s+", " ");
            List<string> strList = Text.Split(new char[] { ' ' }).ToList();
            Words.Clear();
            foreach (string splitted in strList)
            {
                //TO DO applicar formato aca en el constructor de FormattedWord
                FormattedWord fw = new FormattedWord();
                fw.Word = $"{splitted.Trim()} ";
                Words.Add(fw);
            }
        }
    }
}
