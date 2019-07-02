using System;
class Birthdaycalculation

{
    public static void Main()
    {
        Console.WriteLine("生年月日を入力してください。");


        var seinengappi = new DateTime(Console.Read());
        var today = System.DateTime.Today;

        if (seinengappi = ())
        {

        }

        TimeSpan elapsedSpan = today - seinengappi;

        Console.WriteLine("今日はあなたが生まれてから{0}か月目です。", elapsedSpan.TotalDays / 12);
        Console.WriteLine("今日はあなたが生まれてから{0}日目です。", elapsedSpan.TotalDays);
        Console.WriteLine("現時刻はあなたが生まれてから{0}時間です。", elapsedSpan.TotalHours);
        Console.WriteLine("現時刻はあなたが生まれてから{0}秒です。", elapsedSpan.TotalMinutes);


    }
}