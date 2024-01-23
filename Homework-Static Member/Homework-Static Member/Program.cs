using Homework_Static_Member;


string fullName;
string groupNo;
do
{
    Console.WriteLine("FullName daxil edin");
    fullName = Console.ReadLine();
} while (!Student.CheckFullName(fullName));
do
{
    Console.WriteLine("GroupNo daxil edin");
    groupNo = Console.ReadLine();
} while (!Student.CheckGroupNo(groupNo));
Student student = new Student()
{
    FullName = fullName,
    GroupNo = groupNo
};
Console.WriteLine($"FullName: {student.FullName} - GroupNo: {student.GroupNo}");












//string text = "Farid Abdullayev";
//var text2 = text.Substring(0,text.IndexOf(" ")+);
//Console.WriteLine(text2);