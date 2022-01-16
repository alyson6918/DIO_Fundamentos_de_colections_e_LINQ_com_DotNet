using Collections.Helper;
List<string> states = new List<string>{"SP", "MG", "BA"};
string[] s1 = new string[2]{"SC","MT"};
ListOperator op = new ListOperator();

op.PrintList(states);
System.Console.WriteLine("----------");
states.Insert(1, "RJ");
states.Remove("BA");
states.AddRange(s1);
op.PrintList(states);