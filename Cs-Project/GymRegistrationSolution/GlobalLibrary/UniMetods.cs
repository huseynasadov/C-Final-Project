using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace GlobalLibrary
{
  public  class UniMetods
    {

        public string FirstCharToUpper(string s)
        {
            s = s.ToLower();
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser()
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "User",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        // When Closing Dashboard doing Event
        public void dash_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "GYM",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }
    }
}
