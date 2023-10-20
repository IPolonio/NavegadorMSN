using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVEGADOR
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Navegador1.ScriptErrorsSuppressed = true;

            Navegador1.Navigate("www.google.com");
            
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e )
        {

            string url = URLNAVEGADOR.Text;
            if (url.Contains(".com"))
            {
               
                Navegador1.Navigate(url);
            }
            else
            {
               
                Navegador1.Navigate(url + ".com");
            }
            Navegador1.ScriptErrorsSuppressed = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Navegador1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Navegador1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Navegador1.Navigate("WWW.google.com");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Navegador1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Navegador1.Stop();
        }
     
        

        private void URLNAVEGADOR_Click(object sender, EventArgs e)
        {
            URLNAVEGADOR.SelectAll();
        }

        private void URLNAVEGADOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string url = URLNAVEGADOR.Text;
                if (url.Contains(".com"))
                {
                    // Realizar acciones específicas cuando la URL contiene ".com"
                    Navegador1.Navigate(url);
                }
                else
                {
                    // Realizar acciones específicas cuando la URL no contiene ".com"
                    Navegador1.Navigate(url + ".com");
                }
            }
          
        }
    }
}
