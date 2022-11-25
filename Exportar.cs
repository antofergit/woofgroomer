using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WoofGroomer
{
    public static class Exportar
    {
        //Exporta Datagridview a Archivo de Excel
        public static void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "ArchivoExportado";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    //libros_trabajo = aplicacion.Workbooks.Add();
                    libros_trabajo = aplicacion.Workbooks.Open($@"{Directory.GetCurrentDirectory()}\Resources\PlantillaTrimestre.xls");
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    string fecha = "";
                    for (int i = 0; i < grd.Rows.Count ; i++)
                    {


                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                if (j == 0)
                                {
                                    string fechaNueva = grd.Rows[i].Cells[j].Value.ToString();
                                    if (fechaNueva == fecha)
                                    {
                                        
                                    }
                                    else
                                    {
                                        fecha = fechaNueva;
                                        hoja_trabajo.Cells[i + 3, j + 1] = grd.Rows[i].Cells[j].Value;
                                    }
                                }
                                else
                                {
                                    hoja_trabajo.Cells[i + 3, j + 1] = grd.Rows[i].Cells[j].Value;
                                }
                                
                            }
                        }
                    }



                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    aplicacion.Visible = true;
                    //libros_trabajo.Close(true);
                    //aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}
