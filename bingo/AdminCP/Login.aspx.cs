﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using bingo.BL;
using bingo.DO;

namespace bingo.AdminCP
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            if (Request.QueryString["Option"] != null)
                if (Request.QueryString["Option"].ToString() == "Logout")
                    Session.RemoveAll();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string txtPass = Functions.EncryptMd5(txtPassword.Text);
            sysUserDO obj = new sysUserBL().SelectLogin(txtUsername.Text, txtPass);
            if (obj.UserID > 0)
            {
                Session["Username"] = obj.Username;
                Session["UserID"] = obj.UserID;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Functions.Alert("Sai tên đăng nhập", Request.Url.ToString());
            }


        }
    }
}
