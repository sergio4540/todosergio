using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using todosergio.Functions.Functions;
using todosergio.Tests.Helpers;
using Xunit;

namespace todosergio.Tests.Test
{
    public class ScheduleFunctionTest
    {
        [Fact]
        public void ScheduleFunctionTest_Should_Log_Message()
        {

            //Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
           ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            //Act
            ScheduleFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];

            //Asert
            Assert.Contains("Deleting completed", message);

        }
    }
}
