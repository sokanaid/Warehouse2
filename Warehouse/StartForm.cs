using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class StartForm : Form
    {
        /// <summary>
        /// Список зарегистрированных покупателей.
        /// </summary>
        public List<Client> Clients = new List<Client>();//{ new Client("1", "1", "1", "1", "1", "1") };
        /// <summary>
        /// Список зарегистрированных продавцы.
        /// </summary>
        public List<Client> Sellers = new List<Client>();// { new Client("1", "1", "1", "1", "1", "1") };
        /// <summary>
        /// Путь к текущему складу.
        /// </summary>
        public string WarehousePath = Path.Combine("warehouses","1.bin");
        /// <summary>
        /// Текущий клиент.
        /// </summary>
        public Client CurrentClient;
        public StartForm()
        {
            InitializeComponent();
            try
            {
                Sellers = Deserialise(Path.Combine("warehouses", "Sellers.bin"));
            }
            catch
            {
                MessageBox.Show("Не удалось востановить список продавцов");
                Sellers = new List<Client>();
            }
            try
            {
                Clients = Deserialise(Path.Combine("warehouses", "Clients.bin"));
            }
            catch
            {
                MessageBox.Show("Не удалось востановить список покупателей");
                Clients = new List<Client>();
            }
        }

        /// <summary>
        /// Десeриализация пользователей.
        /// </summary>
        /// <param name="file">имя файла.</param>
        /// <returns>Список пользователей.</returns>
        private List<Client> Deserialise(string file)
        {
            var ser = new BinaryFormatter();
            using (var input = new FileStream(file,FileMode.OpenOrCreate)) {
                return (List<Client>)ser.Deserialize(input);
            }
        }
        /// <summary>
        /// Сериализация пользователей.
        /// </summary>
        /// <param name="file">Имя файла.</param>
        /// <param name="clients">Список клиентов.</param>
        private void Serialise(string file, List<Client> clients)
        {
            var ser = new BinaryFormatter();
            using (var input = new FileStream(file, FileMode.OpenOrCreate))
            {
                ser.Serialize(input,clients);
            }
        }
        /// <summary>
        /// Вход в программу.
        /// </summary>
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (RadioButCustAvt.Checked)
            {
                try
                {

                    Client currentClient = Clients.Find(x => x.Email == Login.Text && x.Password == Password.Text);
                    if (currentClient is null) throw new Exception();
                    // Начало работы с программой в качестве покупателя.
                    StartWorkWithCostumer(currentClient);
                }
                catch
                {
                    MessageBox.Show("Неверный пароль или логин. Попробуйте ввести еще раз или зарегистрируйте нового пользователя.");
                }
            }
            else
            {
                try
                {

                    Client currentSeller = Sellers.Find(x => x.Email == Login.Text && x.Password == Password.Text);
                    if (currentSeller is null) throw new Exception();
                    // Начало работы с программой в качестве продавца.
                    StartWorkWithSeller(currentSeller);
                }
                catch
                {
                    MessageBox.Show("Неверный пароль или логин. Попробуйте ввести еще раз или зарегистрируйте нового пользователя.");
                }
            }
        }

        /// <summary>
        /// Начало работы с программой в качестве продавца.
        /// </summary>
        /// <param name="currentSeller">Продавец.</param>
        private void StartWorkWithSeller(Client currentSeller)
        {
            try
            {
                CurrentClient = currentSeller;
                this.Visible = false;
                var form = new SellerForm(this.WarehousePath)
                {
                    MainForm = this
                };
                form.Show();

            }
            catch
            {
                MessageBox.Show("Программа завершилась некорректно.");
            }
        }

        /// <summary>
        /// Начало работы с программой в качестве покупателя.
        /// </summary>
        /// <param name="currentSeller">Покупатель.</param>
        private void StartWorkWithCostumer(Client currentClient)
        {
            try
            {
                CurrentClient = currentClient;
                this.Visible = false;
                CustomerForm form = new CustomerForm(WarehousePath);
                form.MainForm = this;
                form.Show();

            }
            catch
            {
                MessageBox.Show("Программа завершилась некорректно.");
            }
        }

        /// <summary>
        /// Регистрация нового клиента.
        /// </summary>
        private void ButtonRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                Client client;
                if (RadioButCustAvt.Checked)
                {
                    var dialog = new RegistrationForm(Clients);
                    if (dialog.ShowDialog() != DialogResult.Cancel)
                    {
                        client = new Client(dialog.Email, dialog.ClientName, dialog.LastName, dialog.FatherName,
                            dialog.Phone, dialog.Password);
                        Clients.Add(client);
                        StartWorkWithCostumer(client);
                    }
                }
                else
                {
                    var dialog = new RegistrationForm(Sellers, "Регистрация нового продавца");
                    if (dialog.ShowDialog() != DialogResult.Cancel)
                    {
                        client = new Client(dialog.Email, dialog.ClientName, dialog.LastName, dialog.FatherName,
                            dialog.Phone, dialog.Password);
                        Sellers.Add(client);
                        StartWorkWithSeller(client);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось зарегистровать нового клиента");
            }
        }

        /// <summary>
        /// Сохранение списка пользователей.
        /// </summary>
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Serialise(Path.Combine("warehouses","Sellers.bin"), Sellers );
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить список продавцов");
            }
            try
            {
                Serialise(Path.Combine("warehouses", "Clients.bin"), Clients);
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить список покупателей");
            }
        }
    }
}
