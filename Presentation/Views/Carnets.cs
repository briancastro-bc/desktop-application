using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class Carnets : Form
    {
        public Carnets()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            CarnetsDataTable.DataSource = null;
            CarnetsDataTable.DataSource = Global.CarnetsStorage;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Carnets_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
