using HorseScale.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseScale
{
    public partial class MeasurementParameterInputDialogue : Form
    {
        public string SelectedBreed => comboBox1.SelectedItem.ToString();
        public double HorseMassInKg =>  Convert.ToDouble(textBox1.Text);
        public MeasurementParameterInputDialogue()
        {
            InitializeComponent();
            comboBox1.DataSource = new BindingSource(Formula._formulas.Keys, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void MeasurementParameterInputDialogue_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
