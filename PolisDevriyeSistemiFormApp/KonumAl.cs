﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolisDevriyeSistemiFormApp
{
    public partial class KonumAl : Form
    {
        Konum konum;
        public KonumAl(Konum k)
        {
            konum = k;
            InitializeComponent();
        }

        private void btnKonumAl_Click(object sender, EventArgs e)
        {
            if (!(konumX.Value == 0 && konumY.Value == 0))
            {
                konum.X = konumX.Value;
                konum.Y = konumY.Value;
                Close();
            } else
            {
                MessageBox.Show("X: 0 Y: 0 hatali giris yaptiniz! ");
            }
        }
    }
}
