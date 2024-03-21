using CleanArchitecture.Concretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.DataGridHelper
{
    public static class GridHelper<T>
    {
        private static List<T> ListadoGrid = new List<T>();
        private static List<T> registrosModificados = new List<T>();
        


        public static void DgGeneric_CellEndEdit(object sender, DataGridViewCellEventArgs e, List<T> listReq, List<T> registrosModificados)
        {
            int rowIndex = e.RowIndex;

            T elementoModificado = listReq[rowIndex];

            if (!registrosModificados.Contains(elementoModificado))
            {
                registrosModificados.Add(elementoModificado);
            }
        }

        public static void CopiarPortapapeles(DataGridView dataGrid)
        {
            DataObject objetoDatos = dataGrid.GetClipboardContent();

            Clipboard.SetDataObject(objetoDatos);
        }

        internal static void pegar_portapapeles(DataGridView dataGridView1, MonthCalendar calendarioVacacional, ListCOficios oficios)
        {
            string texto_copiado = Clipboard.GetText();
            string[] lineas = texto_copiado.Split('\n');
            int error = 0;
            int fila = dataGridView1.CurrentCell.RowIndex;
            int columna = dataGridView1.CurrentCell.ColumnIndex;
            int tColumna;



            if (lineas.Length == 1 && ColumnasArray(lineas, dataGridView1, fila, columna, error))
                tColumna = pegarUno(lineas, dataGridView1, fila, columna, error);
            else
                tColumna = pegado(lineas, dataGridView1, oficios, calendarioVacacional, fila, columna, error);
        }

        private static int pegado(string[] lineas, DataGridView dataGridView1, ListCOficios oficios, MonthCalendar calendarioVacacional, int fila, int columna, int error)
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
                                            fechaValidada(objeto_celda, calendarioVacacional, dataGridView1);

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

        //public static void pegar_portapapeles(DataGridView datagrid, MonthCalendar calendar,  listado)
        //{


        //    string texto_copiado = Clipboard.GetText();
        //    string[] lineas = texto_copiado.Split('\n');
        //    int error = 0;
        //    int fila = datagrid.CurrentCell.RowIndex;
        //    int columna = datagrid.CurrentCell.ColumnIndex;
        //    int tColumna;
            


        //    if (lineas.Length == 1 && ColumnasArray(lineas, datagrid, fila, columna, error))
        //        tColumna = pegarUno(lineas, datagrid, fila, columna, error);
        //    else
        //        tColumna = pegado(lineas, datagrid,  listado, calendar, fila, columna, error);

        //    //validarFila(columna);





        //}



        private static bool ColumnasArray(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
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



        private static Boolean EsFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
        private static bool diaNoLaborar(DateTime fechaCalculada, MonthCalendar calendar)
        {
            bool noLaboral = false;
            foreach (var item in calendar.BoldedDates)
            {
                if (fechaCalculada.DayOfWeek == DayOfWeek.Saturday || fechaCalculada.DayOfWeek == DayOfWeek.Sunday)
                    return true;
                if (fechaCalculada.Equals(item))
                {
                    noLaboral = true;
                    break;
                }


            }
            return noLaboral;

        }

        private static void fechaValidada(DataGridViewCell objeto_celda, MonthCalendar calendar, DataGridView DGRegistros) 
        {
            T elementoModificado;

            if (objeto_celda.ColumnIndex == 6 || objeto_celda.ColumnIndex == 7)
            {
                if (Convert.ToString(objeto_celda.EditedFormattedValue) != "")
                {

                    if (!EsFecha(objeto_celda.Value.ToString()))
                    {
                        elementoModificado = ListadoGrid[objeto_celda.RowIndex];
                        if (registrosModificados.Contains(elementoModificado))
                        {
                            registrosModificados.Remove(elementoModificado);
                        }

                        objeto_celda.ErrorText = "Debe ser una fecha tipo dd/mm/aaaa";
                        objeto_celda.Value = null;
                    }
                    else




                    if (diaNoLaborar(Convert.ToDateTime(objeto_celda.Value), calendar))
                    {
                        elementoModificado = ListadoGrid[objeto_celda.RowIndex];
                        if (registrosModificados.Contains(elementoModificado))
                        {
                            registrosModificados.Remove(elementoModificado);
                        }

                        objeto_celda.ErrorText = "Este es un día inhábil";
                        objeto_celda.Value = null;
                    }
                    else
                    {
                        objeto_celda.Value = objeto_celda.Value;
                        objeto_celda.ErrorText = string.Empty;
                    }
                }
                else if (Convert.ToString(DGRegistros.CurrentCell.EditedFormattedValue) == "")
                {

                }
                if (Convert.ToDateTime(objeto_celda.Value) == Convert.ToDateTime("01/01/0001"))
                    objeto_celda.Value = string.Empty;
            }

        }

        private static int pegarUno(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
        {

            string[] linea = lineas;
            T elementoModificado;

            try
            {

                foreach (DataGridViewCell dg in datagrid.SelectedCells)
                {

                    if (!dg.ReadOnly)
                    {
                        if (linea[0] != "\r" && linea[0] != "" && linea[0] != "01/01/0001 12:00:00 a. m.")
                            dg.Value = Convert.ChangeType(linea[0], dg.ValueType);
                        if (dg.ColumnIndex == 6 || dg.ColumnIndex == 7)
                        {
                            if (Convert.ToString(dg.EditedFormattedValue) != "")
                            {

                                if (EsFecha(dg.Value.ToString()))
                                {
                                    dg.ErrorText = "Debe ser una fecha tipo dd/mm/aaaa";
                                    dg.Value = null;
                                }
                                else




                                if (Convert.ToDateTime(dg.Value).DayOfWeek == DayOfWeek.Saturday || Convert.ToDateTime(dg.Value).DayOfWeek == DayOfWeek.Sunday)
                                {
                                    dg.ErrorText = "No debe ser fin de semana";
                                    dg.Value = null;
                                }
                                else
                                {
                                    dg.Value = dg.Value;
                                    dg.ErrorText = string.Empty;

                                    elementoModificado = ListadoGrid[dg.RowIndex];
                                    if (!registrosModificados.Contains(elementoModificado))
                                    {
                                        registrosModificados.Add(elementoModificado);
                                    }

                                }
                            }
                            else if (Convert.ToString(datagrid.CurrentCell.EditedFormattedValue) == "")
                            {

                            }
                            if (Convert.ToDateTime(dg.Value) == Convert.ToDateTime("01/01/0001"))
                                dg.Value = null;
                        }

                    }
                    else
                    {
                        error++;
                    }

                    elementoModificado = ListadoGrid[dg.RowIndex];
                    if (!registrosModificados.Contains(elementoModificado))
                    {
                        registrosModificados.Add(elementoModificado);
                    }

                }


            }
            catch (FormatException fexcepcion)
            {

                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 1;
            }


            return 1;

        }

        private static  int pegado(string[] lineas, DataGridView datagrid,List<T> listado, MonthCalendar calendar, int fila, int columna, int error)
        {
            int indice = 0;
            int carga = 1;

            T elementoModificado;

            



            try
            {
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
                                        if (celdas[indice] != "\r" && celdas[indice] != "" && celdas[indice] != " " && celdas[indice] != "01/01/0001 12:00:00 a. m.")
                                        {

                                            objeto_celda.Value = Convert.ChangeType(celdas[indice], objeto_celda.ValueType);
                                            objeto_celda.Value = objeto_celda.Value.ToString().Trim(new Char[] { '\t', '\n', '\r' });
                                            fechaValidada(objeto_celda, calendar, datagrid);

                                            //elementoModificado = listado[objeto_celda.RowIndex];
                                            elementoModificado = listado[objeto_celda.RowIndex];
                                            if (!registrosModificados.Contains(elementoModificado))
                                            {
                                                registrosModificados.Add(elementoModificado);
                                            }

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





    }
}
