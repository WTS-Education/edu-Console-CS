using System;
using System.Globalization;

namespace Task2_JapanCalendarCalculation
{
    class JapanCalendarCalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("生年月日を入力してください");
            String age = Console.ReadLine(); //生年月日を入力を促す

            string format = "yyyy/MM/dd"; // フォーマット
            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTimeStyles dts = DateTimeStyles.None;
            DateTime dateTime;
            // 例外処理
            if (DateTime.TryParseExact(age, format, ci, dts, out dateTime))
            {
            }
            else
            {
                Console.WriteLine("日付として正しい値を入力してください。yyyy/MM/dd"); // エラー表示
                return;
            }

            String year = age.Substring(0, 4); //生年月日の年を抽出
            String month = age.Substring(5, 2); //生年月日の月を抽出
            String day = age.Substring(8, 2); //生年月日の日を抽出

            int year2 = int.Parse(year); //年を数値に変換
            int month2 = int.Parse(month); //月を数値に変換
            int day2 = int.Parse(day); //日を数値に変換
            DateTime dt = new DateTime(year2, month2, day2);
            DateTime dt2 = new DateTime(1872,12,31); // 1872/12/31のデータを作成

            // 入力結果が1872/12/31以降かどうかのチェック
            if (dt >= dt2) 
            {
            }
            else
            {
                Console.WriteLine("変換対象外の日付です"); //エラー表示
                return;
            }

            //Console.WriteLine($"表示したい日（西暦）: {dt:yyyy/MM/dd}");//入力結果確認用

            // JapaneseCalendarクラスのインスタンスを作る
            var calendarJp = new System.Globalization.JapaneseCalendar();

            // CultureInfoクラスのインスタンスを日本語用として作成し、
            var cultureJp = new System.Globalization.CultureInfo("ja-JP", false);

            // そのDateTimeFormatプロパティにJapaneseCalendarインスタンスをセットしておく
            cultureJp.DateTimeFormat.Calendar = calendarJp;

            //和暦の表示
            Console.WriteLine(dt.ToString("ggyy年MM月dd日", cultureJp));
        }
    }
}
