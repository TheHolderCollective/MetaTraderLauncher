namespace MetatraderLauncher.Models;

internal class LaunchInfo
{
    public string? NickName { get; set; }
    public string? TerminalType { get; set; }
    
    public string? FileName { get; set; }
    public string? WebSocketPort { get; set; }
    public ClientType ClientType { get; set; }

    public LaunchInfo()
    {

    }

    public LaunchInfo(string fileName, string nickName, string terminalType, string webSocketPort)
    {
        FileName = fileName;
        NickName = nickName;
        TerminalType = terminalType;
        WebSocketPort = webSocketPort;
    }

    public LaunchInfo(string fileName, ClientType clientType, string webSocketPort)
    {
        FileName = fileName;
        ClientType = clientType;
        WebSocketPort = webSocketPort;
    }


}
