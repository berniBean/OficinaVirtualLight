using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Helper.DataGridHelper
{
    public static class GridDataHelper
    {

        private static int pegado(string[] lineas, DataGridView dataGridView1, MonthCalendar calendarioVacacional, int fila, int columna, int error)
        {
            int indice = 0;
            int carga = 1;

            //T elementoModificado;





            try
            {
                DataGridViewCell objeto_celda;
                foreach (string linea in lineas)
                {


                    if (fila < dataGridView1.RowCount && linea.Length > 0)
                    {
                        string[] celdas = linea.Split('\t');

                        for (indice = 0; indice < celdas.GetLength(0); ++indice)
                        {


                            if (columna + indice < dataGridView1.ColumnCount)
                            {
                                objeto_celda = dataGridView1[columna + indice, fila];

                                //Mientras celda sea Diferente de ReadOnly
                                if (!objeto_celda.ReadOnly)
                                {
                                    if (objeto_celda.Value.ToString() != celdas[indice])
                                    {
                                        if (celdas[indice] != "\r" && celdas[indice] != "" && celdas[indice] != " " && celdas[indice] != "01/01/0001 12:00:00 a. m.")
                                        {

                                            objeto_celda.Value = Convert.ChangeType(celdas[indice], objeto_celda.ValueType);
                                            objeto_celda.Value = objeto_celda.Value.ToString().Trim(new Char[] { '\t', '\n', '\r' });
                                            //fechaValidada(objeto_celda, calendarioVacacional, dataGridView1);

                                            //elementoModificado = listado[objeto_celda.RowIndex];
                                            //elementoModificado = oficios[objeto_celda.RowIndex];
                                            //if (!registrosModificados.Contains(elementoModificado))
                                            //{
                                            //    registrosModificados.Add(elementoModificado);
                                            //}

                                            //A continuación la linea añadida para eliminar los '\r'. De paso, y por si acaso en algún contexto ocurre, tambien los: '\t' y '\n'

                                            // Fin linea añadida

                                        }


                                    }

                                }

                                else
                                {
                                    // solo intercepta un error si los datos que está pegando es en una celda de solo lectura.
                                    error++;
                                }
                            }
                            else
                            { break; }
                        }
                        fila++;


                        carga++;
                    }
                    else
                    { break; }

                    if (error > 0)
                        MessageBox.Show(string.Format("{0}  La celda no puede ser actualizada, debido a que la configuración de la columna es de solo lectura.", error),
                                                  "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Finalizado");
                return columna;



            }
            catch (FormatException fexcepcion)
            {
                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }



        public static bool ColumnasArray(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
        {
            int indice = 0;
            bool resultado = true;
            DataGridViewCell objeto_celda;
            foreach (string linea in lineas)
            {

                if (fila < datagrid.RowCount && linea.Length > 0)
                {
                    string[] celdas = linea.Split('\t');

                    for (indice = 0; indice < celdas.GetLength(0); ++indice)
                    {
                        if (columna + indice < datagrid.ColumnCount)
                        {
                            objeto_celda = datagrid[columna + indice, fila];

                            //Mientras celda sea Diferente de ReadOnly
                            if (!objeto_celda.ReadOnly)
                            {
                                if (objeto_celda.Value.ToString() != celdas[indice])
                                {

                                    if (celdas[indice] != "\r" && celdas[indice] != "" && celdas[indice] != "01/01/0001 12:00:00 a. m.")
                                    {
                                        if (indice > 1)
                                        {
                                            resultado = false;
                                            break;

                                        }
                                    }


                                }
                            }
                            else
                            {
                                // solo intercepta un error si los datos que está pegando es en una celda de solo lectura.
                                error++;
                            }
                        }
                        else
                        { break; }
                    }
                    fila++;
                }
                else
                { break; }

                if (error > 0)

                    MessageBox.Show(string.Format("{0}  La celda no puede ser actualizada, debido a que la configuración de la columna es de solo lectura.", error),
                                              "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return resultado;

        }
    }
}
