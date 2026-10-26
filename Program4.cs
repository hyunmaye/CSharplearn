//과제 2-사용자 상호 작용을 사용한 프로그램 만들기(주어진 주석을 바탕으로)
//Ask for the user's name
Console.Write("당신의 이름은?: \t");
string name = Console.ReadLine();
//Ask for the user's age
Console.Write("당신의 나이는?: \t");
string age = Console.ReadLine();
//Display a personalized message that includes both pices of information
Console.WriteLine($"반갑습니다 {age}세 {name}씨!");
