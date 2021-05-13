using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
        public int Password;// { get; private set; }

        public Client (string email,string name, string lastName, string fatherName,string phone,int password)
        {
            Email = email;
            Name = name;
            LastName = lastName;
            FatherName = fatherName;
            Phone = phone;
            Password = password;
        }
        public static int GetHashPassword(string password,string name)
        {
            var coder = SHA256.Create();
            var str = password + name;
            byte[] bytes=new byte[str.Length];
            for(var i=0;i< str.Length;i++)
            {
                bytes[i] = (byte)str[i];
            }

            return BitConverter.ToInt32( coder.ComputeHash(bytes));
            
            //return coder.ComputeHash(Encoding.Default.GetBytes(str));
        }
    }
}
