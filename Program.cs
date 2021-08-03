using System;
using System.Text;
using System.Text.RegularExpressions;

namespace BT01_CreateConsoleWithPublish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string choice;
            do
            {
                Console.WriteLine("Mập thương em nhiều hk nè?");
                Console.WriteLine("1.Thương");
                Console.WriteLine("2.Cực thương");
                Console.WriteLine("3.Rất rất thương");
                Console.WriteLine("4.Thương em cực nhiều");
                Console.WriteLine("5.Lời nói thầm kín");
                Console.WriteLine("6.Thoát");

                bool checkChoice;
               
                do
                {
                    Console.Write("Chọn 1 số để tiếp tục: ");
                    choice = Console.ReadLine();
                    checkChoice = Regex.Match(choice, @"^[1-6]{1}$").Success;
                    if (choice.Equals("6"))
                    {
                        Environment.Exit(0);
                    }
                    if (checkChoice == false) 
                    {
                        Console.WriteLine("Phải nhập số (1->6)!!! Thử lại.");
                        checkChoice = false;
                    }
                } 
                while (checkChoice == false);

                
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Em cũng thương mập :3");
                        timYeuThuong();
                        break;
                    case "2":
                        Console.WriteLine("Em cực thương mập luôn :33");
                        timYeuThuong();
                        break;
                    case "3":
                        Console.WriteLine("Em rất rất chi là thương mập nè :333");
                        timYeuThuong();
                        break;
                    case "4":
                        Console.WriteLine("Em thương mập cực kỳ nhiều luôn :3333");
                        timYeuThuong();
                        break;
                    case "5":
                        Console.WriteLine("♥♥♥Anh là người tuyệt vời nhất♥♥♥");
                        Console.WriteLine("Em yêu anh nhiều lắm :3333333");
                        timYeuThuong();
                        break;
                }
            }
            while (choice.Equals("1") || choice.Equals("2") || choice.Equals("3") || choice.Equals("4") || choice.Equals("5"));
         
        }

        public static void timYeuThuong()
        {
            Console.WriteLine("───(♥)(♥)(♥)────(♥)(♥)(♥)──"); 
            Console.WriteLine("──(♥)██████(♥)(♥)██████(♥)─"); 
            Console.WriteLine("─(♥)████████(♥)████████(♥)─"); 
            Console.WriteLine("─(♥)██████████████████(♥)─"); 
            Console.WriteLine("──(♥)████████████████(♥)──"); 
            Console.WriteLine("────(♥)████████████(♥)────"); 
            Console.WriteLine("──────(♥)████████(♥)──────"); 
            Console.WriteLine("────────(♥)████(♥)────────"); 
            Console.WriteLine("─────────(♥)██(♥)─────────"); 
            Console.WriteLine("───────────(♥)───────────"); 
        }
    }
}
