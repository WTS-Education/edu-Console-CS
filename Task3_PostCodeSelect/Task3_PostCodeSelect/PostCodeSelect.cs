using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Task3_PostCodeSelect
{
    class PostCodeSelect
    {

        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//Nugetパッケージマネージャーからsystem.text.encoding.codepagesをインストール
            try
            {
                // CSVを開く
                StreamReader sr = new StreamReader
                    (@"C:\education\edu-Console2\Task3_PostCodeSelect\Task3_PostCodeSelect\27OSAKA.CSV", // 自分専用になってしまっている
                Encoding.GetEncoding("shift_jis"));

                while (!sr.EndOfStream)
                {
                    // CSVファイルの一行を読み込む
                    String line = sr.ReadLine();
                    //System.Console.Write("{0}", line);
                    
                    // 読み込んだ一行をカンマごとに分けて格納する
                    String[] values = line.Split(',');

                    // 配列からリストに格納する
                    List<string> lists = new List<string>();
                    lists.AddRange(values);

                    // コンソールに出力する
                    foreach (string list in lists)
                    {
                        System.Console.Write("{0}", list);
                    }

                    System.Console.WriteLine();


                }

            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
                System.Console.WriteLine(e.Message);
            }
        }
    }
}

/* 3、	当課題ファイルと同一フォルダにある「27OSAKA.CSV」を取り込み、下記の条件で別ファイルに														
	出力するプログラムを作成せよ。														
															
	抽出条件														
		市区町村名が大阪市阿倍野区のデータ													
															
	抽出項目														
		郵便番号（7桁）													
		都道府県名（漢字）													
		市区町村名（漢字）													
		町域名（漢字）													
															
	加工条件														
		「１階」など一桁の階数表示の町域名を「０１階」と全角のゼロで二桁にすること													
		例）		加工前				阿倍野筋あべのハルカス（１階）							
				加工後				阿倍野筋あべのハルカス（０１階）							
															
	ソート条件														
		郵便番号（7桁） 昇順													
															
	なお、課題のCSVのデータの項目については下記URLを参照のこと														
 */
