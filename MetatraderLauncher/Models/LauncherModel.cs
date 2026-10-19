using System.Diagnostics;

namespace MetatraderLauncher.Models;

public class LauncherModel
{
    private List<TerminalLaunchInfo> _launchInfo;

    public LauncherModel()
    {
        _launchInfo = CreateLaunchInfoList();
    }

    public void LaunchAllTerminals()
    {
        foreach (var info in _launchInfo)
        {
            if (info.FileName is not null && info.TerminalProcess is null)
            {
                info.TerminalProcess = Process.Start(info.FileName);
                info.Launched = info.TerminalProcess is not null ? true : false;
                Thread.Sleep(500);
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
        List<TerminalLaunchInfo> launchList = [];

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
