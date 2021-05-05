using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    [Serializable]
    public class Client
    {
        /// <summary>
        /// Почта.
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; private set; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string FatherName { get; private set; }
        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string Phone { get; private set; }
        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; private set; }

        public Client (string email,string name, string lastName, string fatherName,string phone,string password)
        {
            Email = email;
            Name = name;
            LastName = lastName;
            FatherName = fatherName;
            Phone = phone;
            Password = password;
        }
    }
}
