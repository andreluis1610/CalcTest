using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace CalcTest.IntegrationTest
{
    public class CodeIntegrationTest
    {
        [Fact]
        public async Task Code_GetUrlCode()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/showmethecode");

                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(response.StatusCode);
            }
        }
    }
}
