using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progvacnat
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            lunghala.Text = apertala.Text = matfus.Text = lunghfus.Text = lunghcod.Text =
                pollcerc.Text = matcerc.Text = altgom.Text = larggom.Text =
                raggom.Text = "10";

        }


        private void Aggiunta_Click(object sender, EventArgs e)
        {
            if (lunghala.Text == string.Empty && apertala.Text == string.Empty && matfus.Text == string.Empty && lunghfus.Text == string.Empty && lunghcod.Text == string.Empty && pollcerc.Text == string.Empty && matcerc.Text == string.Empty && altgom.Text == string.Empty && larggom.Text == string.Empty && raggom.Text == string.Empty)
            {
                MessageBox.Show("Impossibile procedere");
                return;
            }
            else
            {
                classeala _ala = new classeala(double.Parse(lunghala.Text), double.Parse(apertala.Text));

                classefusoliera _fus = new classefusoliera(matfus.Text, double.Parse(lunghfus.Text));

                classecoda _coda = new classecoda(double.Parse(lunghcod.Text));

                classecerchione cerchione = new classecerchione(double.Parse(pollcerc.Text), matcerc.Text);

                classegomma gomma = new classegomma(double.Parse(altgom.Text), double.Parse(larggom.Text), double.Parse(raggom.Text));

                classeruota _ruota = new classeruota(cerchione, gomma);

                classealiante aliante = new classealiante(_ala, _fus, _coda, _ruota);
                string txt = aliante.CalcolaCosto().ToString();
                costototale.Text = txt;
                txt = aliante.Descrizione();

                descr.Text = txt;
            }
        }
    }
}
