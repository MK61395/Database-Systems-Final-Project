using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class PlaceOrder : Form
    {

        string orderID;
        public PlaceOrder(string order_id)
        {
            InitializeComponent();
            orderID = order_id;
        }

        private void button5_Click(object sender, EventArgs e)
        {

		}
    }
}
