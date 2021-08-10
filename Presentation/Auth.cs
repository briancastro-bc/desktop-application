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

namespace Presentation
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Message(string category, string message)
        {
            MessageTxt.Visible = true;
            MessageTxt.Text = $"{category}: {message}";
        }

        private void Verify()
        {
            if (UsernameTxt.Text.Length <= 0 || PasswordTxt.Text.Length <= 0) 
                Message("Error", "Por favor llene todos los campos para continuar.");
            else
            {
                user.Username = UsernameTxt.Text;
                user.Password = PasswordTxt.Text;
                foreach (User item in User.Storage)
                {
                    if (user.Username.Contains(item.Username) && user.Password.Contains(item.Password))
                    {
                        Message("Error", "Las credenciales de accesos son correctas.");
                    }
                    else
                    {
                        Message("Error", "El usuario o la contraseña son incorrectos.");
                    }
                }
            }
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            Verify();
        }

        private readonly User user = new();
    }
}
