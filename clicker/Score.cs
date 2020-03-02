using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clicker
{
    class Score
    {
        private int _pontos;
        private int _tempo = 60;

        public string Conta()
        {
            if (_tempo > 0)
            {
                _pontos += 1;
            }
            return _pontos.ToString();
        }

        public string Temp()
        {
            if(_tempo > 0)
            {
                _tempo -= 1;
            }
            return _tempo.ToString();
        }

        public string ResP()
        {
            _pontos = 0;
            return (_pontos).ToString();
        }

        public string ResT()
        {
            _tempo = 60;
            return (_tempo).ToString();
        }
    }
}
