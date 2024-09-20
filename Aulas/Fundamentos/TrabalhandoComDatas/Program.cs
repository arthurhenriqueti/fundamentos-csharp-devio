Console.WriteLine("Trabalhando com Datas");

DateTime data1 = new DateTime(2024, 09, 20, 18, 52, 00);
DateTime data2 = DateTime.Parse("2024/09/20 18:52:00");
var data3 = DateTime.Now;
var data4 = DateTime.Today;

Console.WriteLine(data1);
Console.WriteLine(data2);
Console.WriteLine(data3);
Console.WriteLine(data4);

Console.WriteLine(data1.ToString("dd-MM-yyyy HH:mm:ss"));

DateTime data5 = DateTime.Parse("2020/09/20 18:52:00");

var diff = data3 - data5;

Console.WriteLine((int) diff.TotalDays);
Console.WriteLine((int) diff.TotalHours);

Console.WriteLine(data3.AddDays(30));
Console.WriteLine(data3.AddMonths(2));
Console.WriteLine(data3.AddYears(2000));

Console.WriteLine(data3.DayOfWeek);

var data6 = new DateOnly(2024, 09, 20);
// var data6 = DateOnly.Parse("2024/09/20");

Console.WriteLine(data6.ToString("MM-dd-yyyy"));

var data7 = new TimeOnly(19, 19, 00);
// var data7 = TimeOnly.Parse("19:19:00");

Console.WriteLine(data7);
Console.WriteLine(data7.ToString("HH:mm:ss"));