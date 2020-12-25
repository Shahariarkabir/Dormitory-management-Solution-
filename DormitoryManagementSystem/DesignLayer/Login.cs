﻿using Student_Log_In.BusinessLayer;
using Student_Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Log_In
{
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }

        private void studentlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || userPasswordTextBox.Text == "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(userNameTextBox.Text, userPasswordTextBox.Text);
                if (result)
                {
                    CreateStudentProfile studentProfile = new CreateStudentProfile();
                    studentProfile.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");
                }
            }
        }

        private void signupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateStudentProfile studentProfile = new CreateStudentProfile();
            studentProfile.Show();
            this.Hide();
        }
    }
}
