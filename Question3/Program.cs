using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Question3.Program;

namespace Question3
{

    internal class Program
    {
        static List<medalist> medalists;
        public class medalist
        {
            public string Name { get; set; }
            public string Year { get; set; }
            public string GoldMedal { get; set; }
            public string SilverMedal { get; set; }
            public string BronzeMedal { get; set; }

            public override string ToString()
            {
                return $" Name: {Name} Year: {Year} \n Gold: {GoldMedal} Silver: {SilverMedal} Bronze: {BronzeMedal} \n\n";
            }
            
        }
        public static List<medalist> CreateList()
        {
            string PATH = @"E:\College\Semester 4\COMP212_C#\Assignments\301271921(Abhishek)_Lab1\Medals - Greatest Gold Medalist.csv";
            List<medalist> medalists = new List<medalist>();
            var medals = File.ReadAllLines(PATH);
            foreach (var medal in medals)
            {
                var values = medal.Split(',');
                var medalist = new medalist
                {
                    Name = values[0],
                    Year = values[1],
                    GoldMedal = values[2],
                    SilverMedal = values[3],
                    BronzeMedal = values[4],
                };
                medalists.Add(medalist);
            }
            return medalists;
        }
       public static void addMedalist(List<medalist> a ,string Athlete, string Year, string Gold, string Silver, string Bronze)
        {
            a.Add(
                new medalist
                {
                    Name = Athlete,
                    Year = Year,
                    GoldMedal = Gold,
                    SilverMedal = Silver,
                    BronzeMedal = Bronze
                });
        }
        public static void deleteData(List<medalist> a, string Name)
        {
            for (int i = 0; i < a.Count; i++)
            {
                var medalist = a[i];
                if (medalist.Name == Name)
                {
                    a.RemoveAt(i);
                }
            }
            
        }
        public static void displayList(List<medalist> a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void searchItem (IEnumerable <medalist> a ,String searchKey)
        {
            var searchedMedalist = new List<medalist>() ; 
            foreach (var item in a)
            {
                if(item.Name.Contains(searchKey))
                {
                    searchedMedalist.Add(item);
                }
                else if (item.Year == searchKey)
                {
                    searchedMedalist.Add(item);
                }
                else if (item.GoldMedal == searchKey)
                {
                    searchedMedalist.Add(item);
                }
                else if(item.SilverMedal == searchKey)
                {
                    searchedMedalist.Add(item);
                }
                else if(item.BronzeMedal == searchKey)
                {
                    searchedMedalist.Add(item);
                }
            }
            foreach(var item in searchedMedalist)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<medalist>  a = CreateList();
            Console.WriteLine("Displaying the List");
            displayList(a);
            Console.WriteLine("____Adding a New Medalist and Displaying List__");
            addMedalist(a,"Abhishek", "2002", "2", "1", "3");
            displayList(a);
            Console.WriteLine("_____Deleting the added medalist");
            deleteData(a, "Abhishek");
            displayList(a);
            Console.WriteLine("________Searching the Medalists with 3 Medals______");
            searchItem(a, "3");
            
        }
    }
}

