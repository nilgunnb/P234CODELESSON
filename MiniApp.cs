Student[] students = new Student[0];

Console.WriteLine("0.Close");
Console.WriteLine("1.Show Students");
Console.WriteLine("2.Create Student");

string numberstring = Console.ReadLine();

while (numberstring != "0")
{
    switch(numberstring)
    {
        case "1":
            for (int i = 0; i < students.Length; i++)
            {
                students[i].GetFullInfo();
            }
            break;
        case "2":
            Student student = new Student();

            Console.WriteLine("Please, add Name");

            student.Name = Console.ReadLine();

            Console.WriteLine("Please, add Email");

            student.Email = Console.ReadLine();

            Array.Resize(ref students, students.Length+1);

            students[students.Length - 1] = student;

            break;
            default: Console.WriteLine("Please, add valid option");
            break;

    }
    Console.WriteLine("0.Close");

    Console.WriteLine("1.Show Students");

    Console.WriteLine("2.Create Student");

    numberstring = Console.ReadLine();


}