using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAssociation
{
    public partial class Form1 : Form
    {
        public List<Address> addressBook;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addressBook = new List<Address>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addressBook.Add(new Address());

            
            myHouse.residents.Add(new Person("Peter"));

            foreach (var house in )
            {
                MessageBox.Show (house.)
            }
            
        }
    }
}
