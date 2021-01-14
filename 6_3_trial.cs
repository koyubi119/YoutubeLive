using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_trial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 出典：出井 秀行. 新・標準プログラマーズライブラリ なるほどなっとく C#入門 (Kindle の位置No.2873-2875). 株式会社技術評論社. Kindle版. 
             * >文字列の配列があるとします。
             *  この配列の中から、最も文字数の多い文字列を出力するコードを書いてください。
             *  なお、該当する文字列が複数ある場合は、配列の後の方に格納されている文字列を出力することとします。
             */

            //解答コードのDL→(https://gihyo.jp/book/2019/978-4-297-10458-0/support)

            string[] names = { "C#", "Ruby", "Kotlin", "Swift", "Python", "Java", "PHP" }; // ここでは、7つの要素を持つ配列を用意

            var max = ""; // ←ここ何してるかわからない
            foreach (var name in names) // 箱namesから取り出した値をnameとする？
            {
                if (name.Length >= max.Length) // もしnameがmaxより長ければ？
                {
                    max = name; // nameをmaxに代入？
                }
            }
            Console.WriteLine(max); // max(文字列Python)を出力
        }
    }
}
