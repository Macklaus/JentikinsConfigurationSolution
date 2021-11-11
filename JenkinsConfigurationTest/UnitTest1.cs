using System;
using System.IO;
using Xunit;

namespace JenkinsConfigurationTest
{
    
    public class UnitTest1
    {
        private const string Expected = "Welcome to configuration Jenkings";
        [Fact]
        public void Test1()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JentikinsConfiguration.Program.Main();

                var result = sw.ToString().Trim();
                Assert.Equal(Expected, result);
            }
        }
    }
}
