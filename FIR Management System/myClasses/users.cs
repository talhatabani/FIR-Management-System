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

        //login for Police Staff by Using the concept of polymorphism//
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

        //login for Citizen by USing the concept of polymorphism//

        public bool loginCheck(String email, String pass)
        {
            String query = "SELECT COUNT(email) FROM citizens WHERE email = '" + email +  "' AND password = '" + pass + "' AND status = 1";
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            int count = (int)sc.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool signupEnabled(String name, String pass, int role)
        {
            String query = "select Count(uname) from users Where uname = '" + name + "' AND upass = '" + pass + "' AND urole = '" + role + "' AND status = 1";
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            int count = (int)sc.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public void signupSuccessful(bool status, int role)
        {
            loginPanelPolice lpp = new loginPanelPolice();
            if (status == true)
            {
                //dashboard ds = new dashboard();
                lpp.signupBtn.Enabled = true;
                MessageBox.Show("DOne");
                //lp.Hide();
                //ds.setRole(role);
                //ds.ShowDialog();
                //lp.Close();
            }

            else
            {
                MessageBox.Show("false");
                lpp.signupBtn.Enabled = false;
            }
        }

        public void successful(bool status, int role)
        {
            if(status == true)
            {
                MessageBox.Show("Login Successful!");
                dashboard ds = new dashboard();
                loginPanelPolice lp = new loginPanelPolice();
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

        public void successful(bool status)
        {
            if (status == true)
            {
                MessageBox.Show("Login Successful!");
                //dashboard ds = new dashboard();
                //loginPanelCitizen lpc = new loginPanelCitizen();
                //lpc.Hide();
                //ds.ShowDialog();
                //lpc.Close();
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

        //permisssion  granted to the comissioner for adding more officers.//
        public comissioner(String userName,int role, String password) : base(userName, password)
        {
            this.role = role;
            bool status = base.signupEnabled(userName, password, role);
            base.signupSuccessful(status, role);

        }
    }

    public class citizen : users
    {
        public citizen(String email, String pass) : base(email, pass)
        {
            bool status = base.loginCheck(email, pass);
            base.successful(status);
        }
    }
}
