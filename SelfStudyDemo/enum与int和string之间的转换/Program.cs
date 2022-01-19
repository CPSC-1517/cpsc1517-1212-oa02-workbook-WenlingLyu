// See https://aka.ms/new-console-template for more information
using enum与int和string之间的转换;
using static System.Console;


QQstate state = QQstate.Offline;

//enum 和 int 类型兼容，可以互相转换
#region 将enum转化为int
//将enum转化为int
int n = (int)state; 
WriteLine(n); //1
WriteLine((int)QQstate.Online); //0
WriteLine((int)QQstate.Leave); //2
WriteLine((int)QQstate.QMe); //4
//可以在enum中改变value的赋值，反正往后依次++1就对了，或者任意赋值
#endregion
WriteLine();

#region int转化为enum
//将int转化为enum
int n1 = 0;

QQstate secondState = (QQstate)n1;
WriteLine(secondState);
#endregion
WriteLine();

//所有的类型都可以转化为string类型， 调用ToString()
#region int转string
int n2 = 10;
string s = n2.ToString();
WriteLine(s);
#endregion
WriteLine();

#region enum转string
QQstate thirdState = QQstate.Offline;
string s1 = thirdState.ToString();
WriteLine(s1);
#endregion
WriteLine();


//将string转化为enum
#region 将string转化为enum
string s3 = "100";
//将s3转化成enum
//string转化为int，可以用 Conver.ToInt32(); Int.Parse(); Int.TryParse
//转化为Enum， 可以用Enum.Parse();
//调用Parse()方法的目的，就是为了让它帮我们把一个字符串转换成对应的枚举类型
//
QQstate fourthState = (QQstate)Enum.Parse(typeof(QQstate), s3);
WriteLine(fourthState);
//这玩意儿一般不用
#endregion

//我们可以将enum类型与int，string类型互相转换
//枚举类型默认与int类型相互兼容，所以用强转语法来互相转换
//当转换一个enum中没有的值为int时，不会抛出异常，而是直接将数字显示出来
//enum转换string，直接调用ToString
//string转换enum，代码如下：
//(要转换的enum类型)Enum.Parse(typeof(要转换的枚举类型)，“要转换的字符串”)
//如果要转换的字符串是数字，则就算枚举中没有，也不会抛出异常
//如果要转换的字符串是文本，枚举中没有的话，会抛出异常


//enum练习：
#region enum转化练习
WriteLine("Choose a status of your QQ state:");
WriteLine("0--Online");
WriteLine("1--OffLine");
WriteLine("20--Leave");
WriteLine("100--Busy");
WriteLine("101--QMe");
string userStateChoice = ReadLine();
switch (userStateChoice)
{
    case "0":
        QQstate userState = (QQstate)Enum.Parse(typeof(QQstate),userStateChoice);
        WriteLine($"Your state is {userState}");
        break;
    case "1":
        QQstate userState1 = (QQstate)Enum.Parse(typeof(QQstate), userStateChoice);
        WriteLine($"Your state is {userState1}");
        break;
    case "20":
        QQstate userState2 = (QQstate)Enum.Parse(typeof(QQstate), userStateChoice);
        WriteLine($"Your state is {userState2}");
        break;
    case "100":
        QQstate userState3 = (QQstate)Enum.Parse(typeof(QQstate), userStateChoice);
        WriteLine($"Your state is {userState3}");
        break;
    case "101":
        QQstate userState4 = (QQstate)Enum.Parse(typeof(QQstate), userStateChoice);
        WriteLine($"Your state is {userState4}");
        break;
}

#endregion
