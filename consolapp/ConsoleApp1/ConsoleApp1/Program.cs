int score = 0;
//Console.Write("입력해주세요. : ");
bool status = true;
Console.Write("반복할까요. : ");
string Get_Input = Console.ReadLine();
if (Get_Input == "네")
{
    status = true;
}
else
{
status = false;
}
    while (status)
    {
        Console.Write("반복!!");
    }




























//Console.WriteLine(Geting_int);
string GetRead_String = Console.ReadLine();
switch (GetRead_String)
{
    case "모자":
        Console.Write("모자를 획득했습니다.");
        score = 5;
        break;
    case "사탕":

        Console.Write("사탕을 획득 했습니다!!.");
        score = 10;
         break;
    default:
         Console.Write("획득실패!");
        score = 0;
        break ;
}
        Console.WriteLine("나의 스코어는 " +score.ToString() + "입니다.");
