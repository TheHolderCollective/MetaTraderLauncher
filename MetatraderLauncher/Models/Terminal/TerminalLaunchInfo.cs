using System.Diagnostics;

namespace MetatraderLauncher.Models;

public class TerminalLaunchInfo
{
    public string? FileName { get; set; }
    public string? WebSocketPort { get; set; }
    public bool Launched { get; set; }
    public ClientType ClientType { get; set; }
    public TerminalID TerminalNumber { get; set; }
    public Process? TerminalProcess { get; set; }

    public TerminalLaunchInfo() { }

    public TerminalLaunchInfo(string fileName, ClientType clientType, string webSocketPort,TerminalID terminalNumber)
    {
        FileName = fileName;
        ClientType = clientType;
        WebSocketPort = webSocketPort;
        TerminalNumber = terminalNumber;
        Launched = false;
        TerminalProcess = null;
    }
}
