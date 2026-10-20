using MetatraderLauncher.Views;
using MetatraderLauncher.Models;

namespace MetatraderLauncher.Presenters;

public class SettingsPresenter
{
    private SettingsView _view;
    private SettingsModel _model;

    public SettingsPresenter(SettingsModel model, SettingsView view)
    {
        _model = model;
        _view = view;
        _view.SetPresenter(this);
    }
}
