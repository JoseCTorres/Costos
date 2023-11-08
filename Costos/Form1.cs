using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Costos
{
    public partial class Form1 : Form
    {
        DataGridViewRow row;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            try
            {
                row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                double mul = (int.Parse(Proceso.Text)) * (double.Parse(Avance.Text));
                double mul2 = (int.Parse(Proceso2.Text)) * (double.Parse(Avance2.Text));
                double sum = (int.Parse(ProduccTerminada.Text)) + mul;
                double resta = sum-mul2;
                row.Cells[0].Value = concepto.Text;
                row.Cells[1].Value = int.Parse(ProduccTerminada.Text);
                row.Cells[2].Value = int.Parse(Proceso.Text);
                row.Cells[3].Value = double.Parse(Avance.Text);               
                row.Cells[4].Value = mul;
                row.Cells[5].Value = int.Parse(Proceso2.Text);
                row.Cells[6].Value = double.Parse(Avance2.Text);
                row.Cells[7].Value = mul2;
                row.Cells[8].Value = resta;


                dataGridView1.Rows.Add(row);
                concepto.Text = " ";
                ProduccTerminada.Text = " ";
                Proceso.Text = " ";
                Avance.Text = " ";
                //.Text = " ";
                Proceso2.Text = " ";
                Avance2.Text = " ";
                //.Text = " ";
                //.Text = " ";

            }
            catch
            {
                MessageBox.Show("IT SEEMS SOMETHING WENT WRONG..., PLEASE REVIEW AND FILL IN EACH FIELD CORRECTLY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dataGridView1.Rows.Add("Materiales");
            //dataGridView1.Rows.Add("Mano de Obra");
            //dataGridView1.Rows.Add("G. Fabricacion");

            //dataGridView1.Rows.Add(dataGridView1.Rows[0]);
        }
    }
}