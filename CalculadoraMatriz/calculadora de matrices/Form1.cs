using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_matrices
{
    public partial class CalculadoraMatrices : Form
    {
        public CalculadoraMatrices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// carga las matrices en lod DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int y = System.Convert.ToInt16(txtColumnas.Text);
                int x = System.Convert.ToInt16(txtFilas.Text);
                dgvM1.ColumnCount = y;
                dgvM2.ColumnCount = y;
                dgvM1.RowCount = x;
                dgvM2.RowCount = x;
                dgvMRes.ColumnCount = y;
                dgvMRes.RowCount = x;
                dgvM1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvM2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: REVISE QUE LOS DATOS INGRESADOS SEAN NUMEROS ENTEROS");
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            SumasMatrices(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SumasMatrices(false);
        }
        /// <summary>
        /// METODO de suma y resta de matrices A:B
        /// </summary>
        /// <param name="esSuma"></param>
        private void SumasMatrices (bool esSuma)
        {
            int i, j;
            int fila, columna;

            fila = System.Convert.ToInt32(txtFilas.Text);
            columna = System.Convert.ToInt32(txtColumnas.Text);

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    if(esSuma)
                    dgvMRes.Rows[i].Cells[j].Value = Convert.ToDouble(dgvM1.Rows[i].Cells[j].Value) + Convert.ToDouble(dgvM2.Rows[i].Cells[j].Value);
                    else dgvMRes.Rows[i].Cells[j].Value = Convert.ToDouble(dgvM1.Rows[i].Cells[j].Value) - Convert.ToDouble(dgvM2.Rows[i].Cells[j].Value);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            multiplicarEscalar(true);
        }
        /// <summary>
        /// METODO: multiplica la matris a con el txt escalar
        /// </summary>
        /// <param name="multi"></param>
        private void multiplicarEscalar(bool multi)
        {

            try
            {
                int i, j;
                int fila, columna;
                int p = System.Convert.ToInt32(escalar.Text);

                fila = System.Convert.ToInt32(txtFilas.Text);
                columna = System.Convert.ToInt32(txtColumnas.Text);

                for (i = 0; i < fila; i++)
                {
                    for (j = 0; j < columna; j++)
                    {
                        dgvMRes.Rows[i].Cells[j].Value = Convert.ToDouble(dgvM1.Rows[i].Cells[j].Value) * p;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: DEBE INGRESAR UN NUMERO ENTERO");
            }
        }
        /// <summary>
        /// salta a la otra pestaña para poder multiplicar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoDeDosMatrices productoDeDosMatrices = new ProductoDeDosMatrices();
            productoDeDosMatrices.ShowDialog();
            if (productoDeDosMatrices.DialogResult== DialogResult.Yes)
            {

            }
        }
        //Limpia los DGV
        private void borrar_Click(object sender, EventArgs e)
        {
            dgvM1.Columns.Clear();
            dgvM2.Columns.Clear();
            dgvMRes.Columns.Clear();
        }

        private void INSTRUCCIONES_Click(object sender, EventArgs e)
        {
            INSTRUCCIONES iNSTRUCCIONES = new INSTRUCCIONES();
            iNSTRUCCIONES.ShowDialog();
            if (INSTRUCCIONES.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

