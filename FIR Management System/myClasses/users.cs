﻿using System;
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
        private string userName;
        private string password;
        private static int role;

        public users()
        {

        }

        public static void setRole(int thisRole)
        {
            role = thisRole;
        }

        public static int getRole()
        {
            return role;
        }

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
            String query = "SELECT COUNT(password) FROM citizens WHERE ((email = '" + email +  "') OR (cnic = '" + email + "')) AND password = '" + pass + "' AND status = 1";
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

        //permisssion  granted to the comissioner for adding more officers.//
        public bool signupEnabled(String name, String pass)
        {
            String query1 = "select Count(uname) from users Where uname = '" + name + "' AND upass = '" + pass + "' AND urole = '" + 3 + "' AND status = 1";
            SqlCommand sc1 = new SqlCommand(query1, connectionString.getConnection());
            SqlDataAdapter sda1 = new SqlDataAdapter(sc1);
            int count1 = (int)sc1.ExecuteScalar();
            if (count1 > 0)
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
                dashboardPolice ds = new dashboardPolice();
                loginPanelPolice lp = new loginPanelPolice();
                lp.Hide();
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
                dashboard ds = new dashboard();
                loginPanelCitizen lpc = new loginPanelCitizen();
                lpc.Hide();
                ds.ShowDialog();
                lpc.Close();
            }

            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }

    public class constable : users
    {
        public constable(String userName, String password, int role) : base(userName, password)
        {
            users.setRole(role);
            bool status = base.loginCheck(userName, password, users.getRole());
            base.successful(status, role);
        }
    }

    public class dsp : users
    {

        public dsp(String userName, String password, int role) : base(userName, password)
        {
            users.setRole(role);
            bool status = base.loginCheck(userName, password, users.getRole());
            base.successful(status, role);
        }
    }

    public class comissioner : users
    {
        public comissioner(String userName, String password, int role) : base(userName, password)
        {
            users.setRole(role);
            bool status = base.loginCheck(userName, password, users.getRole());
            base.successful(status, role);
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
