using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace Presentation.Views
{
    public partial class CreateCarnet : Form
    {
        public CreateCarnet()
        {
            InitializeComponent();
        }

        public void Create()
        {
            Global.CarnetsStorage.Add(new()
            {
                Name = NameTxt.Text, 
                LastName = LastnameTxt.Text, 
                Phone = PhoneTxt.Text, 
                Gender = GenderTxt.Text, 
                Role = RoleTxt.Text, 
                IdType = IdTypeTxt.Text, 
                Id = IdNumberTxt.Text, 
                Rh = RhTxt.Text
            });
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
