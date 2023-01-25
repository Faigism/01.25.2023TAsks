using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

namespace HomeTask01._25._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.- Verilmiş yazıda rəqəm olub olmadığını tapan metod
            Console.WriteLine(IsDigit("Faiq"));

            //2.- Verilmiş yazının fullname olub olmadığını tapan metod (fullname olması üçün iki sozdən ibarət olmalıdır və
            //hər bir söz böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)
            string name = "faiq ismayilov";
            Console.WriteLine((name));

            //3. - Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.
            int[] numbers = { 2, 4, 23, 45, 23, 10 };
            int[] num =newArr(numbers);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            //4. - Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.Domainlər arrayondə təkrarlanmamlıdır domainlər!
            string[] emails = { "ruslan@gmail.com", "aydin123@code.edu.az", "Elvin77@mail.ru", "aydin123@code.edu.az" };
            var newsDomain=stringArr(emails);
            for (int i = 0; i < newsDomain.Length; i++)
            {
                Console.WriteLine(newsDomain[i]);
            }

            //5.- Verilmiş yazının içindəki cümlələrin sayını tapan metod.
            string Words = "Salam necesen. Sagol yaxsiyam. Sen necesen";
            int count=countWord(Words);
            Console.WriteLine(count);
        }
        static bool IsDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }
            return false;
        //}
        //static bool fullName(string str)
        //{
        //    str= str.Trim();
        //    if(string.IsNullOrEmpty(str)) 
        //        return false;
        //    var newStr=new string(str);
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (!(char.IsUpper(newStr[0]) && str.IndexOf(' ', char.IsUpper(newStr[0])))
        //            return false;
        //    }
        }
        static int[] newArr(int[] arr)
        {
            int[] newArr =new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr,newArr.Length+1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }
            return newArr;
        }
        static string[] stringArr(string[] str)
        {
            string[] news=new string[0];
            for (int i = 0; i < str.Length; i++)
            {
                var domain = str[i].Substring(str[i].IndexOf('@')+1);
                if (Array.IndexOf(news, domain) == -1)
                {
                    Array.Resize(ref news,news.Length+1);
                    news[news.Length - 1] = domain;
                }
            }
            return news;
        }
        static int countWord(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var sentence = word.Split('.');
                count++;
            }
            return count;
        }
    }
}
