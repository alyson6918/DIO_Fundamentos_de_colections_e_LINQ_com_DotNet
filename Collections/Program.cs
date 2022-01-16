using Collections.Helper;
List<string> states = new List<string>();
ListOperator op = new ListOperator();
states.Add("SP");
states.Add("MG");
states.Add("BA");
op.PrintList(states);
states.Remove("MG");