using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PersonContext db = new PersonContext())
            {
                try
                {
                    if(textBox1.Text.ToString() == "")
                    {
                        throw new Exception("Ошибка заполнения");
                    }
                    if (textBox2.Text.ToString() == "")
                    {
                        throw new Exception("Ошибка заполнения");
                    }
                    db.People.Add(new Person { Name = textBox1.Text.ToString(), Form = textBox2.Text.ToString() });
                    db.SaveChanges();
                    MessageBox.Show("Добавлен!");
                } catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
