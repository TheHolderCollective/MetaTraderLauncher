using MetatraderLauncher.Models;
using MetatraderLauncher.Views;

namespace MetatraderLauncher.Presenter;

public class LauncherPresenter
{
    private LauncherView _view;
    private LauncherModel _model;

    public LauncherPresenter(LauncherView view, LauncherModel model)
    {
        _model = model;
        _view = view;
        _view.SetPresenter(this);
    }

    public async Task UpdateAccountInfo(TerminalID terminalID)
    {
        AccountInfo accountInfo = await _model.GetAccountInfo(terminalID);
        _view.UpdateAccountInfo(terminalID, accountInfo);
        // add code to update terminal status
    }

    public async Task LaunchAllTerminals(bool connectOnLaunch = false)
    {
        _model.LaunchAllTerminals();

        if(connectOnLaunch)
        {
            await UpdateAccountInfo(TerminalID.Terminal1);
            await UpdateAccountInfo(TerminalID.Terminal2);
            await UpdateAccountInfo(TerminalID.Terminal3);
        }

        _view.BringViewToFront();
    }

    public void KillAllTerminals()
    {
        _model.KillAllTerminals();
        _view.ClearAccountInfo();
        // add code to update terminal statuses
    }
}
