// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
 class Program
 {
  static void Main(string[] args)
  {
    Hashtable ht=new Hashtable();
    ht.Add("001",".Net");
    ht.Add("002",".C#");
    ht.Add("003",".ASP.Net");
    ICollection keys=ht.Keys;
    foreach(String k in keys){
        Console.WriteLine(ht[k]);
    }
    //Console.ReadKey();//在控制台應用程式中用於讀取單個按鍵輸入的方法。它會暫停程式的執行，直到用戶在鍵盤上按下任意鍵。
    Console.WriteLine(ht.ContainsKey("003"));

  }
 }
}