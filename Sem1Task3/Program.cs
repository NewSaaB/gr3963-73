Console.Write("Введите число недели: ");
var day = Convert.ToInt32(Console.ReadLine());
// string[] dayWeek = new string[7];
// dayWeek[0] = "понедельник";
// dayWeek[1] = "вторник";
// dayWeek[2] = "среда";
// dayWeek[3] = "четверг";
// dayWeek[4] = "пятница";
// dayWeek[5] = "суббота";
// dayWeek[6] = "воскресенье";
// Console.Write("Сегодня день недели: " + dayWeek[day-1] );

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
Console.Write(outDayOfWeek);