using StringManipulation.Program.Models;
using Xunit.Abstractions;

namespace StringManipulation.Testing
{

    public class SortingStringTest
    {
        private readonly ITestOutputHelper output;

        public SortingStringTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        private void WriteToConsole(List<string> inputStrings, List<string> actualOutput)
        {
            output.WriteLine("Test Case Input");
            output.WriteLine(inputStrings.Count.ToString());
            foreach (var item in inputStrings)
            {
                output.WriteLine(item);
            }
            // Perform sorting operation
            output.WriteLine(Environment.NewLine);


            output.WriteLine("Expected Output");
            // Print the output string
            foreach (var str in actualOutput)
            {
                output.WriteLine(str);
            }
        }

        [Fact]
        public void TestSortingOperations1()
        {
            // Arrange
            List<string> inputStrings = new List<string>();
            inputStrings.Add("abaccadcc");
            inputStrings.Add("xyzxy");


            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("ccccaaabd");
            expectedOutput.Add("xxyyz");

            // Act
            List<string> actualOutput = StringSorting.SortingOperations(inputStrings);

            WriteToConsole(inputStrings, actualOutput);
            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }


        [Fact]
        public void TestSortingOperations2()
        {
            // Arrange
            List<string> inputStrings = new List<string>();
            inputStrings.Add("dulgvgzwqg");
            inputStrings.Add("gxtjtmtywr");
            inputStrings.Add("hnlnxiupgt");
            inputStrings.Add("gzjotckivp");
            inputStrings.Add("dpwwsdptae");
            inputStrings.Add("pcscpilknb");
            inputStrings.Add("btvyhhmflf");
            inputStrings.Add("artrtnqxcr");
            inputStrings.Add("nrtcmcoadn");
            inputStrings.Add("fkdsgnekft");

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("gggdlquvwz");
            expectedOutput.Add("tttgjmrwxy");
            expectedOutput.Add("nnghilptux");
            expectedOutput.Add("cgijkoptvz");
            expectedOutput.Add("ddppwwaest");
            expectedOutput.Add("ccppbiklns");
            expectedOutput.Add("ffhhblmtvy");
            expectedOutput.Add("rrrttacnqx");
            expectedOutput.Add("ccnnadmort");
            expectedOutput.Add("ffkkdegnst");

            // Act
            List<string> actualOutput = StringSorting.SortingOperations(inputStrings);
            WriteToConsole(inputStrings, actualOutput);
            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestSortingOperations3()
        {
            // Arrange
            List<string> inputStrings = new List<string>();
            inputStrings.Add("wzenwebuau");
            inputStrings.Add("vokfxzynwl");
            inputStrings.Add("neldfeyrxk");
            inputStrings.Add("wqadfiodgs");
            inputStrings.Add("ykiuvzfcbc");


            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("eeuuwwabnz");
            expectedOutput.Add("fklnovwxyz");
            expectedOutput.Add("eedfklnrxy");
            expectedOutput.Add("ddafgioqsw");
            expectedOutput.Add("ccbfikuvyz");

            // Act
            List<string> actualOutput = StringSorting.SortingOperations(inputStrings);
            WriteToConsole(inputStrings, actualOutput);
            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestSortingOperations4()
        {
            // Arrange
            List<string> inputStrings = new List<string>();
            inputStrings.Add("qakmc");
            inputStrings.Add("rrtbk");
            inputStrings.Add("vaixn");
            inputStrings.Add("wmpnj");
            inputStrings.Add("uproi");
            inputStrings.Add("btska");
            inputStrings.Add("ejqwr");
            inputStrings.Add("elwlg");
            inputStrings.Add("oaoiy");
            inputStrings.Add("hrqkn");


            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("ackmq");
            expectedOutput.Add("rrbkt");
            expectedOutput.Add("ainvx");
            expectedOutput.Add("jmnpw");
            expectedOutput.Add("iopru");
            expectedOutput.Add("abkst");
            expectedOutput.Add("ejqrw");
            expectedOutput.Add("llegw");
            expectedOutput.Add("ooaiy");
            expectedOutput.Add("hknqr");

            // Act
            List<string> actualOutput = StringSorting.SortingOperations(inputStrings);
            WriteToConsole(inputStrings, actualOutput);
            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestSortingOperations5()
        {
            // Arrange
            List<string> inputStrings = new List<string>();
            inputStrings.Add("pzjim");
            inputStrings.Add("njnfq");
            inputStrings.Add("xyohs");

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("ijmpz");
            expectedOutput.Add("nnfjq");
            expectedOutput.Add("hosxy");

            // Act
            List<string> actualOutput = StringSorting.SortingOperations(inputStrings);
            WriteToConsole(inputStrings, actualOutput);
            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestSortingOperations6()
        {
            // Arrange
            List<string> inputStrings = new List<string>();
            inputStrings.Add("xqycs");
            inputStrings.Add("beoax");
            inputStrings.Add("afkso");
            inputStrings.Add("bldit");
            inputStrings.Add("gwrys");

            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("cqsxy");
            expectedOutput.Add("abeox");
            expectedOutput.Add("afkos");
            expectedOutput.Add("bdilt");
            expectedOutput.Add("grswy");

            // Act
            List<string> actualOutput = StringSorting.SortingOperations(inputStrings);
            WriteToConsole(inputStrings, actualOutput);
            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}