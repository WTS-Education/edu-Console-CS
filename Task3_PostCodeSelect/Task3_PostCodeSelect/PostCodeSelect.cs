using System;
using System.IO;

namespace Task3_PostCodeSelect
{
    class PostCodeSelect
    {
        static void Main(string[] args)
        {
            try
            {
                // CSVファイルを開く
                using (var sr = new System.IO.StreamReader(@"27OSAKA.CSV"))
                {
                    // ストリームの末尾まで繰り返す
                    while(! sr.EndOfStream)
                    {
                        //ファイルから1行読み込む
                        var line = sr.ReadLine();

                        // 読み込んだ一行をカンマ毎に分けて配列に格納する
                        //var values = line.Spilit(',')




                    }
                }
            }
            catch(System.Exception e)
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
