using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetatraderLauncher.Models;

internal class LaunchInfo
{
    public string? FileName { get; set; }
    public string? NickName { get; set; }
    public string? TerminalType { get; set; }
    public string? WebSocketPort { get; set; }

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
}
