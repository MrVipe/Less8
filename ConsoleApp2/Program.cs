using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string company = ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(
            Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false))
           .Company;

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Console.WriteLine($"{company} version {version}");

            Console.WriteLine($"Привет {les8.Properties.Settings.Default.nameUser}");
            Console.WriteLine($"Ваши данные: Возраст - {les8.Properties.Settings.Default.ageUser}, Род деятельности - {les8.Properties.Settings.Default.doUser}");
            Console.WriteLine("Хотите уточнить свою данные y/n?");

            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Назовите себя:");
                les8.Properties.Settings.Default.nameUser = Console.ReadLine();
                Console.WriteLine("Ваш возраст:");
                les8.Properties.Settings.Default.ageUser =  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш род деятельности:");
                les8.Properties.Settings.Default.doUser = Console.ReadLine();
                les8.Properties.Settings.Default.Save();

            }
            Console.ReadKey();
        }
    }
}
