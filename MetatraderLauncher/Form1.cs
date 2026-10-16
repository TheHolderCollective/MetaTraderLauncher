using MetatraderSharp.MetatraderClient;
using System.Diagnostics;

namespace MetatraderLauncher;

public partial class frm_Launcher : Form
{
    private List<Process> terminalProcesses = [];
    private bool[] terminalLaunched = new bool[3];
    private List<LaunchInfo> terminalLaunchInfo = [];

    private MT4Client terminal1;
    private MT4Client terminal2;
    private MT5Client terminal3;

    public frm_Launcher()
    {
        InitializeComponent();
        terminalLaunchInfo = CreateLaunchList();
        btn_LaunchAll.Select();
    }

    private async void btn_t1_Connect_Click(object sender, EventArgs e)
    {
        terminal1 = new MT4Client(terminalLaunchInfo[0].WebSocketPort);

        if (terminalLaunched[0])
        {

            if (terminal1.ClientStatusIsOK())
            {
                t1_Status.Text = "Connected";
            }
            else
            {
                t1_Status.Text = "Disconnected";
            }

            var accountInfo = await terminal1.GetAccountInfoAsync();
            var terminalInfo = await terminal1.GetTerminalInfoAsync();

            txt_t1_Name.Text = accountInfo.Name;
            txt_t1_Server.Text = accountInfo.Server;
            txt_t1_Login.Text = accountInfo.Login.ToString();
            txt_t1_Currency.Text = accountInfo.Currency;
            txt_t1_Balance.Text = accountInfo.Balance.ToString();
        }
        else
        {
            t1_Status.Text = "Disconnected";
            ClearTextBoxesTerminal1();
        }
    }

    private async void btn_t2_Connect_Click(object sender, EventArgs e)
    {
        terminal2 = new MT4Client(terminalLaunchInfo[1].WebSocketPort);

        if (terminalLaunched[1])
        {

            if (terminal2.ClientStatusIsOK())
            {
                t2_Status.Text = "Connected";
            }
            else
            {
                t2_Status.Text = "Disconnected";
            }

            var accountInfo = await terminal2.GetAccountInfoAsync();
            var terminalInfo = await terminal2.GetTerminalInfoAsync();

            txt_t2_Name.Text = accountInfo.Name;
            txt_t2_Server.Text = accountInfo.Server;
            txt_t2_Login.Text = accountInfo.Login.ToString();
            txt_t2_Currency.Text = accountInfo.Currency;
            txt_t2_Balance.Text = accountInfo.Balance.ToString();
        }
        else
        {
            t2_Status.Text = "Disconnected";
            ClearTextBoxesTerminal2();
        }
    }

    private async void btn_t3_Connect_Click_1(object sender, EventArgs e)
    {
        terminal3 = new MT5Client(terminalLaunchInfo[2].WebSocketPort);

        if (terminalLaunched[2])
        {

            if (terminal3.ClientStatusIsOK())
            {
                t3_Status.Text = "Connected";
            }
            else
            {
                t3_Status.Text = "Disconnected";
            }

            var accountInfo = await terminal3.GetAccountInfoAsync();
            var terminalInfo = await terminal3.GetTerminalInfoAsync();

            txt_t3_Name.Text = accountInfo.Name;
            txt_t3_Server.Text = accountInfo.Server;
            txt_t3_Login.Text = accountInfo.Login.ToString();
            txt_t3_Currency.Text = accountInfo.Currency;
            txt_t3_Balance.Text = accountInfo.Balance.ToString();
        }
        else
        {
            t3_Status.Text = "Disconnected";
            ClearTextBoxesTerminal3();
        }
    }

    private void SetAllStatuses(string status)
    {
        t1_Status.Text = status;
        t2_Status.Text = status;
        t3_Status.Text = status;
    }

    private void ClearAllTextBoxes()
    {
        ClearTextBoxesTerminal1();
        ClearTextBoxesTerminal2();
        ClearTextBoxesTerminal3();
    }

    private void ClearTextBoxesTerminal1()
    {
        txt_t1_Name.Clear();
        txt_t1_Server.Clear();
        txt_t1_Login.Clear();
        txt_t1_Currency.Clear();
        txt_t1_Balance.Clear();
    }

    private void ClearTextBoxesTerminal2()
    {
        txt_t2_Name.Clear();
        txt_t2_Server.Clear();
        txt_t2_Login.Clear();
        txt_t2_Currency.Clear();
        txt_t2_Balance.Clear();
    }

    private void ClearTextBoxesTerminal3()
    {
        txt_t3_Name.Clear();
        txt_t3_Server.Clear();
        txt_t3_Login.Clear();
        txt_t3_Currency.Clear();
        txt_t3_Balance.Clear();
    }

    private void btn_LaunchAll_Click(object sender, EventArgs e)
    {
        LaunchAllTerminals();
    }

    private void btn_KillAll_Click(object sender, EventArgs e)
    {
        KillAllTerminals();
    }

    private void LaunchAllTerminals()
    {
        terminalProcesses.Clear();

        for (int i = 0; i < terminalLaunchInfo.Count; i++)
        {
            if (terminalLaunchInfo[i].FileName is not null)
            {
                terminalProcesses.Add(Process.Start(terminalLaunchInfo[i].FileName));
                terminalLaunched[i] = true;
                Thread.Sleep(500);
            }
        }
    }

    private void KillAllTerminals()
    {
        for (int i = 0; i < terminalProcesses.Count; i++)
        {
            terminalProcesses[i].Kill();
            terminalLaunched[i] = false;
        }

        terminalProcesses.Clear();
        ClearAllTextBoxes();
        SetAllStatuses("Disconnected");
    }

    private List<LaunchInfo> CreateLaunchList()
    {
        List<LaunchInfo> launchList = [];


        LaunchInfo terminal1 = new()
        {
            TerminalType = "MT4",
            FileName = @"C:\Program Files (x86)\MetaTrader 4 Axi Terminal\terminal.exe",
            WebSocketPort = "81"
        };

        LaunchInfo terminal2 = new()
        {
            TerminalType = "MT4",
            FileName = @"C:\Program Files (x86)\OANDA - MetaTrader 4\terminal.exe",
            WebSocketPort = "82"
        };

        LaunchInfo terminal3 = new()
        {
            TerminalType = "MT5",
            FileName = @"C:\Program Files\LiteFinance MT5 Terminal\terminal64.exe",
            WebSocketPort = "83"
        };

        launchList.Add(terminal1);
        launchList.Add(terminal2);
        launchList.Add(terminal3);

        return launchList;
    }

    
}
