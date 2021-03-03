using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm
{
    class Dog : Animal
    {
        private string _name;

        public Dog(string name)
            : base("pies")
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
            MessageBox.Show("Hau! Hau!");
        }
    }
}
