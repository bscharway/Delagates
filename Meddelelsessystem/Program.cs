namespace Meddelelsessystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student(/*p,*/ "Jens");

            Student s2 = new Student(/*p,*/ "Niels");

            Student s3 = new Student(/*p,*/ "Susan");

            //p.Attach(s1);
            p.MessageChanged += s1.Update;

            //p.Attach(s2);
            p.MessageChanged += s2.Update;

            //p.Attach(s3);
            p.MessageChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            //p.Detach(s2);
            p.MessageChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            static void MessageChanged(object sender, EventArgs e) { }
        }
    }
}
