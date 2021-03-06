﻿using CapsulaScript.MVVMHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Documents;

namespace CapsulaScript.Model
{
    public class FormattedWord : OnPropertyChangedBase
    {
        public FormattedWord()
        {
            Word = "";
            FontSize = 11;
            FontWeight = "Normal";
            FontStyle = "Normal";
            Underline = false;
        }

        public void ApplyFormat(string format)
        {
            List<string> formatList = format.Split(new char[] { '+' }).ToList();

            string search = "n";
            FontWeight = formatList.Contains(search) ? "Bold" : "Normal";

            search = "k";
            FontStyle = formatList.Contains(search) ? "Italic" : "Normal";

            search = "s";
            Underline = formatList.Contains(search);

            string resultString = Regex.Match(format, @"\d+").Value;
            int tempSize;
            if (int.TryParse(resultString, out tempSize))
            {
                FontSize = tempSize;
            }
        }

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
