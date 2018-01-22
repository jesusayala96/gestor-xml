using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;



using System.Windows.Forms;

namespace GestorBD
{
    public class C_XML
    {
        XmlDocument doc = new XmlDocument();

        public void crearTabla(string rutaXml, string raiz)
        {

            //sirve para especificar las versiones del archivo XML
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

   
            XmlNode nodoRoot = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, nodoRoot);


            XmlNode element1 = doc.CreateElement(raiz);
            doc.AppendChild(element1);
            doc.Save(rutaXml);
        }
        
        private XmlNode CrearNodoAtributos(DataGridView datos)
        {

            XmlNode root = doc.CreateElement("Atributos");

            for (int a = 0; a < datos.Rows.Count-1; a++)
            {
                XmlElement Atributos = doc.CreateElement("Atributo");

                dynamic dato = datos.Rows[a].Cells[0].Value;
                dynamic TDato = datos.Rows[a].Cells[1].Value;
                dynamic Longitud = datos.Rows[a].Cells[2].Value;

                Atributos.SetAttribute("tipo", TDato);
                Atributos.SetAttribute("longitud", Longitud);
                Atributos.InnerText = dato;  //asigna un valor al campo
                root.AppendChild(Atributos);
            }
                        
            return root;
        }

        public void guardarAtributos(DataGridView datos, string rutaXml, string tabla)
        {
            doc.Load(rutaXml);

            XmlNode nod = CrearNodoAtributos(datos);
            XmlNode nodoRaiz = doc.DocumentElement;
            try
            {
                BorrarAtributos(doc, tabla, rutaXml);
            }
            catch { }
            nodoRaiz.InsertBefore(nod, nodoRaiz.FirstChild);
            doc.Save(rutaXml);
        }

        private void BorrarAtributos(XmlDocument xml, string Tabla, string ruta) {
            XmlElement el = (XmlElement)xml.SelectSingleNode("/"+Tabla+"/Atributos");
            el.ParentNode.RemoveChild(el);
            xml.Save(ruta);
        }

        public XmlNode CrearNodoRegistros(DataGridView datos,List<string>Campos)
        {
            XmlNode root = doc.CreateElement("Registros");

            for (int a = 0; a < datos.Rows.Count-1; a++)
            {
                XmlElement Registros = doc.CreateElement("Registro");

                for (int b = 0; b < Campos.Count; b++)
                {
                    dynamic reg = datos.Rows[a].Cells[b].Value;
                    Registros.SetAttribute(Campos[b],reg);
                }      
                    root.AppendChild(Registros);
            }

            return root;
        }

        public void guardarRegistros(DataGridView datos, string rutaXml, string tabla, List<string> Campos)
        {
            doc.Load(rutaXml);

            XmlNode nod = CrearNodoRegistros(datos,Campos);
            XmlNode nodoRaiz = doc.DocumentElement;
            try
            {
                BorrarRegistros(doc, tabla, rutaXml);
            }
            catch { }
            nodoRaiz.InsertAfter(nod, nodoRaiz.FirstChild);
            doc.Save(rutaXml);
        }

        private void BorrarRegistros(XmlDocument xml, string Tabla, string ruta)
        {
            XmlElement el = (XmlElement)xml.SelectSingleNode("/" + Tabla + "/Registros");
            el.ParentNode.RemoveChild(el);
            xml.Save(ruta);
        }

    }

}
