using MetatraderSharp.MTsocketAPI.Responses.Base;

namespace MetatraderLauncher.Models;

internal interface ITerminalClient
{
    public bool Connected { get; set; }

    public Task<MTsocketApiResponse> GetQuote(string symbol);
    public Task<MTsocketApiResponse> GetAccountInfo();
    public Task<MTsocketApiResponse> PlaceOrder(string symbol, string orderType, double volume, double price = 0.0, double stopLoss = 0.0, double takeProfit = 0.0);
    public Task<MTsocketApiResponse> CloseOrder(long ticketNumber);
    public Task<MTsocketApiResponse> TrackPricesStart(params string[] symbols);
    public Task<MTsocketApiResponse> TrackPricesStop();
}
