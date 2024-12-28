using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2Q1
{

    struct Student
    {

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool gender;

        public  bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int std;

         public int Std
        {
            get { return std; }
            set { std = value; }
        }

        private char div;

        public char Div
        {
            get { return div; }
            set { div = value; }
        }

        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }


        public void AcceptDetails()
        {
            Console.WriteLine("Enter the student name :");
            Name= Console.ReadLine();
            Console.WriteLine("Enter the  Gender");
            Gender =Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter the age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter teh std");
            Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the div");
            Div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter thr marks ");
            Marks= Convert.ToDouble(Console.ReadLine());
    
        }

        public void DisplayDetails()
        {
            Console.WriteLine("name"+Name);
            Console.WriteLine("Gender " + Gender);
            Console.WriteLine("Age" +Age);
            Console.WriteLine("Std "+Std);
            Console.WriteLine("div "+Div);
            Console.WriteLine("marks "+Marks);
        }

    }




    internal class Program
    {



        public static int CreateArray()
        {
            Console.WriteLine("Enter the ArraySize");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public static void AcceptInfo(int n, Student[] std)
        {
            for (int i = 0; i < n; i++) {

                //Console.WriteLine(std[i]);
                std[i].AcceptDetails();
            }
        }


        public  static void DisplayInfo( int n, Student[] std)
        {
            for (int i = 0; i < n; i++)
            {
                std[i].DisplayDetails();

            }

        }

        public static void ReverseArray(int n, Student[] std)
        {
         
           
            for (int i = n; i>0; i--)
            {
                std[i].DisplayDetails();
        }
          


        }




        static void Main(string[] args)
        {

            //Student std=new Student();


            //std.AcceptDetails();
            //std.DisplayDetails();

            

            

        int n=CreateArray();

        Student[] std = new Student[n];

            Console.WriteLine(n);

            AcceptInfo(n, std);
            DisplayInfo(n, std);
            Console.WriteLine("Reverse the arrays");
            ReverseArray(n, std);   

           //public void AcceptInfo(int n)



    







}
    }
}
