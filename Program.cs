using System;
using System.Collections.Generic;


namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int idx = 0; idx < numArray1.Length; idx++)
            {
                Console.WriteLine($"{numArray1[idx]}");
            }

            string[] nameArray1 = { "Tim", "Martin", "Nikki", "Sara" };
            for (int idx = 0; idx < nameArray1.Length; idx++)
            {
                Console.WriteLine($"{nameArray1[idx]}");
            }

            bool[] boolArray1 = { true, false, true, false, true, false, true, false, true, false };
            for (int idx = 0; idx < boolArray1.Length; idx++)
            {
                Console.WriteLine($"{boolArray1[idx]}");
            }

            // ==========================================
            Console.WriteLine("==============================");

            List<string> flavors = new List<string>();
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("cookies and cream");
            flavors.Add("espresso");
            flavors.Add("birthday cake");

            Console.WriteLine("My favorite ice cream flavors are:");
            for (var idx = 0; idx < flavors.Count; idx++)
            {
                Console.WriteLine("-" + flavors[idx]);
            }
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // ==========================================
            Console.WriteLine("==============================");

            Dictionary<string,string> dict1 = new Dictionary<string,string>();
            dict1.Add("Tim", "Chocolate");
            dict1.Add("Martin", "Vanilla");
            dict1.Add("Nikki", "Espresso");
            dict1.Add("Sara", "Birthday Cake");
            foreach (KeyValuePair<string, string> entry in dict1)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
