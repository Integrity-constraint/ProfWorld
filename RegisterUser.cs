using ProfWorld.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProfWorld
{
    public class RegisterUser
    {
       public  string Mail { get; set; }
       public   string Login { get; set; }
       public  string pass { get; set; }

        

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

       
       
        public void Register(string mail,string login)
        {


            Mail = mail;
            Login = login;
            pass = GeneratePassword();
           string mymail = "profworldnoreply@gmail.com";
           string mypas = "zrwi cgcq mddj uapg ";

            MessageBox.Show("Введите временный пароль на вашей почте");

           
           using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {

                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mymail,mypas);
                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(Mail);
                msgObj.From = new MailAddress(mymail);
                msgObj.Subject = "Мир профессий 2024!";
                msgObj.Body = $"Здравствуйте {Login} вы приглашены на участие! Учтите, что регистрация временная, после закрытия приложения все данные будут стёрты" +
                    $"Ваш временны пароль: {pass}";
                smtpClient.Send(msgObj);
               
            }
        }
    }
}
