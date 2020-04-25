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

namespace UnionDeTablas.Vistas
{
    public partial class ROLES : Form
    {
        public ROLES()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void ROLES_Load(object sender, EventArgs e)
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {
                var Jointablas = from tbusuario in db.tb_usuarios
                                 from roles_usuarios in db.roles_usuarios
                                 where tbusuario.IdUsuario == roles_usuarios.Id_RolUsuario

                                 select new
                                 {
                                     
                                     Usuario = tbusuario.Email,
                                     Rol = roles_usuarios.TipoDeRol



                                 };

                
                    dtvRoles.DataSource = Jointablas.ToList();

              

            }
        }

        private void liklblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vistas.Menu menu = new Vistas.Menu();
            menu.Show();
            this.Hide();
        }
    }
}
