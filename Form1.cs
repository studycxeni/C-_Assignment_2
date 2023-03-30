using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int age;
            string name, lastName, departmentName, position, hospitalName, experience;
            name = textBox1.Text.ToString();
            lastName = textBox2.Text.ToString();
            age = int.Parse(textBox3.Text);
            departmentName = textBox4.Text.ToString();
            position = textBox5.Text.ToString();
            hospitalName = textBox6.Text.ToString();
            experience = textBox7.Text.ToString();

            Doctor obj_doctor = new Doctor(name, lastName, age, departmentName, position, hospitalName, experience);
            obj_doctor.Print(label1);
        }
    }
}
