using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
namespace PolaStation
{
    public partial class MostrarBD : Form 
    {
        public MostrarBD(List<Games> list)
        {
            InitializeComponent();
            foreach (Games g in list)
            {
                richtxtDatos.Text = Games.MostrarDatos(list);

            }
        }

        
    }
}
