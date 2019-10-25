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
        public void WhenExecutingZero_ItShouldReturnZero()
        {
			var expected = 0;
			Assert.Equal(expected, Subject.Execute(0));
        }

		[Fact]
        public void WhenExecutingOne_ItShouldReturnOne()
        {
			var expected = 1;
			Assert.Equal(expected, Subject.Execute(1));
        }
    }
}
