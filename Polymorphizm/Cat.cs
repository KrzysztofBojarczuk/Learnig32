using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm
{
    class Cat : Animal
    {
        private string _name;

        public Cat(string name) : base("kot")
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override void MakeSound()
        {
            MessageBox.Show("Miau");
        }
    }
}
