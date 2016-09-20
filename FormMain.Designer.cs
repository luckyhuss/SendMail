namespace SendEmail
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.openFileDialogBody = new System.Windows.Forms.OpenFileDialog();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBoxFilenameBody = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxToEmail = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxFromEmail = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxSubject = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxTo = new Telerik.WinControls.UI.RadTextBox();
            this.radDropDownListSMTP = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxFrom = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButtonLoadBody = new Telerik.WinControls.UI.RadButton();
            this.radButtonSend = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxFilenameBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxToEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxFromEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSMTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoadBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogBody
            // 
            this.openFileDialogBody.Filter = "Word document|*.doc;*.docx";
            this.openFileDialogBody.Title = "Open Body content document";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radTextBoxFilenameBody);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radTextBoxToEmail);
            this.radGroupBox1.Controls.Add(this.radTextBoxFromEmail);
            this.radGroupBox1.Controls.Add(this.radTextBoxSubject);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radTextBoxTo);
            this.radGroupBox1.Controls.Add(this.radDropDownListSMTP);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radTextBoxFrom);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radButtonLoadBody);
            this.radGroupBox1.Controls.Add(this.radButtonSend);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(369, 264);
            this.radGroupBox1.TabIndex = 0;
            // 
            // radTextBoxFilenameBody
            // 
            this.radTextBoxFilenameBody.Location = new System.Drawing.Point(68, 126);
            this.radTextBoxFilenameBody.Name = "radTextBoxFilenameBody";
            this.radTextBoxFilenameBody.ReadOnly = true;
            this.radTextBoxFilenameBody.Size = new System.Drawing.Size(284, 20);
            this.radTextBoxFilenameBody.TabIndex = 23;
            this.radTextBoxFilenameBody.TabStop = false;
            this.radTextBoxFilenameBody.Tag = "Filename";
            this.radTextBoxFilenameBody.Text = "Filename";
            this.radTextBoxFilenameBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(5, 126);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(31, 18);
            this.radLabel5.TabIndex = 21;
            this.radLabel5.Text = "Body";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(5, 100);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(35, 18);
            this.radLabel4.TabIndex = 19;
            this.radLabel4.Text = "SMTP";
            // 
            // radTextBoxToEmail
            // 
            this.radTextBoxToEmail.Location = new System.Drawing.Point(214, 47);
            this.radTextBoxToEmail.Name = "radTextBoxToEmail";
            this.radTextBoxToEmail.Size = new System.Drawing.Size(138, 20);
            this.radTextBoxToEmail.TabIndex = 3;
            this.radTextBoxToEmail.TabStop = false;
            this.radTextBoxToEmail.Tag = "Email";
            this.radTextBoxToEmail.Text = "anwar.buchoo@msn.com";
            // 
            // radTextBoxFromEmail
            // 
            this.radTextBoxFromEmail.Location = new System.Drawing.Point(214, 21);
            this.radTextBoxFromEmail.Name = "radTextBoxFromEmail";
            this.radTextBoxFromEmail.Size = new System.Drawing.Size(138, 20);
            this.radTextBoxFromEmail.TabIndex = 1;
            this.radTextBoxFromEmail.TabStop = false;
            this.radTextBoxFromEmail.Tag = "Email";
            this.radTextBoxFromEmail.Text = "Email";
            // 
            // radTextBoxSubject
            // 
            this.radTextBoxSubject.Location = new System.Drawing.Point(68, 73);
            this.radTextBoxSubject.Name = "radTextBoxSubject";
            this.radTextBoxSubject.Size = new System.Drawing.Size(284, 20);
            this.radTextBoxSubject.TabIndex = 4;
            this.radTextBoxSubject.TabStop = false;
            this.radTextBoxSubject.Tag = "Subject";
            this.radTextBoxSubject.Text = "Subject";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(5, 73);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(43, 18);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "Subject";
            // 
            // radTextBoxTo
            // 
            this.radTextBoxTo.Location = new System.Drawing.Point(68, 47);
            this.radTextBoxTo.Name = "radTextBoxTo";
            this.radTextBoxTo.Size = new System.Drawing.Size(140, 20);
            this.radTextBoxTo.TabIndex = 2;
            this.radTextBoxTo.TabStop = false;
            this.radTextBoxTo.Tag = "Name";
            this.radTextBoxTo.Text = "Anwar Buchoo";
            // 
            // radDropDownListSMTP
            // 
            this.radDropDownListSMTP.DropDownAnimationEnabled = true;
            this.radDropDownListSMTP.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "smtp.intnet.mu";
            radListDataItem1.TextWrap = true;
            this.radDropDownListSMTP.Items.Add(radListDataItem1);
            this.radDropDownListSMTP.Location = new System.Drawing.Point(68, 100);
            this.radDropDownListSMTP.Name = "radDropDownListSMTP";
            this.radDropDownListSMTP.ShowImageInEditorArea = true;
            this.radDropDownListSMTP.Size = new System.Drawing.Size(284, 20);
            this.radDropDownListSMTP.TabIndex = 5;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(5, 47);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(19, 18);
            this.radLabel2.TabIndex = 15;
            this.radLabel2.Text = "To";
            // 
            // radTextBoxFrom
            // 
            this.radTextBoxFrom.Location = new System.Drawing.Point(68, 21);
            this.radTextBoxFrom.Name = "radTextBoxFrom";
            this.radTextBoxFrom.Size = new System.Drawing.Size(140, 20);
            this.radTextBoxFrom.TabIndex = 0;
            this.radTextBoxFrom.TabStop = false;
            this.radTextBoxFrom.Tag = "Name";
            this.radTextBoxFrom.Text = "Name";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(32, 18);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "From";
            // 
            // radButtonLoadBody
            // 
            this.radButtonLoadBody.Location = new System.Drawing.Point(222, 152);
            this.radButtonLoadBody.Name = "radButtonLoadBody";
            this.radButtonLoadBody.Size = new System.Drawing.Size(130, 24);
            this.radButtonLoadBody.TabIndex = 6;
            this.radButtonLoadBody.Text = "Load Body";
            this.radButtonLoadBody.Click += new System.EventHandler(this.radButtonLoadBody_Click);
            // 
            // radButtonSend
            // 
            this.radButtonSend.Location = new System.Drawing.Point(222, 182);
            this.radButtonSend.Name = "radButtonSend";
            this.radButtonSend.Size = new System.Drawing.Size(130, 24);
            this.radButtonSend.TabIndex = 7;
            this.radButtonSend.Text = "Send Mail";
            this.radButtonSend.Click += new System.EventHandler(this.radButtonSend_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 291);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxFilenameBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxToEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxFromEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSMTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoadBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogBody;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxFilenameBody;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTextBoxToEmail;
        private Telerik.WinControls.UI.RadTextBox radTextBoxFromEmail;
        private Telerik.WinControls.UI.RadTextBox radTextBoxSubject;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTo;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListSMTP;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBoxFrom;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButtonLoadBody;
        private Telerik.WinControls.UI.RadButton radButtonSend;
    }
}

