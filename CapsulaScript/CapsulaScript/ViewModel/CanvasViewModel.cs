using CapsulaScript.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapsulaScript.ViewModel
{
    class CanvasViewModel : ViewModelBase
    {

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

        private Visibility _PlaceHolder;
        public Visibility PlaceHolder
        {
            get { return _PlaceHolder; }
            set
            {
                if (_PlaceHolder == value) return;
                _PlaceHolder = value;
                OnPropertyChanged();
            }
        }
    }
}
