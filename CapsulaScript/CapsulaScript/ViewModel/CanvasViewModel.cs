using CapsulaScript.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapsulaScript.ViewModel
{
    public class CanvasViewModel : ViewModelBase
    {
        public CanvasViewModel()
        {
            GlobalText = Globals.FormattedText;
            ControlPointVisibility = Visibility.Collapsed;
        }

        private FormattedText _globalText;
        public FormattedText GlobalText
        {
            get { return _globalText; }
            set
            {
                if (_globalText == value) return;
                _globalText = value;
                OnPropertyChanged();
            }
        }

        private Visibility _ControlPintVisibility;
        public Visibility ControlPointVisibility
        {
            get { return _ControlPintVisibility; }
            set
            {
                if (_ControlPintVisibility == value) return;
                _ControlPintVisibility = value;
                OnPropertyChanged();
            }
        }
    }
}
