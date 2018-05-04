using System;
using System.IO;
using System.Text;
using Xunit;

namespace csharp
{
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            string output = fakeoutput.ToString();

            var expected = File.ReadAllText("ApprovalTest.ThirtyDays.approved.txt");
            Assert.Equal(expected, output);
        }
    }
}
