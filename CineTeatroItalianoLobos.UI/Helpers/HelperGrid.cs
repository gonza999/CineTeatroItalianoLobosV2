﻿using CineTeatroItalianoLobos.Entities;
using System.Windows.Forms;

namespace CineTeatroItalianoLobos.UI.Helpers
{
    public class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow CrearFila(DataGridView dataGridView)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;
        }

        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case TipoEvento _:
                    r.Cells[0].Value = ((TipoEvento)obj).Descripcion;
                    break;
                case Clasificacion _:
                    r.Cells[0].Value = ((Clasificacion)obj).Descripcion;
                    break;
                case Ubicacion _:
                    r.Cells[0].Value = ((Ubicacion)obj).Descripcion;
                    break;
                case FormaVenta _:
                    r.Cells[0].Value = ((FormaVenta)obj).Descripcion;
                    break;
                case FormaPago _:
                    r.Cells[0].Value = ((FormaPago)obj).Descripcion;
                    break;
                case Planta _:
                    r.Cells[0].Value = ((Planta)obj).Descripcion;
                    break;
                case TipoDocumento _:
                    r.Cells[0].Value = ((TipoDocumento)obj).Descripcion;
                    break;
                case Empleado _:
                    r.Cells[0].Value = ((Empleado)obj).Apellido;
                    r.Cells[1].Value = ((Empleado)obj).Nombre;
                    r.Cells[2].Value = ((Empleado)obj).Mail;
                    r.Cells[3].Value = ((Empleado)obj).TipoDocumento.Descripcion;
                    r.Cells[4].Value = ((Empleado)obj).NroDocumento;
                    //r.Cells[5].Value = ((Empleado)obj).TelefonoFijo;
                    //r.Cells[6].Value = ((Empleado)obj).TelefonoMovil;
                    break;
                case Localidad _:
                    r.Cells[0].Value = ((Localidad)obj).Planta.Descripcion;
                    r.Cells[1].Value = ((Localidad)obj).Numero;
                    r.Cells[2].Value = ((Localidad)obj).Ubicacion.Descripcion;
                    r.Cells[3].Value = ((Localidad)obj).Fila;
                    break;
                default:
                    break;
            }
            r.Tag = obj;
        }

    }
}
