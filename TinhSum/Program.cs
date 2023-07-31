// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// tính tổng từ 1 đến n bất kyd

var s = 0;
for (int i = 0; i <= 3; i++) // ví dụ tổng từ 1 đến S = 1 +2 +3
{
    s = s + i; // nó thực hiện cộng truwóc rồi nó mới i ++ lên 1 đơn vị ?? hieur ko thấy chưa, s = 0 + 0 trước rồi nó mới cộng cộng lên, đây cũng thế 1+2 rồi nó mới tăng thêm 1 để cộng thêm 3, có nghĩa là thực hiện trc rồi tăng sau
}
Console.WriteLine("Tổng là = " + s); // cái chỗ này nỗi 
Console.WriteLine("Tổng từ 1 đến {0}  là = {1}" , 100, s); // chỗ này là cách viết thay thế {0} là vị trí {0} n

var x = 10;
var y = 20;
x = y - x; // x=  20 -10 = 10
y = y + x; // 20 + 10 =30
x = x - y; // 10 -30 = -20
Console.WriteLine(x); // x = mấy trả lời đi 10 -10 mấy đây = -20
Console.WriteLine(y); // y = 30
// Hiểu không ?? à hiểu hiểu
// nó chạy từ trên xuoogns dưới
// bây giờ  i trong vòng lặp là gì ?? ... trả lời đi alo vị trí là vị trí bắt đầu từ 0, cai này hiểu chưa
// bây giờ phân biệt i++ và  ++i
// i++ là gì cộng thêm 1 phần tử vào vị trí i , rồi nói tóm lại là cộng thêm 1 vào i, i ở trong for là vị trí, còn ở ngoài nó là số bình thường hiểu ko
// thế còn ++i  
// i ++ là thực thi xong mới cộng 1
// ++ i là cộng xong mới thực thi
// nghe hơi khó hiểu, hiểu nôm na là i ++ làm xong việc thì nó mới cộng thêm 1, ví dụ trong vòng lặp nó thực hiện lệnh s = s + i truwóc rồi nó mới bắt đầu cộng lên 1

// để lấy ví dụ dễ hiểu hơn
var a = 1;
var b = 2;
var d = 3;
var c = b + a++;  // c bằng mấy? trả lười đê alo , 3
// thế nếu in ra a thì lúc này a bằng mấy ? a=1 sao lại bằng 1 ?? 
var e = b + ++d; // e bằng mấy ? thế e 5 . sao lại bằng 5
// a++ là thực hiện xong thì mới tăng, còn ++a là tăng xong mới thực hiện
// c = b + a++ = > c = 2 + 1 = 3 là đúng
// nhưng sau khi tính toán xong thì phải tăng a lên chứ tức là a =2

// còn c = b + ++d, thì  ++d là tăng xong mới thực hiện thì lúc này d tăng lên trước = 3+1 = 4 //
// tăng lên rồi mới cộng = > e = 2 + 4 = 6 chớ ?? Hiểu chưa đọc rồi ngẫm đi  à hiểu rồi :)))

var g = 10;


Console.WriteLine(g++); // mấy g = ? 10 +ok good, cái này à 1 lần thực hiện rồi

var z = 2 + g; // z = mấy, ở đây nó tăng lên luôn 11

Console.WriteLine(z);  // zbang mấy = 12 sai nhé vậy đây là 13
Console.WriteLine(g); // g bằng mấy sau khi tính xoq z +1 =11 Ok thầy bịp vl :))) Hiểu chưa câu hỏi phỏng vấn đó
// cứ nhớ mỗi lần thực hiện lệnh xong là nó tăng
// Console là một lệnh mà cha :)) hiểu chưua okchwua. cái  ++i thì dễ hơn, tăng ngay lên dễ Ok, còn i++ nó hơi bịp tý


// Hiểu chưa ok anh học js r , học r mà quên à
// sau phỏng vấn có câu này chớ quên
// i++ là cộng sau
// ++i là cộng trước nghe chưa

