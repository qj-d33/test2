
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
 class javascripts 
 {
  static void Main(string[] args) 
  {

    /*3個可樂瓶可以換一瓶可樂，現在有364瓶可樂。問一共可以喝多少瓶可樂，剩下幾個空瓶
    Console.WriteLine("目前有幾罐可樂:");
    string coca1=Console.ReadLine();
    int coca=Convert.ToInt32(coca1); 
    int sum=coca;
    while(coca>=3){
      sum=sum+coca/3;
      coca=coca/3+coca%3;
    }
    Console.WriteLine("總共喝了"+sum+"瓶可樂,剩下"+coca+"個空瓶");*/
    /*編寫一個應用程式用來輸入的字串進行加密，對於字母字串加密規則如下：

‘a’→’d’ ‘b’→’e’ ‘w’→’z’ …… ‘x’→’a’ ‘y’→’b’ ‘z’→’c’‘A’→’D’ ‘B’→’E’ ‘W’→’Z’ …… ‘X’→’A’ ‘Y’→’B’ ‘Z’→’C’?對於其他字元，不進行加密。
            String str;
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]>='a'&&str[i]<='z'||str[i]>='A'&&str[i]<='Z')
                {
                    int num = str[i];
                    num += 3;
                    char temp = (char) num;
                    if (temp>'z')//要看ASCII對照表才知道
                    {
                        temp = (char)(temp - 'z' + 'a' - 1); 
                    }
                    else if (temp > 'Z' && temp < 'a')//要看ASCII對照表才知道 CHAR才能比較'',STRING不能""
                    {
                        temp = (char)(temp - 'Z' + 'A' - 1); 
                    }
                    else
                    Console.Write(temp);
                      
                      
                }
                
            }
 }
}
}*/