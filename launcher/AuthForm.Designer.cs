namespace launcher
{
    partial class AuthForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            panel1 = new Panel();
            labelMiamilux = new Label();
            btnClose = new PictureBox();
            btnMinimize = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox21 = new PictureBox();
            errorImg = new PictureBox();
            btnCantLogIn = new Button();
            btnCreateFreeAccount = new Button();
            tbCode = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            toolTip1 = new ToolTip(components);
            btnLogIn = new CustomObjects.BaseButton();
            btnPrevious = new CustomObjects.CustomButton();
            tbRepPassword = new TextBox();
            waitPanel = new Panel();
            pictureBox2 = new PictureBox();
            lblFormContext = new Label();
            panelEmail = new Panel();
            panelPassword = new Panel();
            panelCode = new Panel();
            panelRepeatPassword = new Panel();
            labelCreatePassword = new Label();
            labelCodeSent = new Label();
            labelWarning = new Label();
            errorImgPassword = new PictureBox();
            errorImgPasswordRepeat = new PictureBox();
            labelEnterEmail = new Label();
            timerCodeSent = new System.Windows.Forms.Timer(components);
            labelSendNewCode = new Label();
            panelDone = new Panel();
            label2 = new Label();
            label1 = new Label();
            timerDone = new System.Windows.Forms.Timer(components);
            panelFailed = new Panel();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            timerFailed = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorImg).BeginInit();
            waitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelEmail.SuspendLayout();
            panelPassword.SuspendLayout();
            panelCode.SuspendLayout();
            panelRepeatPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorImgPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorImgPasswordRepeat).BeginInit();
            panelDone.SuspendLayout();
            panelFailed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(labelMiamilux);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.DarkGoldenrod;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 40);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // labelMiamilux
            // 
            labelMiamilux.AutoSize = true;
            labelMiamilux.BackColor = Color.Transparent;
            labelMiamilux.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMiamilux.ForeColor = Color.FromArgb(198, 158, 97);
            labelMiamilux.Location = new Point(39, 9);
            labelMiamilux.Name = "labelMiamilux";
            labelMiamilux.Size = new Size(71, 23);
            labelMiamilux.TabIndex = 25;
            labelMiamilux.Text = "Miamilux";
            labelMiamilux.UseCompatibleTextRendering = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Image = Properties.Resources.icons8_удалить_20;
            btnClose.Location = new Point(352, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnClose.TabIndex = 24;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Image = Properties.Resources.icons8_горизонтальная_линия_20;
            btnMinimize.Location = new Point(316, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimize.TabIndex = 23;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.FromArgb(25, 28, 35);
            pictureBox21.Image = (Image)resources.GetObject("pictureBox21.Image");
            pictureBox21.Location = new Point(11, 40);
            pictureBox21.Margin = new Padding(11);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(363, 516);
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.TabIndex = 8;
            pictureBox21.TabStop = false;
            pictureBox21.Click += pictureBox21_Click_1;
            pictureBox21.MouseDown += pictureBox21_MouseDown;
            // 
            // errorImg
            // 
            errorImg.BackColor = Color.Transparent;
            errorImg.Image = Properties.Resources.icons8_предупреждение_тормоза_24;
            errorImg.InitialImage = Properties.Resources.icons8_предупреждение_тормоза_24;
            errorImg.Location = new Point(11, 196);
            errorImg.Name = "errorImg";
            errorImg.Size = new Size(24, 24);
            errorImg.SizeMode = PictureBoxSizeMode.AutoSize;
            errorImg.TabIndex = 21;
            errorImg.TabStop = false;
            errorImg.Visible = false;
            // 
            // btnCantLogIn
            // 
            btnCantLogIn.BackColor = Color.Transparent;
            btnCantLogIn.Cursor = Cursors.Hand;
            btnCantLogIn.FlatAppearance.BorderSize = 0;
            btnCantLogIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCantLogIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCantLogIn.FlatStyle = FlatStyle.Flat;
            btnCantLogIn.Font = new Font("Georgia", 10.5F);
            btnCantLogIn.ForeColor = Color.FromArgb(198, 158, 97);
            btnCantLogIn.Location = new Point(106, 414);
            btnCantLogIn.Name = "btnCantLogIn";
            btnCantLogIn.Size = new Size(150, 29);
            btnCantLogIn.TabIndex = 18;
            btnCantLogIn.Text = "Forgot password?";
            btnCantLogIn.UseCompatibleTextRendering = true;
            btnCantLogIn.UseVisualStyleBackColor = false;
            btnCantLogIn.Click += btnCantLogIn_Click;
            // 
            // btnCreateFreeAccount
            // 
            btnCreateFreeAccount.BackColor = Color.Transparent;
            btnCreateFreeAccount.Cursor = Cursors.Hand;
            btnCreateFreeAccount.FlatAppearance.BorderSize = 0;
            btnCreateFreeAccount.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCreateFreeAccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCreateFreeAccount.FlatStyle = FlatStyle.Flat;
            btnCreateFreeAccount.Font = new Font("Georgia", 10.5F);
            btnCreateFreeAccount.ForeColor = Color.FromArgb(198, 158, 97);
            btnCreateFreeAccount.Location = new Point(96, 379);
            btnCreateFreeAccount.Name = "btnCreateFreeAccount";
            btnCreateFreeAccount.Size = new Size(170, 29);
            btnCreateFreeAccount.TabIndex = 17;
            btnCreateFreeAccount.Text = "Create a free Account";
            btnCreateFreeAccount.UseCompatibleTextRendering = true;
            btnCreateFreeAccount.UseVisualStyleBackColor = false;
            btnCreateFreeAccount.Click += btnCreateFreeAccount_Click;
            // 
            // tbCode
            // 
            tbCode.BackColor = Color.White;
            tbCode.BorderStyle = BorderStyle.None;
            tbCode.Font = new Font("Georgia", 10F);
            tbCode.ForeColor = SystemColors.GrayText;
            tbCode.Location = new Point(13, 11);
            tbCode.MaxLength = 6;
            tbCode.Name = "tbCode";
            tbCode.PlaceholderText = "Code *";
            tbCode.Size = new Size(265, 16);
            tbCode.TabIndex = 16;
            tbCode.KeyDown += tbCode_KeyDown;
            tbCode.KeyPress += tbCode_KeyPress;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Georgia", 10.2F);
            tbEmail.ForeColor = SystemColors.GrayText;
            tbEmail.Location = new Point(13, 11);
            tbEmail.MaxLength = 50;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email *";
            tbEmail.Size = new Size(265, 16);
            tbEmail.TabIndex = 15;
            tbEmail.TextChanged += tbEmail_TextChanged;
            tbEmail.KeyDown += tbEmail_KeyDown;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Georgia", 10.2F);
            tbPassword.ForeColor = SystemColors.GrayText;
            tbPassword.Location = new Point(13, 11);
            tbPassword.MaxLength = 50;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '•';
            tbPassword.PlaceholderText = "Password *";
            tbPassword.Size = new Size(265, 16);
            tbPassword.TabIndex = 22;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(198, 158, 97);
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(117, 358);
            btnLogIn.Margin = new Padding(13, 13, 15, 13);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(150, 45);
            btnLogIn.TabIndex = 23;
            btnLogIn.Text = "Login";
            btnLogIn.UseCompatibleTextRendering = true;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(196, 157, 108);
            btnPrevious.BackgroundColor = Color.FromArgb(196, 157, 108);
            btnPrevious.BorderColor = Color.FromArgb(198, 158, 97);
            btnPrevious.BorderRadius = 5;
            btnPrevious.BorderSize = 0;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ForeColor = Color.Transparent;
            btnPrevious.Image = Properties.Resources.icons8_стрелка__указывающая_влево_24;
            btnPrevious.Location = new Point(35, 87);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(33, 33);
            btnPrevious.TabIndex = 24;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Visible = false;
            btnPrevious.Click += btnPrev_Click;
            // 
            // tbRepPassword
            // 
            tbRepPassword.BackColor = Color.White;
            tbRepPassword.BorderStyle = BorderStyle.None;
            tbRepPassword.Font = new Font("Georgia", 10.2F);
            tbRepPassword.ForeColor = SystemColors.GrayText;
            tbRepPassword.Location = new Point(13, 11);
            tbRepPassword.MaxLength = 50;
            tbRepPassword.Name = "tbRepPassword";
            tbRepPassword.PasswordChar = '•';
            tbRepPassword.PlaceholderText = "Repeat password *";
            tbRepPassword.Size = new Size(265, 16);
            tbRepPassword.TabIndex = 25;
            tbRepPassword.UseSystemPasswordChar = true;
            tbRepPassword.KeyDown += tbRepPassword_KeyDown;
            // 
            // waitPanel
            // 
            waitPanel.BackColor = Color.Transparent;
            waitPanel.Controls.Add(pictureBox2);
            waitPanel.Location = new Point(158, 14);
            waitPanel.Name = "waitPanel";
            waitPanel.Size = new Size(48, 48);
            waitPanel.TabIndex = 26;
            waitPanel.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Rolling;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblFormContext
            // 
            lblFormContext.AutoSize = true;
            lblFormContext.BackColor = Color.Transparent;
            lblFormContext.Font = new Font("Georgia", 10.2F);
            lblFormContext.ForeColor = Color.FromArgb(198, 158, 97);
            lblFormContext.Location = new Point(89, 108);
            lblFormContext.Name = "lblFormContext";
            lblFormContext.Size = new Size(0, 17);
            lblFormContext.TabIndex = 3;
            lblFormContext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Controls.Add(tbEmail);
            panelEmail.Location = new Point(46, 186);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(291, 43);
            panelEmail.TabIndex = 27;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(tbPassword);
            panelPassword.Location = new Point(46, 235);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(291, 43);
            panelPassword.TabIndex = 28;
            // 
            // panelCode
            // 
            panelCode.BackColor = Color.White;
            panelCode.Controls.Add(tbCode);
            panelCode.Location = new Point(46, 235);
            panelCode.Name = "panelCode";
            panelCode.Size = new Size(291, 43);
            panelCode.TabIndex = 29;
            // 
            // panelRepeatPassword
            // 
            panelRepeatPassword.BackColor = Color.White;
            panelRepeatPassword.Controls.Add(tbRepPassword);
            panelRepeatPassword.Location = new Point(46, 284);
            panelRepeatPassword.Name = "panelRepeatPassword";
            panelRepeatPassword.Size = new Size(291, 43);
            panelRepeatPassword.TabIndex = 29;
            panelRepeatPassword.Visible = false;
            // 
            // labelCreatePassword
            // 
            labelCreatePassword.AutoSize = true;
            labelCreatePassword.BackColor = Color.Transparent;
            labelCreatePassword.Font = new Font("Georgia", 9.5F);
            labelCreatePassword.ForeColor = Color.FromArgb(198, 158, 97);
            labelCreatePassword.Location = new Point(35, 173);
            labelCreatePassword.Name = "labelCreatePassword";
            labelCreatePassword.Size = new Size(127, 19);
            labelCreatePassword.TabIndex = 26;
            labelCreatePassword.Text = "Create new password";
            labelCreatePassword.UseCompatibleTextRendering = true;
            // 
            // labelCodeSent
            // 
            labelCodeSent.AutoSize = true;
            labelCodeSent.BackColor = Color.Transparent;
            labelCodeSent.Font = new Font("Georgia", 10.5F);
            labelCodeSent.ForeColor = Color.FromArgb(198, 158, 97);
            labelCodeSent.Location = new Point(35, 241);
            labelCodeSent.Name = "labelCodeSent";
            labelCodeSent.Size = new Size(184, 21);
            labelCodeSent.TabIndex = 33;
            labelCodeSent.Text = "The code sent to your email.";
            labelCodeSent.UseCompatibleTextRendering = true;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.BackColor = Color.Transparent;
            labelWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(35, 290);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 17);
            labelWarning.TabIndex = 3;
            // 
            // errorImgPassword
            // 
            errorImgPassword.BackColor = Color.Transparent;
            errorImgPassword.Image = Properties.Resources.icons8_предупреждение_тормоза_24;
            errorImgPassword.InitialImage = Properties.Resources.icons8_предупреждение_тормоза_24;
            errorImgPassword.Location = new Point(11, 244);
            errorImgPassword.Name = "errorImgPassword";
            errorImgPassword.Size = new Size(24, 24);
            errorImgPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            errorImgPassword.TabIndex = 30;
            errorImgPassword.TabStop = false;
            errorImgPassword.Visible = false;
            // 
            // errorImgPasswordRepeat
            // 
            errorImgPasswordRepeat.BackColor = Color.Transparent;
            errorImgPasswordRepeat.Image = Properties.Resources.icons8_предупреждение_тормоза_24;
            errorImgPasswordRepeat.InitialImage = Properties.Resources.icons8_предупреждение_тормоза_24;
            errorImgPasswordRepeat.Location = new Point(11, 293);
            errorImgPasswordRepeat.Name = "errorImgPasswordRepeat";
            errorImgPasswordRepeat.Size = new Size(24, 24);
            errorImgPasswordRepeat.SizeMode = PictureBoxSizeMode.AutoSize;
            errorImgPasswordRepeat.TabIndex = 31;
            errorImgPasswordRepeat.TabStop = false;
            errorImgPasswordRepeat.Visible = false;
            // 
            // labelEnterEmail
            // 
            labelEnterEmail.AutoSize = true;
            labelEnterEmail.BackColor = Color.Transparent;
            labelEnterEmail.Font = new Font("Georgia", 10.5F);
            labelEnterEmail.ForeColor = Color.FromArgb(198, 158, 97);
            labelEnterEmail.Location = new Point(35, 123);
            labelEnterEmail.Name = "labelEnterEmail";
            labelEnterEmail.Size = new Size(169, 21);
            labelEnterEmail.TabIndex = 32;
            labelEnterEmail.Text = "Enter your email address:";
            labelEnterEmail.UseCompatibleTextRendering = true;
            // 
            // timerCodeSent
            // 
            timerCodeSent.Interval = 1000;
            timerCodeSent.Tick += timerCodeSent_Tick;
            // 
            // labelSendNewCode
            // 
            labelSendNewCode.AutoSize = true;
            labelSendNewCode.BackColor = Color.Transparent;
            labelSendNewCode.Cursor = Cursors.Hand;
            labelSendNewCode.Font = new Font("Georgia", 10.5F);
            labelSendNewCode.ForeColor = Color.FromArgb(198, 158, 97);
            labelSendNewCode.Location = new Point(101, 268);
            labelSendNewCode.Name = "labelSendNewCode";
            labelSendNewCode.Size = new Size(160, 21);
            labelSendNewCode.TabIndex = 100;
            labelSendNewCode.Text = "Send a new code in 2:00";
            labelSendNewCode.TextAlign = ContentAlignment.MiddleCenter;
            labelSendNewCode.UseCompatibleTextRendering = true;
            labelSendNewCode.Click += labelSendNewCode_Click;
            // 
            // panelDone
            // 
            panelDone.BackColor = Color.Transparent;
            panelDone.Controls.Add(label2);
            panelDone.Controls.Add(label1);
            panelDone.Location = new Point(132, 325);
            panelDone.Name = "panelDone";
            panelDone.Size = new Size(90, 30);
            panelDone.TabIndex = 201;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(198, 158, 97);
            label2.Location = new Point(29, 3);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Done";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 30);
            label1.TabIndex = 0;
            label1.Text = "✓";
            // 
            // timerDone
            // 
            timerDone.Interval = 2000;
            timerDone.Tick += timerDone_Tick;
            // 
            // panelFailed
            // 
            panelFailed.Controls.Add(pictureBox5);
            panelFailed.Controls.Add(label4);
            panelFailed.Location = new Point(134, 328);
            panelFailed.Name = "panelFailed";
            panelFailed.Size = new Size(94, 25);
            panelFailed.TabIndex = 202;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_удалить_24;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.TabIndex = 203;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 15.75F);
            label4.ForeColor = Color.FromArgb(198, 158, 97);
            label4.Location = new Point(24, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 1;
            label4.Text = "Failed";
            // 
            // timerFailed
            // 
            timerFailed.Interval = 2000;
            timerFailed.Tick += timerFailed_Tick;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 35);
            ClientSize = new Size(385, 576);
            Controls.Add(panelFailed);
            Controls.Add(panelDone);
            Controls.Add(labelCreatePassword);
            Controls.Add(labelSendNewCode);
            Controls.Add(labelCodeSent);
            Controls.Add(panelCode);
            Controls.Add(labelEnterEmail);
            Controls.Add(waitPanel);
            Controls.Add(errorImgPasswordRepeat);
            Controls.Add(errorImgPassword);
            Controls.Add(labelWarning);
            Controls.Add(panelRepeatPassword);
            Controls.Add(panelPassword);
            Controls.Add(panelEmail);
            Controls.Add(lblFormContext);
            Controls.Add(btnPrevious);
            Controls.Add(btnLogIn);
            Controls.Add(errorImg);
            Controls.Add(btnCantLogIn);
            Controls.Add(btnCreateFreeAccount);
            Controls.Add(pictureBox21);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AuthForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += AuthForm_Load;
            MouseDown += AuthForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorImg).EndInit();
            waitPanel.ResumeLayout(false);
            waitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            panelCode.ResumeLayout(false);
            panelCode.PerformLayout();
            panelRepeatPassword.ResumeLayout(false);
            panelRepeatPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorImgPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorImgPasswordRepeat).EndInit();
            panelDone.ResumeLayout(false);
            panelDone.PerformLayout();
            panelFailed.ResumeLayout(false);
            panelFailed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox21;
        private PictureBox errorImg;
        private CustomObjects.CustomButton btnNext;
        private CustomObjects.CustomButton btnPrev;
        private Button btnCantLogIn;
        private Button btnCreateFreeAccount;
        private TextBox tbCode;
        private TextBox tbEmail;
        private CustomObjects.BaseButton baseButton1;
        private TextBox tbPassword;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
		private ToolTip toolTip1;
		private CustomObjects.BaseButton btnLogIn;
		private CustomObjects.CustomButton btnPrevious;
		private TextBox tbRepPassword;
		private Panel waitPanel;
		private PictureBox pictureBox2;
        private Label lblFormContext;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelEmail;
        private Panel panelPassword;
        private Panel panelRepeatPassword;
        private Panel panelCode;
        private Label label1;
        private Label labelWarning;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox errorImgPassword;
        private PictureBox errorImgPasswordRepeat;
        private Label labelEnterEmail;
        private Label label;
        private Label labelCodeSent;
        private System.Windows.Forms.Timer timerCodeSent;
        private Button button1;
        private Button buttonSendNewCode;
        private Label labelSendNewCode;
        private Label labelCreatePassword;
        private Panel panel5;
        private Label label2;
        private Panel panelDone;
        private System.Windows.Forms.Timer timerDone;
        private Panel panelFailed;
        private Label label4;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer timerFailed;
        private Label labelMiamilux;
        private Label labelTest;
    }
}