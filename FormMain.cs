using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using Telerik.WinControls.UI;
using Telerik.WinControls.RichTextBox.FormatProviders.Txt;

namespace SendEmail
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string GetBody()
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            object nullobj = System.Reflection.Missing.Value;
            object file = radTextBoxFilenameBody.Text;
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(
            ref file, ref nullobj, ref nullobj,
            ref nullobj, ref nullobj, ref nullobj,
            ref nullobj, ref nullobj, ref nullobj,
            ref nullobj, ref nullobj, ref nullobj,
            ref nullobj, ref nullobj, ref nullobj);
            doc.ActiveWindow.Selection.WholeStory();
            doc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            string text = data.GetData(DataFormats.Html).ToString();
            
            // clean data 
            text = text.Substring(text.IndexOf("<html xmlns:o="));

            doc.Close(ref nullobj, ref nullobj, ref nullobj);
            app.Quit(ref nullobj, ref nullobj, ref nullobj);

            return text;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            radTextBoxFrom.GotFocus += textBox_GotFocus;
            radTextBoxFromEmail.GotFocus += textBox_GotFocus;
            radTextBoxTo.GotFocus += textBox_GotFocus;
            radTextBoxToEmail.GotFocus += textBox_GotFocus;
            radTextBoxSubject.GotFocus += textBox_GotFocus;

            radTextBoxFrom.Leave += textBox_Leave;
            radTextBoxFromEmail.Leave += textBox_Leave;
            radTextBoxTo.Leave += textBox_Leave;
            radTextBoxToEmail.Leave += textBox_Leave;
            radTextBoxSubject.Leave += textBox_Leave;

            radDropDownListSMTP.SelectedIndex = 0;
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            RadTextBox text = (RadTextBox) sender;

            if (text.Text.Trim().Equals("Name")
                || text.Text.Trim().Equals("Email")
                || text.Text.Trim().Equals("Subject"))
            {
                // clear text
                text.Text = string.Empty;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            RadTextBox text = (RadTextBox)sender;

            if (string.IsNullOrEmpty(text.Text.Trim()))
            {
                // clear text
                text.Text = text.Tag.ToString();
            }
        }

        private void radButtonLoadBody_Click(object sender, EventArgs e)
        {
            if (openFileDialogBody.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                radTextBoxFilenameBody.Text = openFileDialogBody.FileName;
            }
        }

        private void radButtonSend_Click(object sender, EventArgs e)
        {
            MailMessage mailObj = new MailMessage();

            mailObj.BodyEncoding = Encoding.Default;
            mailObj.IsBodyHtml = true;

            mailObj.Body = GetBody();
            mailObj.From = new MailAddress(radTextBoxFromEmail.Text.Trim(), radTextBoxFrom.Text.Trim());
            mailObj.To.Add(new MailAddress(radTextBoxToEmail.Text.Trim(), radTextBoxTo.Text.Trim()));
            mailObj.Sender = mailObj.From;
            mailObj.Subject = radTextBoxSubject.Text.Trim();
            
            SmtpClient SMTPServer = new SmtpClient(radDropDownListSMTP.SelectedItem.Text.Trim());
            try
            {
                SMTPServer.Send(mailObj);
                MessageBox.Show(String.Format("Sent to : {1} ({0})", mailObj.To[0].Address, mailObj.To[0].DisplayName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
