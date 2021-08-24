using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Models;

namespace Presentation.Views
{
    public partial class Formulary : Form
    {
        public Formulary()
        {
            InitializeComponent();
            StablishCredentials();
        }

        private void StablishCredentials()
        {
            UsernameTxt.Text = $"Usuario: {Global.Data.Username}";
            PasswordTxt.Text = $"Contraseña: {Global.Data.Password}";
        }

        private void Logout()
        {
            Auth auth = new();
            auth.Show();
            Hide();
        }

        private void OpenForms(object child)
        {
            if (FormularyContainer.Controls.Count > 0)
                FormularyContainer.Controls.RemoveAt(0);
            Form? childForm = child as Form;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            FormularyContainer.Controls.Add(childForm);
            FormularyContainer.Tag = childForm;
            childForm.Show();
        }

        /*public void OpenSeeCarnets(object chil)
        {
            if(Formu)
        }*/

        private void CreateCarnetBtn_Click(object sender, EventArgs e)
        {
            OpenForms(new CreateCarnet());
        }

        private void SeeCarnetBtn_Click(object sender, EventArgs e)
        {
            OpenForms(new Carnets());
        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
