using MetatraderSharp;
using MetatraderSharp.MetatraderClient;
using MetatraderSharp.MTsocketAPI.Responses.Base;
using MetatraderSharp.MTsocketAPI.Responses.Common;
using MetatraderSharp.MTsocketAPI.Responses.MT4;

namespace MetatraderLauncher.Models;

public enum ClientType
{
    MT4,
    MT5
}

internal class TerminalClient : ITerminalClient
{
    private MT4Client _mt4Client;
    private MT5Client _mt5Client;
    private ClientType _clientType;

    public bool Connected { get; set; }

    public TerminalClient(ClientType clientType, string webSocketPort)
    {
        _clientType = clientType;

        switch (clientType)
        {
            case ClientType.MT4:
                _mt4Client = new MT4Client(webSocketPort);
                Connected = _mt4Client.ClientStatusIsOK();
                break;
            case ClientType.MT5:
                _mt5Client = new MT5Client(webSocketPort);
                Connected = _mt5Client.ClientStatusIsOK();
                break;
        }
    }

    public async Task<MTsocketApiResponse> GetAccountInfo()
    {
        MTsocketApiResponse response = new Account();

        switch (_clientType)
        {
            case ClientType.MT4:
                response = await _mt4Client.GetAccountInfoAsync();
                break;
            case ClientType.MT5:
                response = await _mt5Client.GetAccountInfoAsync();
                break;
        }

        return response;
    }

    public async Task<MTsocketApiResponse> GetQuote(string symbol)
    {
        MTsocketApiResponse response = new Quote();

        switch (_clientType)
        {
            case ClientType.MT4:
                response = await _mt4Client.GetQuoteAsync(symbol);
                break;
            case ClientType.MT5:
                response = await _mt5Client.GetQuoteAsync(symbol);
                break;
        }

        return response;
    }

    public async Task<MTsocketApiResponse> PlaceOrder(string symbol, string orderType, double volume, double price = 0.0, double stopLoss = 0.0, double takeProfit = 0.0)
    {
        MTsocketApiResponse response = new OrderSendResponse();

        switch (_clientType)
        {
            case ClientType.MT4:
                response = await _mt4Client.PlaceOrderAsync(symbol, orderType, volume, price, stopLoss, takeProfit, comment: "Metatrader Launcher");
                break;
            case ClientType.MT5:
                response = await _mt5Client.PlaceOrderAsync(symbol, orderType, volume, false, price, stopLoss, takeProfit, comment: "Metatrader Launcher");
                break;
        }

        return response;
    }

    public async Task<MTsocketApiResponse> CloseOrder(long ticketNumber)
    {
        MTsocketApiResponse response = new OrderCloseResponse();

        switch (_clientType)
        {
            case ClientType.MT4:
                response = await _mt4Client.CloseOrderAsync(ticketNumber);
                break;
            case ClientType.MT5:
                response = await _mt5Client.CloseOrderAsync(ticketNumber);
                break;
        }

        return response;
    }

    public async Task<MTsocketApiResponse> TrackPricesStart(params string[] symbols)
    {
        MTsocketApiResponse response = new TrackResponse();

        switch (_clientType)
        {
            case ClientType.MT4:
                response = await _mt4Client.TrackPricesAsync(TrackingCommand.Start, symbols);
                break;
            case ClientType.MT5:
                response = await _mt5Client.TrackPricesAsync(TrackingCommand.Start, symbols);
                break;
        }

        return response;
    }

    public async Task<MTsocketApiResponse> TrackPricesStop()
    {
        MTsocketApiResponse response = new TrackResponse();

        switch (_clientType)
        {
            case ClientType.MT4:
                response = await _mt4Client.TrackPricesAsync(TrackingCommand.Stop);
                break;
            case ClientType.MT5:
                response = await _mt5Client.TrackPricesAsync(TrackingCommand.Stop);
                break;
        }

        return response;
    }

}
