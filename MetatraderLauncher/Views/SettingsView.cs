using MetatraderLauncher.Presenters;

namespace MetatraderLauncher.Views;

public partial class SettingsView : Form, ISettingsView
{
    SettingsPresenter _presenter;

    public SettingsView()
    {
        InitializeComponent();
    }

    #region Interface methods

    public void SetPresenter(SettingsPresenter presenter)
    {
        _presenter = presenter;
    }

    #endregion
}
