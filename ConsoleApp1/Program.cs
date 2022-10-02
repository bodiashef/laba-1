using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks; 
  
 namespace ConsoleApp1 
 { 
     internal class Program 
     { 
         enum test1Status { Pass = 1, Fail = 2, Blocked = 3, WP = 4, Unexecuted= 5 } 
         struct RGB 
         { 
             public byte red; 
             public byte green; 
             public byte blue; 
         } 
         enum HTTPError 
         {  
             Bad_Request = 400, 
             Unauthorized, 
             Payment_Required, 
             Forbidden, 
             Not_Found 
         } 
  
         static void Main(string[] args) 
         { 
             //Task 1.1 
  
             /*int day, month; 
             day = Convert.ToInt32(Console.ReadLine()); 
             month = Convert.ToInt32(Console.ReadLine()); 
             string result = (day > 0) && (day < 31) && (month > 0) && (month < 12) ? 
             "Значення можуть представляти день і місяць" : "Значення не можуть представляти день і місяць"; 
             Console.WriteLine(result);*/ 
  
             //Task 1.2 
  
             /*double a = double.Parse(Console.ReadLine()); 
             var x1 = (a * 10) % 10; 
             var x2 = (a * 100) % 10; 
             int res = (int)(x1 + x2); 
             Console.WriteLine(res);*/ 
  
             //Task 1.3 
  
             /*int h; 
             h = Convert.ToInt32(Console.ReadLine()); 
             string result = (h >= 4) && (h <= 10) ? "Доброго ранку!" : (h >= 11) && (h <= 18) ? 
             "Доброго дня!" : (h >= 19) && (h <= 23) ? "Доброго вечора!" : "Доброї ночі!"; 
             Console.WriteLine(result);*/ 
  
             //Task 1.4 
  
             /*Console.WriteLine((test1Status)1); 
             Console.ReadKey(); 
             Console.ReadLine();*/ 
  
             //Task 1.5 
  
             /*RGB white; 
             white.red = 0; 
             white.green = 0; 
             white.blue = 0; 
  
             RGB black; 
             black.red = 255; 
             black.green = 255; 
             black.blue = 255;*/ 
  
             //Task 2.1 
  
             /*float n1, n2, n3; 
             n1 = Convert.ToInt32(Console.ReadLine()); 
             n2 = Convert.ToInt32(Console.ReadLine()); 
             n3 = Convert.ToInt32(Console.ReadLine()); 
             string check1 = (n1 >= -5) && (n1 <= 5) ? "Перше число належить дiапазону" : "Перше число не належить дiапазону"; 
             string check2 = (n2 >= -5) && (n2 <= 5) ? "Друге число належить дiапазону" : "Друге число не належить дiапазону"; 
             string check3 = (n3 >= -5) && (n3 <= 5) ? "Третє число належить дiапазону" : "Третє число не належить дiапазону"; 
             Console.WriteLine(check1); 
             Console.WriteLine(check2); 
             Console.WriteLine(check3);*/ 
  
             //Task 2.2 
  
             /*int n1, n2, n3; 
             Console.WriteLine("Введіть перше число"); 
             n1 = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("Введіть друге число"); 
             n2 = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("Введіть третє число"); 
             n3 = Convert.ToInt32(Console.ReadLine()); 
  
             int[] arr = { n1, n2, n3 }; 
  
             Console.WriteLine("Мінімальне число " + arr.Min()); 
             Console.WriteLine("Максимальне число " + arr.Max());*/ 
  
             //Task 2.3 
             /*int errCode; 
             errCode = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine((HTTPError)errCode); 
             Console.ReadKey(); 
             Console.ReadLine();*/ 
         } 
     } 
 }