using GalaSoft.MvvmLight;
using MessengerControlPanel;
using MessengerViewer;

namespace MessengerExpore.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            /// 
            ControlPanelViewModel = new MessengerControlPanelViewModel();
            Viewer1ViewModel = new MessengerViewerViewModel();
            Viewer2ViewModel = new MessengerViewerViewModel();
        }

        public MessengerControlPanelViewModel ControlPanelViewModel { get; private set; }
        public MessengerViewerViewModel Viewer1ViewModel { get; private set; }
        public MessengerViewerViewModel Viewer2ViewModel { get; private set; }
    }
}