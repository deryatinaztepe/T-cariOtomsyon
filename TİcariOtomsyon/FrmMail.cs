﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TİcariOtomsyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail4_Load(object sender, EventArgs e)
        {
           TxtMailAdresi.Text = mail;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim=new MailMessage();
            SmtpClient istemci=new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("Mail", "Şifre");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(RchMesaj.Text);
            mesajim.From = new MailAddress("Mail");
            mesajim.Subject=TxtKonu.Text;
            mesajim.Body=RchMesaj.Text;
            istemci.Send(mesajim);
        }
    }
}
