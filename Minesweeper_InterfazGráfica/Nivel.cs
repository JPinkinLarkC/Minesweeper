using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper;

namespace Minesweeper_InterfazGráfica
{
    public partial class Nivel : Form
    {
        public Game<Celda> game;

        public Nivel()
        {
            InitializeComponent();
        }

        public void GetStatus()
        {
            this.MinasRestantesText.Text = game.FlagCounter + "";
        }
        
        public void CreateGrid()
        {
            for (uint i = 0; i < this.game.WidthGetter; i++)
            {
                this.GridCeldas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            for (uint i = 0; i < this.game.HeightGetter; i++)
            {
                this.GridCeldas.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            for (uint i = 0; i < this.game.WidthGetter; i++)
            {
                for (int j = 0; j < this.game.HeightGetter; j++)
                {

                }
            }

        }

        private void Nivel_Load(object sender, EventArgs e)
        {
            if (game != null)
            {
                this.GetStatus();
            }
        }

    }
}
