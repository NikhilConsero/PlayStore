using PlayStore;
//Console.WriteLine("My Play Store");
////Creating a object for the class
////new keyword is used to create an object and sapce in heap for memory
//User u = new User();
//u.CreateUser();
//Categories c = new Categories(11, "Fashion", "Fashion test");
//Console.WriteLine(c.Name);
//Console.WriteLine(c.Id);
//Console.WriteLine(c.Description);
//c.AddCategory(3, "ABC");
//c.AddCategory(2, "XYZ", "Test");
//Categories d = c;
int x = 10;
object o = x; //Boxing 
string s = o.ToString(); //UnBoxing
Report report = new Report();
report.GetReport<int>(12);
report.GetReport2<int, string>(12, "hello");
report.GenerateReport();