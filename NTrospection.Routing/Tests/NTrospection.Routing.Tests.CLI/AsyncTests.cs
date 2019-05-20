using Microsoft.VisualStudio.TestTools.UnitTesting;
using NTrospection.Routing.CLI;

namespace NTrospection.Routing.Tests.CLI
{
    [TestClass]
    public class AsyncTests: BaseCliTest
    {
        [TestMethod]
        public void ApplicationWaitsForAnyWaitedTasksBeforExiting()
        {
            mockConsole.Clear();
            Processor.ProcessArguments(new[] { "execute", "longRunning", $"{argPre}firstNum", "5", $"{argPre}secondNum", "9" });
            var temp = mockConsole.ToString();
            Assert.IsTrue(temp.Length > 0);
        }
    }
}
