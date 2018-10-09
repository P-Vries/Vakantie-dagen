using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vakantiedagen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //

        private void Bereken()
        {
            //
            //Vars
            //
            byte basis = 0;
            byte uit = 0;

            if (rdbAfdeling1.Checked) { basis += 24; }
            if (rdbAfdeling2.Checked) { basis += 23; }
            if (rdbAfdeling3.Checked) { basis += 22; }
            if (rdbAfdelingO.Checked) { basis += 20; }

            int leeftijd = DateTime.Now.Year - dtpGeboorteDatum.Value.Year;
            if (leeftijd >= 50)
            {
                uit = (byte)(basis + 5);
                if(leeftijd >= 55)
                {
                    uit = (byte)(uit + (leeftijd - 54));
                }
            }
            int werktijd = DateTime.Now.Year - dtpBeginDatum.Value.Year;
            if (werktijd >= 10)
            {
                uit += 3;
            }
            lblOut.Text = uit.ToString();
            }


        //
        //Events
        //

        private void btnBereken_Click(object sender, EventArgs e)
        {
            Bereken();
        }
    }
}
