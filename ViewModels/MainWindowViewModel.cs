using System.Windows.Input;
using ReactiveUI;

namespace Avalonia.MusicStore.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            BuyMusicCommand() = ReactiveCommand.Create(() =>
            {
                
            });
        }
        
        public ICommand BuyMusicCommand { get; }
    }
}