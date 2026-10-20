using MetatraderLauncher.Presenters;

namespace MetatraderLauncher.Views;

public interface ITradeView
{
    public void SetPresenter(TradePresenter presenter);
}
