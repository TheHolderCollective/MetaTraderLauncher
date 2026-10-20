using MetatraderLauncher.Views;
using MetatraderLauncher.Models;
using MetatraderLauncher.Presenters;

namespace MetatraderLauncher;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        LauncherModel model = new LauncherModel();
        LauncherView view = new LauncherView();
        LauncherPresenter presenter = new LauncherPresenter(view, model);
        view.SetPresenter(presenter);

        Application.Run(view);
    }
}