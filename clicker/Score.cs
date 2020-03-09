using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace clicker
{
    class Score
    {
        private static string _path = Application.StartupPath + "\\Resources\\Recorde.txt";
        private int _pontos;
        private static int tmp = 10;
        private int _tempo = tmp;
        private int _rec = Int32.Parse(File.ReadAllText(_path));

        public void Move(object sender)
        {
            if (_tempo > 0)
            {
                Random r = new Random();
                int _x = int.Parse(r.Next(700).ToString());
                int _y = int.Parse(r.Next(280).ToString()) + 70;
                Point pt = new Point(_x, _y);
                Button b = (Button)sender;
                b.Location = pt;
            }
        }

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
            _tempo = tmp;
            return (_tempo).ToString();
        }

        public void ResPos(object sender)
        {
            Point pt = new Point(350, 175);
            Button b = (Button)sender;
            b.Location = pt;
        }

        public void Gravar()
        {
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