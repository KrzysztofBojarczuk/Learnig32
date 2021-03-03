using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Gatunek: " + animal.Species);
            animal.MakeSound();
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("zwierzę");
            ShowAnimalInfo(myAnimal);

        }

        private void createDogButton_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("Ten pies ma na imię " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        private void createCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kicia");
            MessageBox.Show("Ten kot ma na imię " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
