using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalcTest.IntegrationTest
{
    public class CalcTestIntegrationTest
    {
        [Fact]
        public async Task CalcTest_CalculaJuros()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync(string.Format("/api/calculajuros/{0}/{1}", 100, 5));

                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(response.StatusCode);
            }
        }
    }
}
