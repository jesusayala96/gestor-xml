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

using System.IO;
using System.Xml;

namespace GestorBD
{

    public partial class frmTables : MetroForm
    {
        frmMain Principal;
        string BD;
        string Tabla;
        C_XML xml = new C_XML();//objeto xml
        string rutaXML;
        string Ruta;

        List<string> Campos = new List<string>();
        XmlDocument doc = new XmlDocument();

        public frmTables()
        {
            InitializeComponent();
        }

        //Constructor que recibe forma y base a usar
        public frmTables(frmMain Inicio,string BD,string ruta)
        {
            InitializeComponent();
            rutaXML = ruta;
            Principal = Inicio;
            this.BD = BD;
            actualizaCmbTablas();
        }

        private void frmTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mostrar la forma anterior
            Principal.Visible = true;
        }

        private void frmTables_Load(object sender, EventArgs e)
        {
            //Cargar Tablas de la BD
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MetroMessageBox.Show(this,"Desea guardar los cambios?","Alerta",MessageBoxButtons.YesNo);
            if (Confirmacion==DialogResult.Yes) {
                try
                {
                    //Guardar cambios de las tablas
                    //Actualizar los registros de acuerdo a los cambios
                    xml.guardarAtributos(dgAtributos, Ruta, Tabla);//agrega el atributos al archivo xml
                    xml.guardarRegistros(dgRegistros, Ruta, Tabla, Campos);
                    CargarAtributos();
                    CargarRegisros();
                    xml.guardarRegistros(dgRegistros, Ruta, Tabla, Campos);
                }
                catch { }

                // xml.guardarRegistros(dgRegistros,Ruta,Tabla);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmacion
            //Borar Tabla
            //Debe haber tabla seleccionada
            DialogResult Confiramcion=MetroMessageBox.Show(this, "Mensaje de Confirmacion", "Alerta", MessageBoxButtons.OKCancel);
            if (Confiramcion==DialogResult.OK) {
                File.Delete(rutaXML + cbxTablas.Text);
                actualizaCmbTablas();
            }
            //Actualizar datagrid
            //Quitar tabla de la lista-actualizar cbx
        }

        private void dgCampos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    //Borar Campo
                    string campoaeliminar = Campos[dgAtributos.SelectedCells[0].RowIndex];
                    //Eliminar  atributo y valor donde campoaeliminar=atributo
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNueva Nueva = new frmNueva();
            //Abrir ventana frmNueva
            if (Nueva.ShowDialog() == DialogResult.OK)
            {
                string NTabla = Nueva.txtNombre.Text;
                string Ruta = rutaXML + NTabla+".xml";
                if (File.Exists(Ruta))
                {
                    MessageBox.Show("El nombre de la tabla ya existe");
                }
                else
                {                   
                    xml.crearTabla(Ruta, NTabla);//creacion del archivo xml
                    
                    actualizaCmbTablas(); //Agregar taabla a la BD
                    MetroMessageBox.Show(this,"Tabla creada correctamente");
                }

            }
           
        }

        public void actualizaCmbTablas()
        {
            //nota: falta hacer que desapasrescar la terminacion .xml
            cbxTablas.Items.Clear();
            dgAtributos.Rows.Clear();
            DirectoryInfo di = new DirectoryInfo(rutaXML);
            foreach (var fi in di.GetFiles())
            {
                cbxTablas.Items.Add(fi.Name);
            }
        }

        private void cbxTablas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                
                Tabla = cbxTablas.Text;
                var name = Tabla.Split('.');
                Tabla = name[0];
                Ruta = rutaXML + Tabla + ".xml";
                CargarAtributos();
                CargarRegisros();
            }
            catch { }

        }

        private void ActualizarcmbCampos()
        {
            cbxCampo.Items.Clear();
            cbxCampoM.Items.Clear();
            foreach (string campo in Campos) {
                cbxCampo.Items.Add(campo);
                cbxCampoM.Items.Add(campo);
            }
        }

        private void CargarAtributos() {
            doc.Load(rutaXML + cbxTablas.Text);
            dgAtributos.Rows.Clear();
            Campos.Clear();
            XmlNode Atributos = doc.SelectSingleNode("/" + Tabla + "/Atributos");
            XmlNodeList LAtributos = Atributos.SelectNodes("Atributo");

            foreach (XmlNode node in LAtributos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgAtributos);
                Campos.Add(node.InnerText);
                row.Cells[0].Value = node.InnerText;
                row.Cells[1].Value = node.Attributes.GetNamedItem("tipo").Value.ToString();
                row.Cells[2].Value = node.Attributes.GetNamedItem("longitud").Value.ToString();

                dgAtributos.Rows.Add(row);

            }

            ActualizarcmbCampos();
        }

        private void CargarRegisros()
        {
            dgRegistros.Columns.Clear();
            foreach (String campo in Campos)
            {
                dgRegistros.Columns.Add(campo, campo);
            }
            LeerRegistros();
        }

        private void LeerRegistros() {
            dgRegistros.Rows.Clear();
            XmlNode Atributos = doc.SelectSingleNode("/"+Tabla+"/Registros");
            XmlNodeList LRegistros = Atributos.SelectNodes("Registro");

            foreach (XmlNode node in LRegistros)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgRegistros);
                int x = 0;
                foreach (String campo in Campos)
                {
                    row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                    x++;
                }
                dgRegistros.Rows.Add(row);
            }
        }

        private void Eliminacion() {
            dgRegistros.Columns.Clear();
            foreach (String campo in Campos)
            {
                dgRegistros.Columns.Add(campo, campo);
            }
            dgRegistros.Rows.Clear();

            XmlNode Atributos = doc.SelectSingleNode("/" + Tabla + "/Registros");
            XmlNodeList LRegistros = Atributos.SelectNodes("Registro");

            foreach (XmlNode node in LRegistros)
            {
               switch (cbxCondicion.Text)
                {
                    case "==":
                        if (node.Attributes.GetNamedItem(cbxCampo.Text).Value!=txtCriterio.Text) {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case "!=":
                        if (node.Attributes.GetNamedItem(cbxCampo.Text).Value == txtCriterio.Text)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case ">=":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) < int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case "<=":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) > int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case "<":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) >= int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case ">":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) <= int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                }
            }
            xml.guardarRegistros(dgRegistros, Ruta, Tabla, Campos);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                Busqueda();
            }
            catch { }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"Cuando se precione el botón guardar, se guardara en la tabla los registros que se muestran en la parte inferior.");
            MetroMessageBox.Show(this,"Si se realizo una consulta, es necesario volver a seleccionar la tabla, para que se reinicien los registros.");
            MetroMessageBox.Show(this,"Puedes borrar o crear una tabla, con los botones Crear y Borrar.");
            MetroMessageBox.Show(this,"Para una consulta, no es necesario llenar los 2 campos de texto, el campo inferior se utiliza solo para modificaciones");
            MetroMessageBox.Show(this, "Si se desea realizar una modificacion, es necesario llenar todos los campos, el utlimo campo es para establecer el valor que se desea reemplazar por los anteriores");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Confiramcion = MetroMessageBox.Show(this, "Mensaje de Confirmacion", "Alerta", MessageBoxButtons.OKCancel);
            if (Confiramcion == DialogResult.OK)
            {
                try
                {
                    Eliminacion();
                    xml.guardarRegistros(dgRegistros, Ruta, Tabla, Campos);
                }
                catch { }
            }
        }

        private void Busqueda()
        {
            dgRegistros.Columns.Clear();
            foreach (String campo in Campos)
            {
                dgRegistros.Columns.Add(campo, campo);
            }
            dgRegistros.Rows.Clear();

            XmlNode Atributos = doc.SelectSingleNode("/" + Tabla + "/Registros");
            XmlNodeList LRegistros = Atributos.SelectNodes("Registro");

            foreach (XmlNode node in LRegistros)
            {
                switch (cbxCondicion.Text)
                {
                    case "==":
                        if (node.Attributes.GetNamedItem(cbxCampo.Text).Value == txtCriterio.Text)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case "!=":
                        if (node.Attributes.GetNamedItem(cbxCampo.Text).Value != txtCriterio.Text)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case ">=":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) >= int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case "<=":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) <= int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case "<":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) < int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                    case ">":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) > int.Parse(txtCriterio.Text))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgRegistros);
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                row.Cells[x].Value = node.Attributes.GetNamedItem(campo).Value.ToString();
                                x++;
                            }
                            dgRegistros.Rows.Add(row);
                        }
                        break;
                }
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            DialogResult Confiramcion = MetroMessageBox.Show(this, "Mensaje de Confirmacion", "Alerta", MessageBoxButtons.OKCancel);
            if (Confiramcion == DialogResult.OK)
            {
                try
                {
                    Modificacion();
                    xml.guardarRegistros(dgRegistros, Ruta, Tabla, Campos);
                }
                catch { }
            }
          
        }

        private void Modificacion() {
            XmlNode Atributos = doc.SelectSingleNode("/" + Tabla + "/Registros");
            XmlNodeList LRegistros = Atributos.SelectNodes("Registro");
            int y = 0;
            foreach (XmlNode node in LRegistros)
            {
                
                switch (cbxCondicion.Text)
                {
                    case "==":
                        if (node.Attributes.GetNamedItem(cbxCampo.Text).Value == txtCriterio.Text)
                        {
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                if (cbxCampoM.Text==campo) {
                                    dgRegistros.Rows[y].Cells[x].Value = txtReemplazo.Text;
                                }
                                x++;
                            }
                        }
                        break;
                    case "!=":
                        if (node.Attributes.GetNamedItem(cbxCampo.Text).Value != txtCriterio.Text)
                        {
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                if (cbxCampoM.Text == campo)
                                {
                                    dgRegistros.Rows[y].Cells[x].Value = txtReemplazo.Text;
                                }
                                x++;
                            }
                        }
                        break;
                    case ">=":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) >= int.Parse(txtCriterio.Text))
                        {
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                if (cbxCampoM.Text == campo)
                                {
                                    dgRegistros.Rows[y].Cells[x].Value = txtReemplazo.Text;
                                }
                                x++;
                            }
                        }
                        break;
                    case "<=":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) <= int.Parse(txtCriterio.Text))
                        {
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                if (cbxCampoM.Text == campo)
                                {
                                    dgRegistros.Rows[y].Cells[x].Value = txtReemplazo.Text;
                                }
                                x++;
                            }
                        }
                        break;
                    case "<":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) < int.Parse(txtCriterio.Text))
                        {
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                if (cbxCampoM.Text == campo)
                                {
                                    dgRegistros.Rows[y].Cells[x].Value = txtReemplazo.Text;
                                }
                                x++;
                            }
                        }
                        break;
                    case ">":
                        if (int.Parse(node.Attributes.GetNamedItem(cbxCampo.Text).Value) > int.Parse(txtCriterio.Text))
                        {
                            int x = 0;
                            foreach (String campo in Campos)
                            {
                                if (cbxCampoM.Text == campo)
                                {
                                    dgRegistros.Rows[y].Cells[x].Value = txtReemplazo.Text;
                                }
                                x++;
                            }
                        }
                        break;
                }
                y++;
            }
        }
    }
}
