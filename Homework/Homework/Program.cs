// See https://aka.ms/new-console-template for more information




//1 Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram //


//int[] nums = { 30, 40, 20 };


//int maxnumber = nums[0];
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] > maxnumber)
//    {
//        maxnumber = nums[i];
//    }
//}
//Console.WriteLine(maxnumber);






//2 Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram


//Console.WriteLine("Bir yazi daxil edin:");
//string name = Console.ReadLine();


//for (int i = 0; i < name.Length; i++)
//{
//    if (name[i] == 'A')
//    {
//        Console.WriteLine("Cavab: var");
//        break;
//    }
//}







//3 Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram//

//Console.WriteLine("Bir yazi daxil edin:");
//string name = Console.ReadLine();
//int count = 0;

//for (int i = 0; i < name.Length; i++)
//{
//    if (name[i] == 'A')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);










//4 Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
//Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir//


//again:
//Console.WriteLine("Eded daxil edin:");
//string numStr = Console.ReadLine();
//int num = Convert.ToInt32(numStr);



//if (num > 0 && num % 2 == 0)
//{
//    num *= num;
//}
//else
//{
//    goto again;
//}
//Console.WriteLine($"Cavab:{num}");










// 5 Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram //

//int[] nums = new int[5] { 1, 2, 3, 4, 5 };

//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];
//}
//Console.WriteLine(sum);





// 6 Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər
//"programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
//"system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.//



//Console.WriteLine("Tehsil novunu qeyd edin:");
//string education = Console.ReadLine();

//switch (education)
//{
//    case "programming":
//        Console.WriteLine("400 saat");
//        break;
//    case "design":
//        Console.WriteLine("250 saat");
//        break;
//    case "system":
//        Console.WriteLine("200 saat");
//        break;
//    default:
//        Console.WriteLine("Tehsil novu yansildir");
//        break;
//}
