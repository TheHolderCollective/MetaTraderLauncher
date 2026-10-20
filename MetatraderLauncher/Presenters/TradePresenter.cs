using MetatraderLauncher.Views;
using MetatraderLauncher.Models; 

namespace MetatraderLauncher.Presenters;

public class TradePresenter
{
    private TradeView _view;
    private TradeModel _tradeModel;
    private LauncherModel _launcherModel;
    
    public TradePresenter(TradeModel tradeModel, LauncherModel launcherModel,TradeView view)
    {
        _tradeModel = tradeModel;
        _launcherModel = launcherModel;
        _view = view;
        _view.SetPresenter(this);
    }
}
