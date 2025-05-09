using Evertec.Template.Library;

namespace Evertec.Library.Tests
{
    public class LibraryClassTests
    {
        [Fact]
        public void SampleMethod_ShouldReturnTrue()
        {
            // Arrange  
            var LibraryClass = new LibraryClass();

            // Act  
            var result = LibraryClass.SampleMethod();

            // Assert  
            Assert.True(result);
        }
    }
}
