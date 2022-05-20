using Services.Interfaces;
using Sistematico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        IStudentService studentServices;
        private int Selection = -1;
        public Form1(IStudentService studentServices)
        {
            this.studentServices = studentServices;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante
            {
                Nombres = textBox1.Text,
                Apellidos = textBox2.Text,
                Carnet = textBox3.Text,
                Phone = textBox4.Text,
                Direccion = textBox5.Text,
                Correo = textBox6.Text,
                Matematica = Convert.ToInt32(textBox7.Text),
                Contabilidad = Convert.ToInt32(textBox8.Text),
                Programacion = Convert.ToInt32(textBox9.Text),
                Estadistica = Convert.ToInt32(textBox10.Text),
            };
            studentServices.Create(est);
                
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Selection = e.RowIndex;
                button2.Visible = true;
            }
            button2.Visible = false; 
            Selection = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentServices.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Selection > -1)
            {
                int id = (int)dataGridView1.Rows[Selection].Cells[0].Value;
                Estudiante estudiante = studentServices.findbyid(id);
                MessageBox.Show(studentServices.claculateaverage(estudiante).ToString());
            }
            
        }
    }
}
