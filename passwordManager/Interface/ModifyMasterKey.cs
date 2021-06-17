using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using passwordManager;
using passwordManager.Exceptions;
using Repository;

namespace Interface
{
    public partial class ModifyMasterKey : UserControl
    {
        private User user;
        private IDataAccess<User> dataAccessUser = DataAccessManager.GetDataAccessUser();

        public ModifyMasterKey(User u)
        {
            InitializeComponent();
            this.user = u;
            lblFeedBackModification.Text = "";
        }

        private void btnModifyMasterkey_Click(object sender, EventArgs e)
        {
            string actualPassword = txtActualPassword.Text;
            string newPassword = txtNewPassword.Text;

            try
            {
                user.ChangeMasterKey(actualPassword,newPassword);
                dataAccessUser.Modify(user);
                lblFeedBackModification.ForeColor = System.Drawing.Color.Green;
                lblFeedBackModification.Text = "La clave maestra ha sido modificada correctamente";

            }catch(InvalidMasterKeyException exc)
            {
                lblFeedBackModification.ForeColor = System.Drawing.Color.Red;
                lblFeedBackModification.Text = exc.Message;
                
  
            }
            
        }

        
    }
}
