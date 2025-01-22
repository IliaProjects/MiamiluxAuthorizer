using launcher.Classes;
using launcher.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher
{
	public partial class VerificationForm : Form
	{
		private string expectedCode;
		private int secondsLeft;
		private string Email;

		private VerificationService _verificationService;
		private SMTPService_old _smtpService;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("User32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("User32.dll")]
		public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private FormState State { get; set; }
		public enum FormState { FromCreatingNewAccount, FromCantLogin, SetNewPassword }
		public VerificationForm(string VerificationCode, FormState state, string email = null)
		{
			InitializeComponent();
			expectedCode = VerificationCode;
			State = state;
			Email = email;
			ActivateFormControls(state);
			btnMinimize.MouseEnter += (s, e) =>
			{
				btnMinimize.BackColor = Color.Silver;
			};
			btnMinimize.MouseLeave += (s, e) =>
			{
				btnMinimize.BackColor = Color.FromArgb(25, 28, 35);
			};
			btnMinimize.MouseClick += (s, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					btnMinimize.BackColor = Color.Silver;
				}
			};

			btnClose.MouseEnter += (s, e) =>
			{
				btnClose.BackColor = Color.Silver;
			};
			btnClose.MouseLeave += (s, e) =>
			{
				btnClose.BackColor = Color.FromArgb(25, 28, 35);
			};
			btnClose.MouseClick += (s, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					btnClose.BackColor = Color.Silver;
				}
			};

			panel1.MouseDown += (s, e) => {
				if (e.Button == MouseButtons.Left)
				{
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			};

		}
		private void ActivateFormControls(FormState state)
		{
			if (state != FormState.SetNewPassword)
			{
				tbCode.Visible = true;
				tbPassword.Visible = tbRepPassword.Visible = false;
				btnVerify.Text = "Verify";
			}
			else
			{
				tbCode.Visible = false;
				tbPassword.Visible = tbRepPassword.Visible = true;
				btnVerify.Text = "Set New Password";
			}

		}
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnVerify_Click(object sender, EventArgs e)
		{
			try
			{
				string inputCode = tbCode.Text;
				if (btnVerify.Text == "Retry")
				{
					StartCountdown(2);
					btnVerify.Enabled = false;
				}

				if (inputCode == expectedCode)
				{
					if (State == FormState.FromCreatingNewAccount)
					{
						MessageBox.Show("Code confirmed.");
						lblResentCode.Text = string.Empty;
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
					else if (State == FormState.FromCantLogin)
					{
						ActivateFormControls(FormState.SetNewPassword);
						if (tbPassword.Text != tbRepPassword.Text)
							MessageBox.Show("Password mismatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						else
						{
							MessageBox.Show("Password changed successfully.");
							lblResentCode.Text = string.Empty;
							this.DialogResult = DialogResult.OK;
							this.Close();
						}
					}
				}
				else
				{
					MessageBox.Show("Invalid code. Please try again.");
					btnVerify.Text = "Retry";
				}
			}
			catch (Exception ex) { ex.Message.ToString(); }
		}

		private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				// Разрешаем вводить тока цифры
				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex) { ex.Message.ToString(); }
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (secondsLeft > 0)
			{
				secondsLeft--;
				UpdateLabel();
			}
			else
			{
				timer1.Stop();
				_verificationService = new VerificationService();
				if (_smtpService.SendEmail(Email, "Verification code", $"Your verification code: {_verificationService._code}") == true)
				{
					lblResentCode.Text = "The code will be resent.";
					btnVerify.Text = "Verify";
					btnVerify.Enabled = true;
				}

			}
		}
		private void StartCountdown(int minutes)
		{
			secondsLeft = minutes * 60;
			UpdateLabel();
			timer1.Start();
		}
		private void UpdateLabel()
		{
			int minutes = secondsLeft / 60;
			int seconds = secondsLeft % 60;
			lblResentCode.Text = $"The code will be resent via: {minutes}:{seconds:D2} minutes";
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{

		}
	}
}
