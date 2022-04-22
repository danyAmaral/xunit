using Xunit;

namespace CalculatorAPP.Test
{
    public  class NamesTest
    {
        [Fact]
        public void MakeFullName_GivenFirstNameAndLastName_returnFullName()
        {
            var names = new Names();
            var result = names.MakeFullName("danielle", "amaral");
            Assert.Equal("Danielle Amaral", result, ignoreCase: true);
        }

        [Fact]
        public void MakeFullNameWithRegularExpression_GivenFirstNameAndLastName_returnFullName()
        {
            var names = new Names();
            var result = names.MakeFullName("Danielle", "Amaral");
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void MakeFullNameWithSeparator_GivenFirstNameAndLastName_returnFullName()
        {
            var names = new Names();
            var result = names.MakeFullNameWithSeparator("Danielle", "Amaral");
            Assert.Matches("[A-Z]{1}[a-z]+[-]+[A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            Assert.Null(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("danielle", "amaral");
            Assert.True(!string.IsNullOrWhiteSpace(result));
        }


        [Fact]
        public void MakeFullName_AlwaysReturnValue2()
        {
            var names = new Names();
            var result = names.MakeFullName("danielle", "amaral");
            Assert.True(!string.IsNullOrWhiteSpace(result));
        }
    }
}
