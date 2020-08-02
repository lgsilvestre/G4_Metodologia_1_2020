using CapsulaScript.MVVMHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsulaScript.Model
{
    public class Expression : OnPropertyChangedBase
    {

        private string _Expresion;
        public string Expresion
        {
            get { return _Expresion; }
            set
            {
                if (_Expresion == value) return;
                _Expresion = value;
                TokenizeExpression();
                OnPropertyChanged();
            }
        }

        private List<string> _TokenExpression;
        public List<string> TokenExpression
        {
            get { return _TokenExpression; }
            private set
            {
                if (_TokenExpression == value) return;
                _TokenExpression = value;
                OnPropertyChanged();
            }
        }

        private void TokenizeExpression()
        {
        }
    }
}
