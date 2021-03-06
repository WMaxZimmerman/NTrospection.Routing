﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NTrospection.Routing.CLI;

namespace NTrospection.Routing.Tests.CLI
{
    [TestClass]
    public class DefaultCommandTest : BaseCliTest
    {
        [TestMethod]
        public void AbleToCallCommandWithName()
        {
            mockConsole.Clear();
            var consoleLines = new List<string>
            {
                "Here is some output."
            };
            Processor.ProcessArguments(new[] { "default", "bool", $"{argPre}withOutput" });
            var temp = mockConsole.ToString();
            var expectedString = ConvertConsoleLinesToString(consoleLines);
            Assert.AreEqual(expectedString, temp);
        }

        [TestMethod]
        public void AbleToCallCommandWithoutName()
        {
            mockConsole.Clear();
            var consoleLines = new List<string>
            {
                "Here is some output."
            };
            Processor.ProcessArguments(new[] { "default", $"{argPre}withOutput" });
            var temp = mockConsole.ToString();
            var expectedString = ConvertConsoleLinesToString(consoleLines);
            Assert.AreEqual(expectedString, temp);
        }
    }
}
