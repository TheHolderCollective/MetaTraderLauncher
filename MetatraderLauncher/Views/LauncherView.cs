using MetatraderLauncher.Presenter;

namespace MetatraderLauncher.Views;

public partial class LauncherView : Form, ILauncherView
{
    private LauncherPresenter _presenter;

    public LauncherView()
    {
        InitializeComponent();
        btn_LaunchAll.Select();
    }

    public void SetPresenter(LauncherPresenter presenter)
    {
        _presenter = presenter;
    }

    private void btn_LaunchAll_Click(object sender, EventArgs e)
    {
        _presenter.LaunchAllTerminals();
    }

    private void btn_KillAll_Click(object sender, EventArgs e)
    {
        _presenter.KillAllTerminals();
    }


    private async void btn_t1_Connect_Click(object sender, EventArgs e)
    {
        //if (terminalLaunched[0])
        //{
        //    terminal1 = new MT4Client(terminalLaunchInfo[0].WebSocketPort);

        //    if (terminal1.ClientStatusIsOK())
        //    {
        //        t1_Status.Text = "Connected";
        //    }
        //    else
        //    {
        //        t1_Status.Text = "Disconnected";
        //        return;
        //    }

        //    var accountInfo = await terminal1.GetAccountInfoAsync();
        //    var terminalInfo = await terminal1.GetTerminalInfoAsync();

        //    txt_t1_Name.Text = accountInfo.Name;
        //    txt_t1_Server.Text = accountInfo.Server;
        //    txt_t1_Login.Text = accountInfo.Login.ToString();
        //    txt_t1_Currency.Text = accountInfo.Currency;
        //    txt_t1_Balance.Text = accountInfo.Balance.ToString();
        //}
        //else
        //{
        //    t1_Status.Text = "Disconnected";
        //    ClearTextBoxes(groupBox1);
        //}
    }

    private async void btn_t2_Connect_Click(object sender, EventArgs e)
    {
       
    }

    private async void btn_t3_Connect_Click(object sender, EventArgs e)
    {
     
    }

    private void SetAllStatuses(string status)
    {
        t1_Status.Text = status;
        t2_Status.Text = status;
        t3_Status.Text = status;
    }

    private void ClearAllTextBoxes()
    {
        ClearTextBoxes(groupBox1);
        ClearTextBoxes(groupBox2);
        ClearTextBoxes(groupBox3);
    }

    private void ClearTextBoxes(GroupBox grpBox)
    {
        foreach (var item in grpBox.Controls.OfType<TextBox>())
        {
            item.Clear();
        }
    }
}
