namespace launcher
{
	partial class VerificationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationForm));
			panel1 = new Panel();
			btnClose = new PictureBox();
			btnMinimize = new PictureBox();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			tbCode = new TextBox();
			btnVerify = new CustomObjects.BaseButton();
			tbRepPassword = new TextBox();
			tbPassword = new TextBox();
			timer1 = new System.Windows.Forms.Timer(components);
			lblResentCode = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(25, 28, 35);
			panel1.Controls.Add(btnClose);
			panel1.Controls.Add(btnMinimize);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(386, 51);
			panel1.TabIndex = 1;
			panel1.MouseDown += panel1_MouseDown;
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClose.BackColor = Color.Transparent;
			btnClose.Image = Properties.Resources.icons8_удалить_20;
			btnClose.Location = new Point(344, 13);
			btnClose.Margin = new Padding(3, 4, 3, 4);
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
			btnMinimize.Location = new Point(307, 13);
			btnMinimize.Margin = new Padding(3, 4, 3, 4);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(30, 30);
			btnMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
			btnMinimize.TabIndex = 23;
			btnMinimize.TabStop = false;
			btnMinimize.Click += btnMinimize_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Left;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Margin = new Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(45, 51);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.FromArgb(25, 28, 35);
			pictureBox2.Dock = DockStyle.Fill;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(0, 51);
			pictureBox2.Margin = new Padding(1);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(386, 425);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 9;
			pictureBox2.TabStop = false;
			// 
			// tbCode
			// 
			tbCode.BackColor = Color.White;
			tbCode.BorderStyle = BorderStyle.None;
			tbCode.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tbCode.ForeColor = SystemColors.GrayText;
			tbCode.Location = new Point(76, 207);
			tbCode.Margin = new Padding(3, 4, 3, 4);
			tbCode.MaxLength = 6;
			tbCode.Name = "tbCode";
			tbCode.PlaceholderText = "Enter the received code*";
			tbCode.Size = new Size(223, 23);
			tbCode.TabIndex = 16;
			tbCode.TextAlign = HorizontalAlignment.Center;
			tbCode.KeyPress += tbCode_KeyPress;
			// 
			// btnVerify
			// 
			btnVerify.BackColor = Color.FromArgb(198, 158, 97);
			btnVerify.FlatAppearance.BorderSize = 0;
			btnVerify.FlatStyle = FlatStyle.Flat;
			btnVerify.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnVerify.ForeColor = Color.White;
			btnVerify.Location = new Point(106, 281);
			btnVerify.Margin = new Padding(3, 4, 3, 4);
			btnVerify.Name = "btnVerify";
			btnVerify.Size = new Size(160, 45);
			btnVerify.TabIndex = 24;
			btnVerify.Text = "Verify";
			btnVerify.UseVisualStyleBackColor = false;
			btnVerify.Click += btnVerify_Click;
			// 
			// tbRepPassword
			// 
			tbRepPassword.BackColor = Color.White;
			tbRepPassword.BorderStyle = BorderStyle.None;
			tbRepPassword.Font = new Font("Microsoft Sans Serif", 10F);
			tbRepPassword.ForeColor = SystemColors.GrayText;
			tbRepPassword.Location = new Point(46, 232);
			tbRepPassword.MaxLength = 50;
			tbRepPassword.Multiline = true;
			tbRepPassword.Name = "tbRepPassword";
			tbRepPassword.PasswordChar = '•';
			tbRepPassword.PlaceholderText = "Repeat New Password*";
			tbRepPassword.Size = new Size(291, 39);
			tbRepPassword.TabIndex = 27;
			tbRepPassword.UseSystemPasswordChar = true;
			tbRepPassword.Visible = false;
			// 
			// tbPassword
			// 
			tbPassword.BackColor = Color.White;
			tbPassword.BorderStyle = BorderStyle.None;
			tbPassword.Font = new Font("Microsoft Sans Serif", 10F);
			tbPassword.ForeColor = SystemColors.GrayText;
			tbPassword.Location = new Point(46, 177);
			tbPassword.MaxLength = 50;
			tbPassword.Multiline = true;
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '•';
			tbPassword.PlaceholderText = "New Password*";
			tbPassword.Size = new Size(291, 39);
			tbPassword.TabIndex = 26;
			tbPassword.UseSystemPasswordChar = true;
			tbPassword.Visible = false;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// lblResentCode
			// 
			lblResentCode.AutoSize = true;
			lblResentCode.BackColor = Color.Transparent;
			lblResentCode.Font = new Font("Georgia", 10.2F);
			lblResentCode.ForeColor = Color.FromArgb(198, 158, 97);
			lblResentCode.Location = new Point(150, 130);
			lblResentCode.Name = "lblResentCode";
			lblResentCode.Size = new Size(0, 20);
			lblResentCode.TabIndex = 28;
			lblResentCode.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// VerificationForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(386, 476);
			Controls.Add(lblResentCode);
			Controls.Add(tbRepPassword);
			Controls.Add(tbPassword);
			Controls.Add(btnVerify);
			Controls.Add(tbCode);
			Controls.Add(pictureBox2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			Name = "VerificationForm";
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "VerificationForm";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
			((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox btnClose;
		private PictureBox btnMinimize;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private TextBox tbCode;
		private CustomObjects.BaseButton btnVerify;
		private TextBox tbRepPassword;
		private TextBox tbPassword;
		private System.Windows.Forms.Timer timer1;
		private Label lblResentCode;
	}
}