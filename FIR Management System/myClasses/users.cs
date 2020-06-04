using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIR_Management_System.myClasses;
using System.Windows.Forms;

namespace FIR_Management_System
{
    public class users
    {
        private String userName;
        private String password;

        public users(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }

        public String getUserName()
        {
            return userName;
        }

        //public String successful()
        //{
        //    if(loginCheck() == true)
        //    return ("Login Successful! " + getUserName());
        //}

        public bool loginCheck(String name, String pass, int role)
        {
            String query = "select Count(uname) from users Where uname = '" + name + "' AND upass = '" + pass + "' AND urole = '" + role + "' AND status = 1";
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            int count = (int) sc.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void successful(bool status, int role)
        {
            if(status == true)
            {
                MessageBox.Show("Login Successful!");
                dashboard ds = new dashboard();
                loginPanel lp = new loginPanel();
                lp.Hide();
                ds.setRole(role);
                ds.ShowDialog();
                lp.Close();
            }

            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }

    public class constable : users
    {
        int role;

        public constable(String userName, String password, int role) : base(userName, password)
        {
            this.role = role;
            bool status = base.loginCheck(userName, password, role);
            base.successful(status, role);
        }
    }

    public class dsp : users
    {
        int role;

        public dsp(String userName, String password, int role) : base(userName, password)
        {
            this.role = role;
            bool status = base.loginCheck(userName, password, role);
            base.successful(status, role);
        }
    }

    public class comissioner : users
    {
        int role;

        public comissioner(String userName, String password, int role) : base(userName, password)
        {
            this.role = role;
            bool status = base.loginCheck(userName, password, role);
            base.successful(status, role);
        }
    }
}
