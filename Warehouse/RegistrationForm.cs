using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class RegistrationForm : Form
    {
        /// <summary>
        /// Почта.
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string ClientName { get; private set; }
        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string Phone { get; private set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; private set; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string FatherName { get; private set; }
        /// <summary>
        /// Список уже зарегистрированных клиентов.
        /// </summary>
        List<Client> Clients;
        public RegistrationForm(List<Client> clients, string MainLable = "Регистрация нового покупателя")
        {
            InitializeComponent();
            Clients = clients;
            this.Text = MainLable;
        }

        /// <summary>
        /// Отправление формы.
        /// </summary>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Check())
                {
                    return;
                }
                if(Clients.Any(x=> x.Email == this.Email)){
                    MessageBox.Show("Данный e-mail уже зарегистрирован.");
                }
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Не удалось зарегистрировать пользоваетля.");
            }
        }

        /// <summary>
        /// Проверка заполнения полей формы.
        /// </summary>
        /// <returns>Возращает false, если поля заполнены не верно.</returns>
        private bool Check()
        {
            if (EmailText.Text.Length <= 0 || !EmailText.Text.Contains('@'))
            {
                MessageBox.Show("E-mail - должен быть непустой строкой, содержащей \"@\"");
                return false;
            }
            else
            {
                Email = EmailText.Text;
            }
            if (PasswordText.Text.Length <= 0 || NameText.Text.Length <= 0 || LastNameText.Text.Length <= 0 
                || FatherNameText.Text.Length <= 0)
            {
                MessageBox.Show("Пароль, имя, фамилия и отчество не могут быть пустыми строками.");
                return false;
            }
            else
            {
                Password = PasswordText.Text;
                ClientName = NameText.Text;
                LastName = LastNameText.Text;
                FatherName = FatherNameText.Text;
            }
            if (!PhoneText.MaskCompleted)
            {
                MessageBox.Show("Неправильно введен номер телефона.");
                return false;
            }
            else
            {
                Phone = PhoneText.Text;
            }
            return true;
        }

        /// <summary>
        /// Нажатие кнопки отмены на форме.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
