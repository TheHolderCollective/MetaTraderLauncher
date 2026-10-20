using MetatraderLauncher.Presenters;

namespace MetatraderLauncher.Views;

public partial class TradeView : Form
{
    private TradePresenter _presenter;

    public TradeView()
    {
        InitializeComponent();
    }

    #region Interface methods

    public void SetPresenter(TradePresenter presenter)
    {
        _presenter = presenter;
    }

    #endregion
}
