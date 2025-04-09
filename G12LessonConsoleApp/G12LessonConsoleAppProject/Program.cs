
using G12LessonConsoleAppProject;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {

        // string 2 xil bolarkan
        // 1 immutable bu o'zimizi oddiy string => 
        // 2 - mutable string bu StringBuilder
        string value = " sfasdfasdf data tes data asasdf asdf";

        string[] values = ["asdad", "ddadsas", "bsdadas"];

        Array.Sort(values);

        foreach (string item in values)
        {
            Console.WriteLine(item);
        }

        int[] raqamlar = new int[5];
 
        var myArray = Array.CreateInstance(typeof(int), 5);



        //string[] malumot = value.Split(" ");


        var data = new string(value.Concat(" data").ToArray());


       
        //foreach (string s in malumot) 
        //{
            
        //        Console.WriteLine(s);
        //}

        

        //int counter = 0;
        //for(int i = 0;  i <= malumot.Length - 5; i++)
        //{
        //    if(malumot.Substring(i, 5) == "hello") counter++;

        //}

        //var data = malumot.Split(" ");

        //string[] malumotlar = { "asdas", "asdadsas", "aadsas" };


    }

    

}