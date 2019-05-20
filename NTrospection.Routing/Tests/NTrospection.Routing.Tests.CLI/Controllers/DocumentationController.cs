﻿using NTrospection.Routing.CLI.Attributes;
using System;

namespace NTrospection.Routing.Tests.CLI.Controllers
{
    [CliController("document", "This is a test description.")]
    public static class DocumentationController
    {
        [CliCommand("example", "This is an example description.")]
        public static void TestMethod(string required, int opt = 0)
        {
            Console.WriteLine($"{required} {opt}");
        }
    }
}

public static class BlowShitUp
{

}
