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
    public partial class Usuarios : Form
    {
        Modelo.tb_usuarios user = new Modelo.tb_usuarios();
        public Usuarios()
        {
            InitializeComponent();
        }
        void CargarDatos()
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {
                var Jointablas = from tbusuario in db.tb_usuarios                             

                                 select new
                                 {
                                     
                                     Email = tbusuario.Email,
                                     Contraseña = tbusuario.Contraseña,
                                    
                                 };
                             
                    dtvUsuarios.DataSource = Jointablas.ToList();
              
            }
        }
        void LimpiarDatos()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {
                var Jointablas = from tbusuario in db.tb_usuarios

                                 select new
                                 {                                  
                                     Usuario = tbusuario.Email,
                                     Contraseña = tbusuario.Contraseña,

                                 };

                dtvUsuarios.DataSource = Jointablas.ToList();
            }

        }

            private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarId => VerificarId.IdUsuario == Idc).First();
                user.Email = txtUsuario.Text;
                user.Contraseña = txtContra.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {

                user.Email = txtUsuario.Text;
                user.Contraseña = txtContra.Text;
                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SistemaDeVentasEntities db = new SistemaDeVentasEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Email = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Contra = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = Email;
            txtContra.Text = Contra;
        }

        private void liklblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vistas.Menu menu = new Vistas.Menu();
            menu.Show();
            this.Hide();
        }
    }
}
