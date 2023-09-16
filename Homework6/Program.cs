//2 Video 

//static void ShowText() 
//{
//    Console.WriteLine("Hello Word");
//}

//ShowText();
//ShowText();
//ShowText();

//static void Sum();
//{
//    Console.WriteLine(5+10);
//}
//Sum();

//static void Sum() 
//{
//    int a = 5;
//    int b = 6;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum();

//static void Sum(int num1)
//{
//    int a = 5;
//    int b = 6;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum(5);

//static void Sum(int num1) 
//{
//    int sum = num1 + 100;
//    Console.WriteLine(num1+100);
//}
//Sum(100);


//static void SumOfNums(int a, int b) 
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//SumOfNums(3, 5);

//int a = 50;
//int b = 40;

//SumofNums(a, b);

//int salam1 = 50;
//int salam2 = 40;

//SumofNums(salam1, salam2);


//3 Video

//static void Sum() 
//{

//}

//int m = 200;
//int sum = 0;

//for (int i = 0; i < 200; i++) 
//{
//    sum += i;
//}
//Console.WriteLine(sum);

//int c = 200;
//int sum2 = 0;

//for (int i = 0; i < c; i++)
//{
//    sum2 += i;
//}
//Console.WriteLine(sum2);

//static void Sum() 
//{
//    int m = 200;
//    int sum = 0;

//    for (int i = 0; i <= m; i++) 
//    {
//        sum += i;
//    }

//    Console.WriteLine(sum);

//}

//static void Sum(m)
//{
//    int m = 200;
//    int sum = 0;

//    for (int i = 0; i <= m; i++)
//    {
//        sum += i;
//    }

//    Console.WriteLine(sum);

//}

//Sum(100);
//Sum(20);
//Sum(10);



//static void GetNumsOfAray() 
//{
//    int[] nums = { 1, 2, 3, };
//    foreach (var item in nums) ;
//;
//}


//int[] nums = { 1, 2, 3, 4, 5 };

//GetNumsOfAray();


//static void ChackMarried(bool isMarried, int age) 
//{
//    if (isMarried)
//    {
//        Console.WriteLine("Evlidir-" + age);
//    }
//    else 
//    {
//        Console.WriteLine("Subay-"+ age);
//    }

//}


//bool isMariied = true;


//CheckMarried(false);


//static void GetAge(int age) 
//{
//    bool isMarried = false;

//    CheckMarried(isMarried,age);
//}

//int age = 40;
//GetAge();   

//4 video

//static int GetNumber() 
//{
//    int number = 200;
//    return number;  
//}

//int result = GetNumber();
//if (result > 10) 
//{
//    Console.WriteLine(result);
//}


//static string GetTamp(int temp) 
//{
//    if (temp > 20)
//    {
//        return "Hot";
//    }
//    else 
//    {
//        return "Cold";
//    }
//}

//string result = GetTemp(30);
//Console.WriteLine(result);

//static bool InSuccess(string employeeName) 
//{
//    string[] employees = { "Semed", "Tunzala", "Metanet", "Meryem", "Haci", "Aqshin" }
//    foreach (var employee in employees) 
//    {
//        if (employee == employeeName)
//        {
//            return true;
//        }
//    }

//    return false;
//}
//bool result = IsSuccess("Metaneti");
//Console.WriteLine(result);


//bool result = InSuccess("Metanet");

//if (result)
//{
//    Console.WriteLine("Ugurludur");
//}
//else 
//{
//    Console.WriteLine(""Ugurlu Deyil"");
//}

//5 Video

//static int GetSumOddNumbers(int a, int b) 
//{
//    int sum = 0;
//    for (int i = 0; i < b; i++) 
//    {
//        if(i % 2 != 0)
//        {
//            sum = +i;
//        }


//    }
//    return sum;
//}

//int result = GetSumOddNumbers(5, 13);
//Console.WriteLine(result);


//using System.Threading.Channels;

//static bool Login(string username, string password) 
//{
//    if (username == "samed111" && password == "samed 123") 
//    {
//    return true;
//    }
//    return false;
//}

//Console.WriteLine("Add your username:");
//string username = Console.ReadLine();
//Console.WriteLine("Add your password:");
//string password = Console.ReadLine();

//if (Login(username, password))
//{
//    Console.WriteLine("Login is Success");

//}
//else 
//{
//    Console.WriteLine("Username or password is wrong");
//}


//static bool Search(string SudentName) 
//{
//    string[] students = { "Rufet", "Aqshin", "Semed", "Oruc" }
//    foreach (string student in students) 
//    {
//        if (student == studentName) 
//        {
//            return true;
//        }
//    }
//    return false;
//}
//Console.WriteLine("Ad daxil edin:");
//string name = Console.ReadLine();
//bool result = Search(name);
//if (result)
//{
//    Console.WriteLine("Name is Found");
//}
//else 
//{
//    Console.WriteLine("Name is not founf");
//}


//static void Test() 
//{
//    bool isTrue = true;
//    if (isTrue) 
//    {
//        return;
//    }
//    Console.WriteLine("false");
//}



//static void FindOddNums(int[] nums) 
//{
//    foreach (var item in nums) 
//    {
//        if (item % 2 == 1) 
//        {
//            return;
//        }
//    }

//}
//FindOddNums(new int[] { 1, 2, 3, 4, 5 });
