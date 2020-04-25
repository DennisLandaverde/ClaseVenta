using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionDeTablas.Modelo;

namespace UnionDeTablas
{
    public partial class LOGUIN : Form
    {
        public LOGUIN()
        {
            InitializeComponent();
        }

        private void LOGUIN_Load(object sender, EventArgs e)
        {

        }

        private void linklblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {
                var Lista = from Usuario in db.tb_usuarios
                            where Usuario.Email == txtUsuario.Text
                            && Usuario.Contraseña == txtContraseña.Text
                            select Usuario;

                if (Lista.Count() > 0)
                {
                    MessageBox.Show("Haz iniciado sesion como:  " + txtUsuario.Text);
                    Vistas.Menu menu = new Vistas.Menu();
                    menu.Show();
                    this.Hide();
                }



                else
                {
                    MessageBox.Show("El Usuario no existe en el sistema");
                }

            }
        }
    }
}
