using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;

using System.IO;//Utilizada para crear las carpetas

namespace GestorBD
{
    public partial class frmMain : MetroForm
    {
        string BDSeleccionada=null;
        string Usando=null;//Es el nombre de la BD que se encuentra en uso
        string DirectorioPrincipal = Application.StartupPath + @"\BasesDeDatos\";

        public frmMain()
        {
            InitializeComponent();
            CargarBD();
            dgBD.ClearSelection();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarBD();
            dgBD.ClearSelection();
        }

        private void CargarBD() {//Actualizar Datagrid
            dgBD.Rows.Clear();//limpiar el dataGridView
            DirectoryInfo di = new DirectoryInfo(DirectorioPrincipal);
            foreach (var fi in di.GetDirectories())
            {
                dgBD.Rows.Add(fi.Name);
            }
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            //el valor de nomCarpeta se obtiene del evento dgBD_CellContentClick
            if (BDSeleccionada == null)
            {
                MetroMessageBox.Show(this,"Seleccione una base de datos");
            }
            else
            {
                if (Usando == null)
                {
                    Usando = BDSeleccionada;
                    MetroMessageBox.Show(this,"La base de datos: " + Usando + " se inicio correctamente");
                }
                else
                    MetroMessageBox.Show(this, "La base de datos: " + Usando + " se encuentra en uso", "Alerta", MessageBoxButtons.OK);
            }
            //Si la BD, ya esta en uso, ignorar
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if(Usando!=null && BDSeleccionada!=null)
            {
                //En esta ruta te encuentras dentro del directorio de la BD que esta en uso
                string ruta = Application.StartupPath + @"\BasesDeDatos\" + Usando + @"\";
                this.Visible = false;
                frmTables Siguiente = new frmTables(this, Usando, ruta);
                Siguiente.Visible = true;
                Siguiente.Focus();
            }
            else
                MetroMessageBox.Show(this, "Seleccione una base de datos", "Alerta", MessageBoxButtons.OK);
        

    }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmNueva Nueva = new frmNueva();

            try
            {
                if (Nueva.ShowDialog() == DialogResult.OK)
                {
                    string Texto = Nueva.txtNombre.Text;//Nombre de la base de datos
                    string carpe = Application.StartupPath + @"\BasesDeDatos\";
                    string carpeta = carpe + Texto;             
                    

                    if (Directory.Exists(carpeta))
                    {
                        MetroMessageBox.Show(this, "La base de datos ya existe");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La base de datos a sido creada con exito");
                        Directory.CreateDirectory(carpeta);
                    }

                    CargarBD();
               
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //el valor de nomCarpeta se obtiene del evento dgBD_CellContentClick
            if (Usando!=null && BDSeleccionada == Usando)
            {
                MetroMessageBox.Show(this, "La base de datos: " + Usando + " se encuentra en uso");
            }
            else
            {
                if (BDSeleccionada != null)
                {
                    string carpet = Application.StartupPath + @"\BasesDeDatos\";
                    DirectoryInfo dir = new DirectoryInfo(carpet);
                    foreach (var fi in dir.GetDirectories())
                    {
                        if (BDSeleccionada == fi.Name)
                        {
                            //el valor de true sirve para borrar los archivos de forma recursiva,
                            //borra todos los archivos que se encuentra dentro del directorio
                            Directory.Delete(carpet + BDSeleccionada, true);
                            MetroMessageBox.Show(this,"La Base de Datos "+BDSeleccionada+" ha sido eliminada con exito!");
                            break;
                        }
                    }
                    Usando = null;
                    BDSeleccionada = null;
                }
                else
                    MetroMessageBox.Show(this,"Selecciona una base de datos");
            }

            CargarBD();

        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            if(Usando!=null)
            {
                MetroMessageBox.Show(this,"La base de datos: "+ Usando + " ya no esta en uso");
                Usando = null;
            }
            else
                MetroMessageBox.Show(this, "Ninguna base de datos se encuentra en uso", "Alerta", MessageBoxButtons.OK);
        
        //Que haya alguna BD en uso
        //Quitar la BD en uso

    }

        private void dgBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            int p = e.ColumnIndex;
            try
            {
                //obtiene el nombre de la carpeta seleccionada
                BDSeleccionada = dgBD.Rows[pos].Cells[p].Value.ToString();
            }
            catch { }
         }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"Para acceder a modificar la BD, primero debes seleccionarla de la lista, y dar click en el botón de UsarBD");
            MetroMessageBox.Show(this,"Si deseas borrar una BD, esta no debe estar en uso, para ello puedes desusarla con el botón DesUsar BD");
            MetroMessageBox.Show(this,"Las BD creadas y mostradas por el sistema, estan en una carpeta por defecto, esta no puede cambiarse, pero es relativa a la carpeta donde se encuentre el programa");
        }
    }
}
