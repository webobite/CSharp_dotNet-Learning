using assignment4;

namespace StringClassLibTest
{
    public class StringClassTest
    {
        [Fact]
        public void ToCurrency_With_input_as_Number_Content_as_StringType()
        {
            // Arrange
            string input = new string("123");
            string expectedOutput = "$123";
            // Act
            string output = StringHelper.ToCurrency(input);
            // Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void ToCurrency_With_input_as_String_Content_as_StringType()
        {
            // Arrange
            string input = new string("abc");
            string expectedOutput = "Parameter cannot be null or words which cannot be parsed in Integrer";
            // Act
            var output = Assert.Throws<ArgumentException>(() => StringHelper.ToCurrency(input));

            // Assert
            Assert.Equal(expectedOutput, output.Message);
        }

        [Fact]
        public void ToCurrency_With_input_as_Null_Content()
        {
            // Arrange
            string expectedOutput = "Parameter cannot be null or words which cannot be parsed in Integrer";
            // Act
            var output = Assert.Throws<ArgumentException>(() => StringHelper.ToCurrency(null));

            // Assert
            Assert.Equal(expectedOutput, output.Message);
        }
    }
}