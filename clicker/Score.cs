using System;
using System.IO;
using System.Windows.Forms;

namespace clicker
{
    class Score
    {
        private string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private int _rec;
        private int _pontos;
        private int _tempo = 10;

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
            _tempo = 10;
            return (_tempo).ToString();
        }

        public void Gravar()
        {
            _rec = Int32.Parse(File.ReadAllText(_path));
            if (_pontos > _rec)
            {
                File.WriteAllText(_path, _pontos.ToString());
            }
        }
        public string Ler
        {
            get
            {
                _rec = Int32.Parse(File.ReadAllText(_path));
                return _rec.ToString();
            }
        }
    }
}
