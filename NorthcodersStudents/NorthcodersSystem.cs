using System.Text.Json;

namespace NorthcodersStudents
{
    internal class NorthcodersSystem
    {

        static List<NorthcodersStudent> student = new List<NorthcodersStudent>();
        static void Main(string[] args)
        {

            string json = "{ \"Name\": \"Evie Pom\", \"YearsCoding\": 6, \"IsDebugging\": false, \"CodingAffiliation\" : \"Poms Who Code\"}";

            NorthcodersStudent? jason = JsonSerializer.Deserialize<NorthcodersStudent>(json);

            Console.WriteLine(jason.Name);


        }
    }
}
