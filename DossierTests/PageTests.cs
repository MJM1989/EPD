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
    }
}
