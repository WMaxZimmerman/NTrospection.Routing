using System;
using NTrospection.Routing.CLI.Attributes;

namespace NTrospection.Routing.CLI.TestApp.Controllers
{
    [CliController("math", "Performs math operations")]
    public class MathController
    {
        [CliCommand("add", "Adds two numbers")]
        public void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
