using MetatraderLauncher.Models;
using MetatraderLauncher.Presenter;

namespace MetatraderLauncher.Views;

public interface ILauncherView
{
    public void SetPresenter(LauncherPresenter presenter);
    public void UpdateAccountInfo(TerminalID terminal, AccountInfo accountInfo);
    public void ClearAccountInfo();
    public void FocusView();
}
