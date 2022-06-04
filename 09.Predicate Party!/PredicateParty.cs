using System;
using System.Collections.Generic;
using System.Linq;

class PredicateParty
{
    static void Main()
    {
        List<string> members = Console.ReadLine().Split().ToList();
        string[] commands = Console.ReadLine().Split();

        while (commands[0] != "Party!")
        {
            DoCommand(commands[0], commands[1], commands[2]);
            commands = Console.ReadLine().Split();
        }

        void DoCommand(string firstCmd, string secondCmd, string cmdValue)
        {
            if (secondCmd == "Length")
            {
                Predicate<string> IsLenghtValid = (string name) => name.Length != int.Parse(cmdValue);
                if (firstCmd == "Double")
                {
                    Double(IsLenghtValid);
                }
                else
                    members = members.Where(name => IsLenghtValid(name)).ToList();
            }
            else if (secondCmd == "StartsWith")
            {
                Predicate<string> IsStartsWith = (string name) =>
                {
                    string startsWith = string.Empty;
                    if (cmdValue.Length <= name.Length)
                        startsWith = name.Substring(0, cmdValue.Length);
                    else
                        startsWith = name.Substring(0, name.Length);
                    if (startsWith == cmdValue)
                        return false;
                    return true;
                };
                if (firstCmd == "Double")
                {
                    Double(IsStartsWith);
                }
                else
                    members = members.Where(name => IsStartsWith(name)).ToList();
            }
            else if (secondCmd == "EndsWith")
            {
                Predicate<string> IsEndsWith = (string name) =>
                {
                    string endsWith = string.Empty;
                    if (cmdValue.Length <= name.Length)
                        endsWith = name.Substring(name.Length - cmdValue.Length);
                    else
                        endsWith = name.Substring(name.Length - (name.Length - cmdValue.Length));
                    if (endsWith == cmdValue)
                        return false;
                    return true;
                };
                if (firstCmd == "Double")
                {
                    Double(IsEndsWith);
                }
                else
                    members = members.Where(name => IsEndsWith(name)).ToList();
            }
        }
        void Double(Predicate<string> Predicate)
        {
            List<string> membersToAdd = new List<string>();
            foreach (string member in members)
            {
                if (!Predicate(member))
                {
                    membersToAdd.Add(member);
                }
            }
            for (int i = 0; i < membersToAdd.Count; i++)
            {
                members.Insert(members.IndexOf(membersToAdd[i]), membersToAdd[i]);
            }
        }
        if (members.Count == 0)
            Console.WriteLine($@"Nobody is going to the party!");
        else
            Console.WriteLine($@"{string.Join(", ", members)} are going to the party!");
    }
}
