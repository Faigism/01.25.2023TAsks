using System;

namespace ClasstaskPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazının ad olub olmadığını tapan metod.Yazı addırsa böyük həriflə başlamalı və kiçik həriflərlə davam etməlidir.
            //    Console.WriteLine(ChangeName("Faiq"));
            //}
            //static bool ChangeName(string name)
            //{
            //    if (string.IsNullOrWhiteSpace(name))
            //        return false;
            //    if (!char.IsUpper(name[0]))
            //        return false;

            //    for (int i = 1; i < name.Length; i++)
            //    {
            //        if (!char.IsLower(name[i]))
            //            return false;

            //    }

            //    return true;
            //................................................................................................................

            //Verilmiş fullname siyahısından names siyahısı düzəldib qaytaran metod
            //    string[] fullnames = { "  Faiq    Ismayilov"  ,   "Zakir Hesenov",   "Aydin  Nuruyev" };
            //    var names=MakeArr(fullnames);
            //    for (int i = 0; i < names.Length; i++)
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}
            //static string[] MakeArr(string[] arr)
            //{
            //    string[] newNames=new string[arr.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = arr[i].Trim();
            //        newNames[i] = arr[i].Substring(0, arr[i].IndexOf(' '));
            //    }
            //    return newNames;
            //................................................................................................................

            //Verilmiş string array-nin içərisindəki təkrarlanmayan dəyərlərdən ibaret yeni bir array qaytaran metod
            //    string[] name = { "alma", "armud", "alma", "heyva","alma","alma","armud","nar" };
            //    var newArr=Name2(name);
            //    for (int i = 0; i < newArr.Length; i++)
            //    {
            //        Console.WriteLine(newArr[i]);
            //    }

            //}
            //static string[] Name2(string[] name)
            //{
            //    string[] newNames =new string[0];
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        if (Array.IndexOf(newNames, name[i])==-1)
            //        {
            //            Array.Resize(ref newNames, newNames.Length + 1);
            //            newNames[newNames.Length - 1] = name[i];
            //        }
            //    }
            //    return newNames;
            //................................................................................................................

            //Verilmiş yazını baş hərifi böyük digərləri kiçik halda qaytaran metod
            //    var name = MakeName("fAiQ");
            //    Console.WriteLine(name);
            //}
            //static string MakeName(string str)
            //{
            //    return char.ToUpper(str[0]) + str.Substring(1).ToLower();
            //................................................................................................................

            //Consolda email daxil edilsin @ simvolu yoxdursa yenidən daxil edilsin
            //string email;
            //do
            //{
            //    Console.WriteLine("Emaili daxil edin:");
            //    email = Console.ReadLine();
            //} while (!email.Contains('@'));
            //................................................................................................................

            //İçərisinə string daxil edim mənə domein hissəni kəsib qaytarsın
            //    string name;
            //    do
            //    {
            //        Console.WriteLine("Emaili daxil edin:");
            //        name = Console.ReadLine();
            //    } while (!name.Contains('@'));
            //    Console.WriteLine(getDomein(name));
            //}
            //static string getDomein(string email)
            //{
            //    var atIndex = email.IndexOf('@');
            //    var domain = email.Substring(email.IndexOf('@') + 1);
            //    return domain;
            //................................................................................................................
        }
    }
}
