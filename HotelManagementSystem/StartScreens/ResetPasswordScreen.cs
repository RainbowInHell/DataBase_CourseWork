using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.StartScreens
{
    public partial class ResetPasswordScreen : Form
    {
        private readonly MailAddress _fromAddress = new MailAddress("vincenakavega@gmail.com");
        private MailMessage _mailMessage;
        private MailAddress _toAddress;
        private SmtpClient _smtp;
        private HotelDbContext _context;
        private Employee _tempEmployee;
        private UserLoginScreen _userLoginScreen;

        private readonly string _fromPassword = "ngcbtjwygakpxxqj";
        private readonly string _subject = "Confirmation code";
        private readonly string _body;

        public ResetPasswordScreen()
        {
            InitializeComponent();
        }

        public ResetPasswordScreen(HotelDbContext _context) : this()
        {
            this._context = _context;
            _body = RandomString();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context.Database.EnsureCreated();
            _context.Employees.Load();
        }


        private void sendCodeButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(loginField.Texts, emailAdresField.Texts, newPasswordField.Texts, newPasswordConfirmField.Texts))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempEmployee = _context.Employees.AsNoTracking().FirstOrDefault(empl => empl.EmployeeLogin == loginField.Texts && empl.EmployeeEmailAddress == emailAdresField.Texts);
            if (_tempEmployee == null)
            {
                MessageBox.Show($"Отсутствует работник с логином = {loginField.Texts} и почтовым адресом {emailAdresField.Texts}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _toAddress = new MailAddress(emailAdresField.Texts);

            using (_smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_fromAddress.Address, _fromPassword)
            })

            using (_mailMessage = new MailMessage(_fromAddress, _toAddress)
            {
                Subject = _subject,
                Body = _body
            })

                _smtp.Send(_mailMessage);
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (!codeField.Texts.SequenceEqual(_body))
            {
                MessageBox.Show($"Неверный код.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Пароль изменен.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

            _userLoginScreen = new UserLoginScreen();
            _userLoginScreen.Show();
        }

        private string RandomString(int size = 10)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
