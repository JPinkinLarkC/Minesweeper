using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_InterfazGráfica
{
    class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Width_ValueChanged(this, null);
        }

        private void ClickDifficultad(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel();
            switch (((Button)sender).Text)
            {
                case "F":
                    nivel.game = new Game<Celda>(6, 7, 10);
                    break;
                case "N":
                    nivel.game = new Game<Celda>(9, 10, 15);
                    break;
                case "D":
                    nivel.game = new Game<Celda>(14,15,40);
                    break;
                case "P":
                    nivel.game = new Game<Celda>((int)Width.Value, (int)Height.Value, (int)Minas.Value);
                    break;
            }
            nivel.Show();
            this.Hide();
        }

        private void Height_ValueChanged(object sender, EventArgs e)
        {
            this.Minas_Maximum = (this.Width.Value * this.Height.Value) - 5;
        }
    }
}
