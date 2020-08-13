using CapsulaScript.MVVMHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CapsulaScript.Model
{
    public class FormattedText : OnPropertyChangedBase
    {
        public FormattedText()
        {
            _Text = "";
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
                Format();
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

        public void Format()
        {
            Text = Regex.Replace(Text, @"\s+", " ");
            string[] strList = Text.Split(new char[] { ' ' });
            Words.Clear();
            List<string> exp = Globals.Expression.TokenExpression;
            foreach (string splitted in strList)
            {
                FormattedWord fw = new FormattedWord
                {
                    Word = $"{splitted.Trim()} "
                };
                Words.Add(fw);
            }
            for (int i = 0; i < exp.Count; i++)
            {
                if (i < Words.Count)
                {
                    FormattedWord fw = Words.ElementAt(i);
                    string xp = exp.ElementAt(i);
                    fw.ApplyFormat(xp);
                }
            }
        }

        public void InvertText()
        {
            Words = new ObservableCollection<FormattedWord>(Words.Reverse());
        }
    }
}
