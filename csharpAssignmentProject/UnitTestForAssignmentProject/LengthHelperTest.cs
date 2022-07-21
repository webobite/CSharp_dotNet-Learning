using csharpAssignmentProject;

namespace UnitTestForAssignmentProject
{
    public class LengthHelperTest
    {
        [Fact]
        public void FindStringLengthWithInputOfEmptyStringType()
        {
            string input = "";
            Assert.Equal(0, LengthHelper.FindStringLengthWithPredefinedMethod(input));
        }

        [Fact]
        public void FindStringLengthWithInputOfStringTypeContainingNumber()
        {
            string input1 = "123";
            string input2 = "123456789010";
            Assert.Equal(3, LengthHelper.FindStringLengthWithPredefinedMethod(input1));
            Assert.Equal(12, LengthHelper.FindStringLengthWithPredefinedMethod(input2));
        }

        [Fact]
        public void FindStringLengthWithInputOfNULLValue()
        {
            var exception = Assert.Throws<Exception>(() => LengthHelper.FindStringLengthWithPredefinedMethod(null));
            // checked the exception method message and expected that with the actual message
            Assert.Equal("Object reference not set to an instance of an object.", exception.Message);
        }


    }
}