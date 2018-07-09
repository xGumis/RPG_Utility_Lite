using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Lite.Views
{
    public partial class Login : UserControl
    {
        public event Action<string, string> RequestLogin;
        public Login(Size size, ref Size minimumSize)
        {
            InitializeComponent();
            this.Size = size;
            minimumSize = this.MinimumSize;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = textBoxUsername.Text;
            var pass = textBoxPassword.Text;
            errorProviderLogin.Clear();
            if (user.Length == 0 && pass.Length == 0)
                RequestLogin(null, null);
            else if (user.Length == 0 || pass.Length == 0)
            {
                if (user.Length == 0)
                {
                    errorProviderLogin.SetError(textBoxUsername, "Wpisz nazwę użytkownika");
                }
                else errorProviderLogin.SetError(textBoxPassword, "Wpisz hasło");
            }
            else RequestLogin(user, pass);

            
        }
    }
}
