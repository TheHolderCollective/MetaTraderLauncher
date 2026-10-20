using System.Diagnostics;
using MT4 = MetatraderSharp.MTsocketAPI.Responses.MT4;
using MT5 = MetatraderSharp.MTsocketAPI.Responses.MT5;

namespace MetatraderLauncher.Models;

public class LauncherModel
{
    private List<TerminalLaunchInfo> _launchInfo;
 
    public LauncherModel()
    {
        _launchInfo = CreateLaunchInfoList();
    }

    public async Task<AccountInfo> GetAccountInfo(TerminalID terminalID)
    {
        AccountInfo accountInfo = new();
        TerminalLaunchInfo terminalInfo = _launchInfo.Where(x => x.TerminalNumber == terminalID).Single();
      
        if (terminalInfo.Launched == true)
        {
            terminalInfo.Client = new TerminalClient(terminalInfo.ClientType, terminalInfo.WebSocketPort);

            if (terminalInfo.Client.Connected)
            {
                if (terminalInfo.Client.ClientType == ClientType.MT4)
                {
                    var info = (MT4.Account)await terminalInfo.Client.GetAccountInfo();

                    accountInfo.Name = info.Name;
                    accountInfo.Server = info.Server;
                    accountInfo.Login = info.Login.ToString();
                    accountInfo.Currency = info.Currency;
                    accountInfo.Balance = info.Balance.ToString();
                    accountInfo.Equity = info.Equity.ToString();
                    accountInfo.Profit = info.Profit.ToString();
                }
                else if (terminalInfo.Client.ClientType == ClientType.MT5)
                {
                    var info = (MT5.Account)await terminalInfo.Client.GetAccountInfo();

                    accountInfo.Name = info.Name;
                    accountInfo.Server = info.Server;
                    accountInfo.Login = info.Login.ToString();
                    accountInfo.Currency = info.Currency;
                    accountInfo.Balance = info.Balance.ToString();
                    accountInfo.Equity = info.Equity.ToString();
                    accountInfo.Profit = info.Profit.ToString();
                }
            }
        }

        return accountInfo;
    }

    public void LaunchAllTerminals()
    {
        foreach (var info in _launchInfo)
        {
            if (info.FileName is not null && info.TerminalProcess is null)
            {
                info.TerminalProcess = Process.Start(info.FileName);
                info.Launched = info.TerminalProcess is not null ? true : false;
                Thread.Sleep(650); // this gives the terminals time to load 
            }
        }
    }

    public void KillAllTerminals()
    {
        foreach (var info in _launchInfo)
        {
            if (info.TerminalProcess is not null)
            {
                info.TerminalProcess.Kill();
                info.TerminalProcess = null;
                info.Launched = false;
            }
        }
    }

    private List<TerminalLaunchInfo> CreateLaunchInfoList()
    {
        List<TerminalLaunchInfo> launchList = new();

        TerminalLaunchInfo terminal1 = new()
        {
            ClientType = ClientType.MT4,
            TerminalNumber = TerminalID.Terminal1,
            FileName = @"C:\Program Files (x86)\MetaTrader 4 Axi Terminal\terminal.exe",
            WebSocketPort = "81",
            Launched = false
        };

        TerminalLaunchInfo terminal2 = new()
        {
            ClientType = ClientType.MT4,
            TerminalNumber = TerminalID.Terminal2,
            FileName = @"C:\Program Files (x86)\OANDA - MetaTrader 4\terminal.exe",
            WebSocketPort = "82",
            Launched = false
        };

        TerminalLaunchInfo terminal3 = new()
        {
            ClientType = ClientType.MT5,
            TerminalNumber = TerminalID.Terminal3,
            FileName = @"C:\Program Files\Axi MetaTrader 5 Terminal\terminal64.exe",
            WebSocketPort = "83",
            Launched = false
        };

        launchList.Add(terminal1);
        launchList.Add(terminal2);
        launchList.Add(terminal3);

        return launchList;
    }
}
