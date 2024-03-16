using Entities;
using Entities.TransientClasses;
using Services;
using System;
using System.Windows.Forms;

namespace SystemSchool.Forms.PasswordForms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly EditEntitiesService<User> _editEntities;
        string Password => textBoxNewPassword.Text;
        string PasswordConfirmation => textBoxConfirmationPassword.Text;
        User User => Login.CurrentUser; 

        public ChangePasswordForm(EditEntitiesService<User> editEntities) 
        {
            _editEntities = editEntities;
            InitializeComponent();
        }
        
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = User.Username;
        }
        
        private async void buttonChange_Click(object sender, EventArgs e)
        {
            if (Password.Equals(PasswordConfirmation)) 
            {
                try
                {
                    User.PasswordHash = Password;
                    EntityQuery<User> entityQuery = await _editEntities.EditPasswordAsync(User);
                    MessageBox.Show(entityQuery.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("The fields must be the same", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
