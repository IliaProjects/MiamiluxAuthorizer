using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using launcher.Services;
using launcher.Classes;
using launcher.CustomObjects;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;

namespace launcher
{
    public partial class AuthForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        private enum PanelState
        {
            LoginMain, //LoginLogged,
            RegMain, //RegConfirm, RegSuccess, RegFailed,
            CantLoginMain, CantLoginNewPass //CantLoginConfirm, CantLoginFailed, CantLoginNewPass 
        }

        private PanelState State;

        private VerificationService _verificationService;
        private SMTPService _smtpService;

        //private SMTPService_old _smtpService;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public int _timeout = 0;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public AuthForm()
        {
            SetProcessDPIAware();
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            SetState(PanelState.LoginMain);

            btnCreateFreeAccount.Parent = pictureBox21;
            btnCreateFreeAccount.BackColor = Color.Transparent;
            btnCantLogIn.Parent = pictureBox21;
            btnCantLogIn.BackColor = Color.Transparent;

            #region Дизайн топ бара
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

            #endregion

            #region Дизайн кнопок Не могу войти и Новая учетка
            btnCantLogIn.MouseEnter += (s, e) =>
            {
                btnCantLogIn.BackColor = Color.Transparent;
                btnCantLogIn.Parent = pictureBox21;
                btnCantLogIn.ForeColor = Color.White;
            };

            btnCantLogIn.MouseLeave += (s, e) =>
            {
                btnCantLogIn.BackColor = Color.Transparent;
                btnCantLogIn.Parent = pictureBox21;
                btnCantLogIn.ForeColor = Color.FromArgb(198, 158, 97);
            };

            btnCreateFreeAccount.MouseEnter += (s, e) =>
            {
                btnCreateFreeAccount.BackColor = Color.Transparent;
                btnCreateFreeAccount.Parent = pictureBox21;
                btnCreateFreeAccount.ForeColor = Color.White;
            };

            btnCreateFreeAccount.MouseLeave += (s, e) =>
            {
                btnCreateFreeAccount.BackColor = Color.Transparent;
                btnCreateFreeAccount.Parent = pictureBox21;
                btnCreateFreeAccount.ForeColor = Color.FromArgb(196, 157, 108);
            };
            #endregion

            btnPrevious.Parent = pictureBox21;
            btnPrevious.BackColor = Color.Transparent;

            btnPrevious.MouseEnter += (s, e) =>
            {
                btnPrevious.BackColor = Color.FromArgb(198, 158, 97);
                btnPrevious.Parent = pictureBox21;
            };

            btnPrevious.MouseLeave += (s, e) =>
            {
                btnPrevious.BackColor = Color.Transparent;
                btnPrevious.Parent = pictureBox21;
            };

            labelEnterEmail.Parent = pictureBox21;
            labelEnterEmail.BackColor = Color.Transparent;

            //labelCodeSent.Parent = pictureBox21;
            //labelCodeSent.BackColor = Color.Transparent;

            labelWarning.Parent = pictureBox21;
            labelWarning.BackColor = Color.Transparent;

            labelSendNewCode.Parent = pictureBox21;
            labelSendNewCode.BackColor = Color.Transparent;

            labelCreatePassword.Parent = pictureBox21;
            labelCreatePassword.BackColor = Color.Transparent;

            labelSendNewCode.MouseEnter += (s, e) =>
            {
                if (labelSendNewCodeEnabled)
                {
                    labelSendNewCode.BackColor = Color.Transparent;
                    labelSendNewCode.Parent = pictureBox21;
                    labelSendNewCode.ForeColor = Color.White;
                }
            };

            labelSendNewCode.MouseLeave += (s, e) =>
            {
                if (labelSendNewCodeEnabled)
                {
                    labelSendNewCode.BackColor = Color.Transparent;
                    labelSendNewCode.Parent = pictureBox21;
                    labelSendNewCode.ForeColor = Color.FromArgb(255, 178, 97);
                }
            };

            panelDone.Parent = pictureBox21;
            panelDone.BackColor = Color.Transparent;

            panelFailed.Parent = pictureBox21;
            panelFailed.BackColor = Color.Transparent;

            waitPanel.Parent = pictureBox21;
            waitPanel.BackColor = Color.Transparent;

            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
            panel1.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
            pictureBox2.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        ReleaseCapture();
                        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    }
                };



            tbCode.AutoSize = tbEmail.AutoSize = tbPassword.AutoSize = tbRepPassword.AutoSize = false;
            tbCode.Height = tbEmail.Height = tbPassword.Height = tbRepPassword.Height = panelEmail.Height - (panelEmail.Height + 1)/2;
            var x = panelRepeatPassword.Height;
            try
            {
                PrivateFontCollection pfcExtraBold = new PrivateFontCollection();
                int fontLength = Properties.Resources.Jost_ExtraBold.Length;
                byte[] fontData = Properties.Resources.Jost_ExtraBold;
                System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontData, 0, data, fontLength);
                pfcExtraBold.AddMemoryFont(data, fontLength);

                PrivateFontCollection pfcMedium = new PrivateFontCollection();
                fontLength = Properties.Resources.Jost_Medium.Length;
                fontData = Properties.Resources.Jost_Medium;
                data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontData, 0, data, fontLength);
                pfcMedium.AddMemoryFont(data, fontLength);


                btnCantLogIn.Font = new Font(pfcMedium.Families[0], btnCantLogIn.Font.Size);
                btnCreateFreeAccount.Font = new Font(pfcMedium.Families[0], btnCreateFreeAccount.Font.Size);

                /*tbEmail.Font = new Font(pfcMedium.Families[0], tbEmail.Font.Size);
                tbPassword.Font = new Font(pfcMedium.Families[0], tbPassword.Font.Size);
                tbRepPassword.Font = new Font(pfcMedium.Families[0], tbRepPassword.Font.Size);
                tbCode.Font = new Font(pfcMedium.Families[0], tbCode.Font.Size);*/

                labelEnterEmail.Font = new Font(pfcMedium.Families[0], labelEnterEmail.Font.Size);
                //labelCodeSent.Font = new Font(pfcMedium.Families[0], labelCodeSent.Font.Size);
                labelWarning.Font = new Font(pfcMedium.Families[0], labelWarning.Font.Size);

                //labelSendNewCode.Font = new Font(pfcMedium.Families[0], labelSendNewCode.Font.Size);

                //btnLogIn.Font = new Font(pfcExtraBold.Families[0], btnLogIn.Font.Size);
                Font extraBold = new Font(pfcExtraBold.Families[0], labelMiamilux.Font.Size);

                labelMiamilux.Font = extraBold;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fonts: " + ex.Message);
            }
            _smtpService = new SMTPService("no-reply@luxmiami.us", "jOpeuHY}U,GE");  //ЛОГИН И ПАРОЛЬ ОТ SMTP СЕРВЕРА
            //_smtpService = new SMTPService_old("no-reply@miamilux.us", "jOpeuHY}U,GE");  //ЛОГИН И ПАРОЛЬ ОТ SMTP СЕРВЕРА

            //_smtpService = new SMTPService("sc2euro@mail.ru", "iJyw3f3seu09zhnp2rBt");  //ЛОГИН И ПАРОЛЬ ОТ SMTP СЕРВЕРА
        }


        #region Events
        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                switch (State)
                {
                    case PanelState.RegMain:
                        Wait();
                        SetState(PanelState.LoginMain);
                        break;
                    case PanelState.CantLoginMain:
                        Wait();
                        SetState(PanelState.LoginMain);
                        break;
                    default:
                        Wait();
                        SetState(PanelState.LoginMain);
                        break;
                }
            }
            catch (Exception ex)
            {
                var errorText = string.Join("\n", Array.Empty<string>().Concat(new[] { ex.Message }).Concat(new[] { ex.GetBaseException().Message }).Distinct());
                MessageBox.Show(errorText, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreateFreeAccount_Click(object sender, EventArgs e)
        {
            try
            {

                SetState(PanelState.RegMain);
            }
            catch (Exception ex)
            {
                var errorText = string.Join("\n", Array.Empty<string>().Concat(new[] { ex.Message }).Concat(new[] { ex.GetBaseException().Message }).Distinct());
                MessageBox.Show(errorText, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCantLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                SetState(PanelState.CantLoginMain);
            }
            catch (Exception ex)
            {
                var errorText = string.Join("\n", Array.Empty<string>().Concat(new[] { ex.Message }).Concat(new[] { ex.GetBaseException().Message }).Distinct());
                MessageBox.Show(errorText, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                labelWarning.Text = string.Empty;
                drawWhiteBorder(panelEmail);
                drawWhiteBorder(panelPassword);
                drawWhiteBorder(panelRepeatPassword);
                //errorImg.Visible = false;
                //errorImgPassword.Visible = false;
                //errorImgPasswordRepeat.Visible = false;
                switch (State)
                {
                    case PanelState.RegMain:
                        if (!panelCode.Visible)
                        {
                            if (CheckEmail() && CheckPassword() && CheckRepPassword())
                            {
                                panelPassword.Visible = false;
                                panelRepeatPassword.Visible = false;
                                tbEmail.Enabled = false;
                                InitVerification();
                                btnLogIn.Text = "Verify";

                                /*this.WindowState = FormWindowState.Minimized;
                                VerificationForm verificationForm = new VerificationForm(_verificationService._code, VerificationForm.FormState.FromCreatingNewAccount, tbEmail.Text);
                                if (verificationForm.ShowDialog() == DialogResult.OK)
                                {
                                    SetState(PanelState.LoginMain);
                                    this.ShowDialog();
                                    this.WindowState = FormWindowState.Normal;
                                }*/
                            }
                        }
                        else
                        {
                            if (!_verificationService.verify(tbCode.Text))
                            {
                                //errorImgPassword.Visible = true;
                                drawRedBorder(panelCode);
                                labelWarning.Text = $"The code was entered incorrectly. Attempts left: {_verificationService._attempts}";
                                if (_verificationService._attempts < 1)
                                {
                                    btnLogIn.Visible = false;
                                    panelFailed.Visible = true;

                                    timerFailed.Start();
                                }
                            }
                            else
                            {
                                btnLogIn.Visible = false;
                                panelDone.Visible = true;
                                timerDone.Start();
                            }
                        }
                        break;

                    case PanelState.CantLoginMain:
                        if (!panelCode.Visible)
                        {
                            if (CheckEmail() == true)
                            {
                                tbEmail.Enabled = false;
                                InitVerification();

                                /*this.WindowState = FormWindowState.Minimized;
                                VerificationForm verificationForm = new VerificationForm(_verificationService._code, VerificationForm.FormState.FromCantLogin, tbEmail.Text);
                                if (verificationForm.ShowDialog() == DialogResult.OK)
                                {
                                    SetState(PanelState.LoginMain);
                                    this.ShowDialog();
                                    this.WindowState = FormWindowState.Normal;
                                }*/
                            }
                        }
                        else
                        {
                            if (!_verificationService.verify(tbCode.Text))
                            {
                                //errorImgPassword.Visible = true;
                                drawRedBorder(panelCode);
                                labelWarning.Text = $"The code was entered incorrectly. Attempts left: {_verificationService._attempts}";
                                if (_verificationService._attempts < 1)
                                {
                                    btnLogIn.Visible = false;
                                    panelFailed.Visible = true;

                                    timerFailed.Start();
                                }
                            }
                            else
                            {
                                SetState(PanelState.CantLoginNewPass);
                            }
                        }
                        break;

                    case PanelState.CantLoginNewPass:
                        if (CheckPassword() && CheckRepPassword())
                        {
                            btnLogIn.Visible = false;
                            panelDone.Visible = true;
                            timerDone.Start();
                        }
                        break;

                    default:
                        if (CheckEmail() && CheckPassword())
                        {

                            btnLogIn.Enabled = btnPrevious.Enabled =
                            btnCantLogIn.Enabled = btnCreateFreeAccount.Enabled =
                            tbEmail.Enabled = tbPassword.Enabled = labelSendNewCode.Enabled = false;

                            //HideAll();

                            panelRepeatPassword.Visible = panelCode.Visible = false;
                            btnPrevious.Visible = false;

                            labelWarning.Text = string.Empty;
                            errorImg.Visible = false;
                            errorImgPassword.Visible = false;
                            errorImgPasswordRepeat.Visible = false;

                            labelEnterEmail.Visible = false;
                            //labelCodeSent.Visible = false;
                            labelSendNewCode.Visible = false;
                            labelCreatePassword.Visible = false;

                            timerCodeSent.Stop();
                            timerDone.Stop();
                            timerFailed.Stop();

                            panelDone.Visible = false;
                            panelFailed.Visible = false;

                            waitPanel.Visible = true;
                        }
                        break;
                }

                /* Микрогайд по сервисам:

						Генерация нового кода: 
							_verificationService = new VerificationService();
								*
									Код генерится в конструкторе. Нужен новый код - вызывай в конструкторе
								*
						
						
						Переменная с кодом: 
							_verificationService._code


						Проверка введенного пользователем кода:
							_verificationService.verify([Код из формы])
								*
									Возвращает true и false
								*
						

						Отправить письмо:
							_smtpService.sendEmail([Почта пользователя], [subject], [message])
								*
									Сервис создается в конструкторе, где-то в 60-х строках этого дока,
									логин и пароль от smtp-сервера уже прописаны, всё готово для того,
									чтобы просто отправлять сообщения этим методом, они доходят
								*
				*/
            }
            catch (Exception ex)
            {
                var errorText = string.Join("\n", Array.Empty<string>().Concat(new[] { ex.Message }).Concat(new[] { ex.GetBaseException().Message }).Distinct());
                MessageBox.Show(errorText, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Events

        #region Methods

        private string BuildEmailMessage(string code)
        {
            return
            $@"Dear User,

Thank you for choosing Luxmiami.

To complete your account verification, please use the following code:

Verification code: {code}

If you did not request this code, please ignore this email.

Best regards,
Luxmiami Support Team
support@luxmiami.us

Luxmiami Inc.";
        }
        private void InitVerification()
        {
            _verificationService = new VerificationService();
            if (_smtpService.SendEmail(tbEmail.Text, "Your Luxmiami Verification Code", BuildEmailMessage(_verificationService._code)) == true)
            {
                labelEnterEmail.Visible = true;
                labelEnterEmail.Text = "Enter the code sent to your email:";
                //labelCodeSent.Visible = true;
                labelSendNewCode.Visible = true;
                labelSendNewCode.Text = "Send a new code in 2:00";
                enableLabelSendNewCode(false);
                panelCode.Visible = true;
                btnLogIn.Text = "Verify";

                tbCode.Focus();
                StartCowntDown();
            }
            else
            {
                MessageBox.Show("Failed to send the code. Most likely you have problems with your Internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetState(PanelState.LoginMain);
            }
        }
        private void StartCowntDown()
        {
            _timeout = 120;
            timerCodeSent.Start();
        }
        private void SetState(PanelState state)
        {
            try
            {
                HideAll();
                switch (state)
                {
                    case PanelState.RegMain:
                        btnLogIn.Text = "Register";
                        btnLogIn.Visible = btnPrevious.Visible = panelEmail.Visible = panelPassword.Visible = panelRepeatPassword.Visible = true;
                        tbEmail.Enabled = tbPassword.Enabled = tbRepPassword.Enabled = tbCode.Enabled = true;
                        tbEmail.Focus();
                        break;
                    case PanelState.LoginMain:
                        btnLogIn.Text = "Login";
                        btnLogIn.Visible = btnCantLogIn.Visible = btnCreateFreeAccount.Visible = panelEmail.Visible = panelPassword.Visible = true;
                        tbEmail.Enabled = tbPassword.Enabled = tbRepPassword.Enabled = tbCode.Enabled = true;
                        tbEmail.Focus();
                        break;
                    case PanelState.CantLoginMain:
                        btnLogIn.Text = "Send code";
                        labelEnterEmail.Text = "Enter your email address:";
                        btnLogIn.Visible = panelEmail.Visible = btnPrevious.Visible = labelEnterEmail.Visible = true;
                        tbEmail.Enabled = tbPassword.Enabled = tbRepPassword.Enabled = tbCode.Enabled = true;
                        tbEmail.Focus();
                        break;
                    case PanelState.CantLoginNewPass:
                        btnLogIn.Text = "Reset";
                        btnLogIn.Visible = panelPassword.Visible = panelRepeatPassword.Visible = labelCreatePassword.Visible = true;
                        tbEmail.Enabled = tbPassword.Enabled = tbRepPassword.Enabled = tbCode.Enabled = true;
                        tbPassword.Focus();
                        break;
                }
                State = state;
                waitPanel.Visible = false;
            }
            catch (Exception ex)
            {
                var errorText = string.Join("\n", Array.Empty<string>().Concat(new[] { ex.Message }).Concat(new[] { ex.GetBaseException().Message }).Distinct());
                MessageBox.Show(errorText, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Wait()
        {
            HideAll();
            waitPanel.Visible = true;
        }

        private void HideAll()
        {
            tbEmail.Text = tbPassword.Text = tbRepPassword.Text = tbCode.Text = string.Empty;
            panelEmail.Visible = panelPassword.Visible = panelRepeatPassword.Visible = panelCode.Visible = false;

            btnCantLogIn.Visible = btnCreateFreeAccount.Visible = false;
            btnPrevious.Visible = false;

            labelWarning.Text = string.Empty;
            errorImg.Visible = false;
            errorImgPassword.Visible = false;
            errorImgPasswordRepeat.Visible = false;
            btnLogIn.Visible = false;

            labelEnterEmail.Visible = false;
            labelCodeSent.Visible = false;
            labelSendNewCode.Visible = false;
            labelCreatePassword.Visible = false;

            enableLabelSendNewCode(false);

            timerCodeSent.Stop();
            timerDone.Stop();
            timerFailed.Stop();

            panelDone.Visible = false;
            panelFailed.Visible = false;
        }
        private bool CheckEmail()
        {
            try
            {
                string email = tbEmail.Text;
                if (IsValidEmail(email) && !string.IsNullOrEmpty(email))
                {
                    errorImg.Visible = false;
                    return true;
                }
                else
                {
                    //errorImg.Visible = true;
                    drawRedBorder(panelEmail);
                    tbEmail.Focus();
                    toolTip1.SetToolTip(errorImg, "Error");
                    toolTip1.ToolTipTitle = "Invalid Email Address";
                    toolTip1.ForeColor = Color.Red;
                    labelWarning.Text = "Email entered incorrectly!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                var errorText = string.Join("\n", Array.Empty<string>().Concat(new[] { ex.Message }).Concat(new[] { ex.GetBaseException().Message }).Distinct());
                MessageBox.Show(errorText, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidEmail(string email)
        {
            // Регулярное выражение для валидации email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Или вот такой: (\w|[.\-])+@(\w|[\-]+.)*(\w|[\-]){2,63}.[a-zA-Z]{2,4}
            return Regex.IsMatch(email, pattern);
        }

        private bool CheckPassword()
        {
            string password = tbPassword.Text;
            if (password != null && password.Length > 5)
            {
                errorImgPassword.Visible = false;
                return true;
            }
            else
            {
                //errorImgPassword.Visible = true;
                drawRedBorder(panelPassword);
                tbPassword.Focus();
                toolTip1.SetToolTip(errorImg, "Error");
                toolTip1.ToolTipTitle = "Password must contain at least 6 symbols!";
                toolTip1.ForeColor = Color.Red;
                labelWarning.Text = "Password must contain at least 6 symbols!";
                return false;
            }
        }

        private bool CheckRepPassword()
        {
            string password = tbPassword.Text;
            string repPassword = tbRepPassword.Text;
            if (repPassword.Equals(password))
            {
                errorImgPasswordRepeat.Visible = false;
                return true;
            }
            else
            {
                //errorImgPasswordRepeat.Visible = true;
                drawRedBorder(panelRepeatPassword);
                tbRepPassword.Focus();
                toolTip1.SetToolTip(errorImg, "Error");
                toolTip1.ToolTipTitle = "Passwords missmatch!";
                toolTip1.ForeColor = Color.Red;
                labelWarning.Text = "Passwords missmatch!";
                return false;
            }
        }

        private void drawRedBorder(Panel panel)
        {
            int thickness = 1;//it's up to you
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.Red, thickness))
            {
                panel.CreateGraphics().DrawRectangle(p, new Rectangle(halfThickness,
                                                            halfThickness,
                                                            panel.ClientSize.Width - thickness,
                                                            panel.ClientSize.Height - thickness));
            }
        }

        private void drawWhiteBorder(Panel panel)
        {
            int thickness = 4;//it's up to you
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.White, thickness))
            {
                panel.CreateGraphics().DrawRectangle(p, new Rectangle(halfThickness,
                                                            halfThickness,
                                                            panel.ClientSize.Width - thickness,
                                                            panel.ClientSize.Height - thickness));
            }
        }

        #endregion Methods

        private void AuthForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }
        private void VerificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox21_Click_1(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void tbRepPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void tbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }


        private void timerCodeSent_Tick(object sender, EventArgs e)
        {
            _timeout--;
            if (_timeout > 0)
            {
                bool b = labelSendNewCode.Enabled;
                var t = TimeSpan.FromSeconds(_timeout);
                string time = t.Seconds > 9 ? $"{t.Minutes}:{t.Seconds}" : $"{t.Minutes}:0{t.Seconds}";
                //labelCodeSent.Text = $"The code sent to your email. New code in {time}";
                labelSendNewCode.Text = $"Send a new code in {time}";
            }
            else
            {
                timerCodeSent.Stop();
                //labelCodeSent.Text = $"The code sent to your email.";
                //labelSendNewCode.Enabled = true;
                enableLabelSendNewCode(true);
                labelSendNewCode.Text = "Click to send a new code";
            }
        }

        bool labelSendNewCodeEnabled = false;
        private void enableLabelSendNewCode(bool b)
        {
            if (b)
            {
                labelSendNewCode.ForeColor = Color.FromArgb(255, 178, 97);
                labelSendNewCode.Cursor = Cursors.Hand;
            }
            else
            {
                labelSendNewCode.ForeColor = Color.Gray;
                labelSendNewCode.Cursor = Cursors.Default;
            }
            labelSendNewCodeEnabled = b;
        }

        private void labelSendNewCode_Click(object sender, EventArgs e)
        {
            if (labelSendNewCodeEnabled)
            {
                labelWarning.Text = string.Empty;
                errorImg.Visible = false;
                errorImgPassword.Visible = false;
                errorImgPasswordRepeat.Visible = false;
                InitVerification();
            }
        }

        private void timerDone_Tick(object sender, EventArgs e)
        {
            SetState(PanelState.LoginMain);
        }

        private void timerFailed_Tick(object sender, EventArgs e)
        {
            SetState(PanelState.LoginMain);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(Pens.Blue, borderRectangle);
            base.OnPaint(e);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {


        }

        private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}