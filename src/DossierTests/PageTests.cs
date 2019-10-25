using Dossier;
using Xunit;

namespace DossierTests
{
	public class PageTests
    {
		public Page Subject { get; set; }

		public PageTests() => Subject = new Page();

		[Fact]
        public void WhenInitializing_ItShouldNotBeNull()
        {
			Assert.NotNull(Subject);
        }


		[Fact]
        public void WhenExecutingNull_ItShouldReturnZero()
        {
			var expected = 0;
			Assert.Equal(expected, Subject.Execute());
        }
    }
}
