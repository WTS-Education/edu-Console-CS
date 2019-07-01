using System;
using System.Globalization;

namespace Task1_birthdayCalculation
{
    class BirthdayCalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("生年月日を入力してください");
            String age = Console.ReadLine(); //生年月日を入力を促す

            string format = "yyyy/MM/dd"; // フォーマット
            CultureInfo ci = CultureInfo.CurrentCulture; 
            DateTimeStyles dts = DateTimeStyles.None;
            DateTime dateTime;

            if (DateTime.TryParseExact(age, format, ci, dts, out dateTime))
            {
            }
            else
            {
                Console.WriteLine("日付として正しい値を入力してください。yyyy/MM/dd");
                return;
            }
                       
            String year = age.Substring(0, 4); //生年月日の年を抽出
            String month = age.Substring(5, 2); //生年月日の月を抽出
            String day = age.Substring(8, 2); //生年月日の日を抽出

            int year2 = int.Parse(year); //年を数値に変換
            int month2 = int.Parse(month); //月を数値に変換
            int day2 = int.Parse(day); //日を数値に変換

            var dt = new DateTime(year2, month2, day2);
            var dt2 = new DateTime(0);
            TimeSpan ts = dt - dt2; //生年月日をタイムスパンに変換
            var Months = year2*12+month2; //経過月数の計算

                        // メッセージの出力
            Console.WriteLine("今日はあなたが生まれてから{0}ヶ月目です。", Months);
            Console.WriteLine("今日はあなたが生まれてから{0}日目です。", ts.TotalDays);
            Console.WriteLine("現時刻はあなたが生まれてから{0}時間です。", ts.TotalHours);
            Console.WriteLine("現時刻はあなたがうまれてから{0}分です。", ts.TotalSeconds/60);

        }
    }
}

