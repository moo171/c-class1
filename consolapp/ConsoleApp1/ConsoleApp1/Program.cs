//int CountInt = 0;
//bool Status = false;
//string Input = Console.ReadLine();
//if (Input == "안녕")
//{
//    Status = true;
//}
//do
//{
//    Console.WriteLine(CountInt);
//    CountInt++;
//} while (Status);
Console.WriteLine("시작!");
for (int i = 5; i == 0; i--)
{
Console.WriteLine("5");
Thread.Sleep(1000);
Console.WriteLine("4");
Thread.Sleep(1000);
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Thread.Sleep(1000);
Console.WriteLine("0");
}

Console.WriteLine("시작");
Thread.Sleep(1000);
Console.WriteLine("진짜시작");
Thread.Sleep(1000);
Console.WriteLine("진짜진짜시작");
Console.WriteLine("[무영의 콘솔게임]");
Console.WriteLine("메뉴1. 던전");
Console.WriteLine("메뉴2. 아이템창");
while (true)
{
    Console.WriteLine("---------------------------------------------------");
    Console.Write("입력란 : ");
    string a = Console.ReadLine();
    if (a == "던전")
    {
        Console.WriteLine("던전으로 들어왔습니다");
    }
    else if (a == "아이템창")
    {
        Console.WriteLine("아이템 리스트를 보여드리겠습니다.");
    }
}
