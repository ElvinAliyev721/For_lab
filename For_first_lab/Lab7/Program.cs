using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    internal class Program
    {
        // params ---
        // methods para type, count , name ---
        // regex ^  ,  \ -\D \d reqem - \S \s boshluq -\W \w alfanumerik --- Replace Match
        // datetime
        static void Main(string[] args)
        {

            #region Regex
            //string word = "241fdsfsd";
            //word = Regex.Replace(word, @"\d+","");
            //Console.WriteLine(word);
            //string word2 = "9126fsd";
            //Regex regex = new Regex(@"^9\S");
            //Match match = regex.Match(word2);
            //Console.WriteLine(match.Success);
            #endregion
            #region App
            //DateTime date = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine($"{date:yyyy.MM.dd}");
            //Group[] groups = new Group[0];
            //Console.WriteLine("1. Group Yarat                         2. Student yarat ");
            //int menu = int.Parse(Console.ReadLine());
            //if (menu==1)
            //{
            //    Group group = new Group(Console.ReadLine());
            //    Student[] students= new Student[0];
            //    Console.WriteLine("Group Yaradildi ... ");
            //    Console.WriteLine("Indi ise Shagird yaradilmalidi ... ");
            //    string NameStu=Console.ReadLine();
            //    string SurnameStu=Console.ReadLine();
            //    DateTime date=Convert.ToDateTime(Console.ReadLine());
            //    Student newstu=new Student(NameStu,SurnameStu,date);
            //    Array.Resize(ref students,students.Length+1);
            //    students[students.Length]=newstu;

            //    group.Students = students;

            //    Array.Resize(ref groups,groups.Length+1);
            //    groups[groups.Length] = group;

            //}
            //else if (menu==2)
            //{

            //}
            #endregion
            #region MainApp
            //Group[] groups = new Group[0];
            //Console.WriteLine("1. Group yarat                    2.Student yarat");
            //int mane = int.Parse(Console.ReadLine());
            //if (mane == 1)
            //{
            //    Group newgr = new Group();
            //    newgr.Name = Console.ReadLine();
            //    Console.WriteLine("Group yaradildi zehmet olmasa telebe daxil edin");
            //    Student[] shagirdler = new Student[0];

            //    Student student = new Student();
            //    student.Name = Console.ReadLine();
            //    student.Surname = Console.ReadLine();
            //    student.Age = int.Parse(Console.ReadLine());
            //    Array.Resize(ref shagirdler, shagirdler.Length + 1);
            //    shagirdler[shagirdler.Length - 1] = student;
            //    newgr.students = shagirdler;

            //    Array.Resize(ref groups, groups.Length + 1);
            //    groups[groups.Length - 1] = newgr;

            //}
            //else if (mane == 2)
            //{

            //}
            #endregion

        }
        public static void Get(int a)
        {
            int sum = 0;
            int qaliq;

            while (a>0)
            {
                qaliq = a % 10;
                sum += qaliq;
                a = a / 10;            
            }
            Console.WriteLine(sum);
        }
        public static void Get(string a)
        {
            bool success=int.TryParse(a, out int result);
            if (success)
            {
                int ab = result;
                int sum = 0;
                int qaliq;

                while (ab > 0)
                {
                    qaliq = ab % 10;
                    sum += qaliq;
                    ab = ab / 10;
                }
                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("Error");
            }
            
        }
        //para type
    }
}
