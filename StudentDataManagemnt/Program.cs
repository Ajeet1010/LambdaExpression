using System.Security.Cryptography.X509Certificates;

namespace StudentDataManagemnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Fetch Student Data using LAMBDA Expression  *****");
            // Collection Initialiser
            List<StudentData> list = new List<StudentData>()
            {
                // object initialiser
                new StudentData() { Id = 1, Name = "Ajeet", Age = 23, Address = "Delhi", PhoneNo = 827972945},
                new StudentData() { Id = 2, Name = "Ritesh", Age = 24, Address = "Delhi", PhoneNo = 82797294},
                new StudentData() { Id = 3, Name = "Manish", Age = 25, Address = "Patna", PhoneNo = 8279729},
                new StudentData() { Id = 4, Name = "Umang", Age = 22, Address = "Banda", PhoneNo = 827972},
                new StudentData() { Id = 5, Name = "Praveen", Age = 23, Address = "Delhi", PhoneNo = 82797},
                new StudentData() { Id = 6, Name = "Alok", Age = 27, Address = "NCR", PhoneNo = 8279},
                new StudentData() { Id = 7, Name = "Ankit", Age = 25, Address = "Noida", PhoneNo = 827}
            };
            // display student data
            DisplayStudentData(list);
            
        }

        // program for display StudentData 
        public static void DisplayStudentData(List<StudentData> list)
        {
            foreach (StudentData display in list)
            {
                Console.Write(display + "\n");
            }
        }
    }
}