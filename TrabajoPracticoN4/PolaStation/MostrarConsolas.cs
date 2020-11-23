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
    public partial class MostrarConsolas : Form
    {
        public MostrarConsolas(List<PS> list)
        {
            InitializeComponent();
            foreach (PS g in list)
            {
                rtbConsolas.Text = PS.MostrarDatosPS(list);

            }
        }
    }
}
