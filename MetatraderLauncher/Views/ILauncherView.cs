using MetatraderLauncher.Models;
using MetatraderLauncher.Presenters;

namespace MetatraderLauncher.Views;

public interface ILauncherView
{
    public void SetPresenter(LauncherPresenter presenter);
    public void UpdateAccountInfo(TerminalID terminalID, AccountInfo accountInfo);
    public void ClearAccountInfo();
    public void BringViewToFront();
    public void LaunchTradeView(TerminalID terminalID,LauncherModel launcherModel);
}
