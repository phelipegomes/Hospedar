using Hospedar.Models;
using Hospedar.Views;
using Hospedar.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedar
{
        public partial class Hospedar : Form
        {
            public Hospedar()
            {
                InitializeComponent();
            }

            private void guna2TextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void btnSair_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnEntrar_Click(object sender, EventArgs e)
            {              
                
                Controle controle = new Controle();
                controle.acessar(txbUsuario.Text, txbSenha.Text);
                if (controle.message.Equals(""))
                {
                    if (controle.has)
                    {
                        labelError.Visible = false;
                        MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard ds = new Dashboard();
                        this.Hide();
                        ds.Show();
                    }

                    else
                    {
                        labelError.Visible = true;
                        txbSenha.Clear();
                    }
                }

                else
                {
                    MessageBox.Show(controle.message);
                }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal class All_User_Control
        {
            internal class UC_AddQuarto
            {
                public Color BackColor { get; internal set; }
                public bool Visible { get; internal set; }

                internal object BringToFront()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
