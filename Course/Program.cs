using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-- MENU --");
                Console.WriteLine("1. Qrup elave et");
                Console.WriteLine("2. Qruplari gor");
                Console.WriteLine("3. Qrupa telebe elave et");
                Console.WriteLine("4. Kursdaki telebelerin siyahisi");
                Console.WriteLine("5. Qrupdaki telebelerin siyahisi");
                Console.WriteLine("6. Telebeler uzre axtarish");
                Console.WriteLine("7. Qrupdan telebeni sil");
                Console.WriteLine("8. Qrupdaki telebeni redakt et");
                Console.WriteLine("0. Exit");

                Course course = new Course("Code Academy");

                string input = Console.ReadLine();
                int result;
                bool isSucceded = int.TryParse(input, out result);
                if (isSucceded)
                {
                    switch (result)
                    {
                        case (int)Operations.AddGroup:
                            string name = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(name) && name.Length > 2)
                            {
                                if (!course.Groups.Any(g => g.Name == name))
                                {
                                    course.AddGroup(new Group(name));
                                    Console.WriteLine("Qrup ugurla elave olundu");
                                }
                                else
                                    Console.WriteLine("Bu qrup artuq movcuddur");
                            }
                            else
                                Console.WriteLine("Daxil edilem duzgun formatda deyil, zehmet olmasa yeniden daxil edin");
                            break;
                        default:
                            break;
                    }
                }
                else
                    goto MENU;
            }
        }
    }
}