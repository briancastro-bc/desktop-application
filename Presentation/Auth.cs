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

        private bool Verify(string username, string password)
        {
            if (UsernameTxt.Text.Length <= 0 || PasswordTxt.Text.Length <= 0)
            {
                Message("Error", "Por favor llene todos los campos para continuar.");
                return false;
            }
            else
            {
                user.Username = username;
                user.Password = password;
                foreach (User item in User.Storage)
                {
                    //if (user.Username.Contains(item.Username) && user.Password.Contains(item.Password))
                    if(item.Username.Contains(user.Username) | item.Username == user.Username)
                    {
                        if(item.Password.Contains(PasswordTxt.Text) | item.Password == PasswordTxt.Text)
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        UsernameTxt.Clear();
                        PasswordTxt.Clear();
                        return false;
                    }
                }
                return false;
            }
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            if(Verify(UsernameTxt.Text, PasswordTxt.Text))
            {
                Message("Hecho", "Las credenciales de acceso son correctas");
            } else
            {
                Message("Error", "Las credenciales de acceso son incorrectas");
            }
        }

        private readonly User user = new();
    }
}
