using CoreFinance.DataBrokers;
using Xunit;

namespace CoreFinance.Tests.DataBrokers;

public class YFinanceTests
{
    [Fact]
    public async Task RetrieveMSFT()
    {
        var yFinance = new YFinance("MSFT");
        var history = await yFinance.GetHistoryAsync(30);
        Assert.NotNull(history);
        Assert.NotEmpty(history);   
    }
}
