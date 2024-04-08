using ProfWorld.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProfWorld
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        string mymail = "profworldnoreply@gmail.com";
        string mypas = "zrwi cgcq mddj uapg ";
        public RegisterWindow()
        {
            InitializeComponent();


        }

        public string Mail { get; set; }
        public string pass { get; set; }
        public string Login { get; set; }

        public string GeneratePassword()
        {
            int length = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
           
           
            Register();
           
            EnterWindows enter = new EnterWindows();
            this.Close();
            enter.Show();
            
        }
        public void Register()
        {
            DataBank.password = GeneratePassword();
            DataBank.login = tblogin.Text;
            Mail = tbmail.Text;
           

            MessageBox.Show("Введите временный пароль на вашей почте");


            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {

                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mymail, mypas);
                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(Mail);
                msgObj.From = new MailAddress(mymail);
                msgObj.Subject = "Мир профессий 2024!";
                msgObj.Body = $"Здравствуйте {DataBank.login} вы приглашены на участие! Учтите, что регистрация временная, после закрытия приложения все данные будут стёрты." +
                    $" Ваш временный пароль: {DataBank.password}";
                smtpClient.Send(msgObj);

            }
        }

       
        private void Questionmark(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Если вы не видите письма с паролем на вашей почте, обязательно загляните в пункт СПАМ");
        }
    }
}
