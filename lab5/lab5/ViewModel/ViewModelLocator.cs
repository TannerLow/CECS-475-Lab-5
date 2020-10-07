using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace lab5.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<AddViewModel>();
            SimpleIoc.Default.Register<ChangeViewModel>();
        }
        /// <summary>
        /// A property that lets the main window connect with its View Model.
        /// </summary>
        public MainViewModel Main
        {
            get
            {
            return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        /// <summary>
        /// A property that lets the add view window connect with its view model
        /// </summary>
        public AddViewModel AddViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddViewModel>();
            }
        }

        /// <summary>
        /// A property that lets the change view window connect with its view model.
        /// </summary>
        /// <param name="message"></param>
        public ChangeViewModel ChangeViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ChangeViewModel>();
            }
        }

        private void NotifyUserMethod(NotificationMessage message)
        {
            MessageBox.Show(message.Notification);
        }

        public static void Cleanup()
        {

        }
    }
}