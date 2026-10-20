using MetatraderLauncher.Models;
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

    #region Interface methods

    public void SetPresenter(LauncherPresenter presenter)
    {
        _presenter = presenter;
    }

    public void UpdateAccountInfo(TerminalID terminalID, AccountInfo accountInfo)
    {
        switch (terminalID)
        {
            case TerminalID.Terminal1:
                UpdateTextBoxes(groupBox1, accountInfo);
                break;
            case TerminalID.Terminal2:
                UpdateTextBoxes(groupBox2, accountInfo);
                break;
            case TerminalID.Terminal3:
                UpdateTextBoxes(groupBox3, accountInfo);
                break;
        }
    }

    public void ClearAccountInfo()
    {
        ClearAllTextBoxes();
    }

    public void BringViewToFront()
    {
        this.TopMost = true;
    }

    #endregion

    #region Event handler methods

    private async void btn_LaunchAll_Click(object sender, EventArgs e)
    {
        await _presenter.LaunchAllTerminals(ckbx_Connect.Checked);
    }

    private void btn_KillAll_Click(object sender, EventArgs e)
    {
        _presenter.KillAllTerminals();
    }

    private async void btn_t1_Connect_Click(object sender, EventArgs e)
    {
        await _presenter.UpdateAccountInfo(TerminalID.Terminal1);
    }

    private async void btn_t2_Connect_Click(object sender, EventArgs e)
    {
        await _presenter.UpdateAccountInfo(TerminalID.Terminal2);
    }

    private async void btn_t3_Connect_Click(object sender, EventArgs e)
    {
        await _presenter.UpdateAccountInfo(TerminalID.Terminal3);
    }

    #endregion

    #region Helpers

    private static void UpdateTextBoxes(GroupBox grpBox, AccountInfo accountInfo)
    {
        foreach (var item in grpBox.Controls.OfType<TextBox>())
        {
            if (item.Name.Contains("_Server"))
                item.Text = accountInfo.Server;
            if (item.Name.Contains("_Login"))
                item.Text = accountInfo.Login;
            if (item.Name.Contains("_Currency"))
                item.Text = accountInfo.Currency;
            if (item.Name.Contains("_Balance"))
                item.Text = accountInfo.Balance;
            if (item.Name.Contains("_Equity"))
                item.Text = accountInfo.Equity;
            if (item.Name.Contains("_Profit"))
                item.Text = accountInfo.Profit;
        }
    }

    private void ClearAllTextBoxes()
    {
        ClearTextBoxes(groupBox2);
        ClearTextBoxes(groupBox3);
        ClearTextBoxes(groupBox1);
    }

    private static void ClearTextBoxes(GroupBox grpBox)
    {
        foreach (var item in grpBox.Controls.OfType<TextBox>())
        {
            item.Clear();
        }
    }

    #endregion
}
