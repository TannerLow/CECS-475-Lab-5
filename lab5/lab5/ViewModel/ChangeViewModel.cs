using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using lab5.Model;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
namespace lab5.ViewModel
{
    /// <summary>
    /// The VM for modifying or removing users.
    /// </summary>
    public class ChangeViewModel : ViewModelBase
    {
        /// <summary>
        /// The currently entered first name in the change window.
        /// </summary>
        private string productId;
        /// <summary>
        /// The currently entered last name in the change window.
        /// </summary>
        private string productName;
        /// <summary>
        /// The currently entered email in the change window.
        /// </summary>
        private int quantity;
        /// <summary>
        /// Initializes a new instance of the ChangeViewModel class.
        /// </summary>
        public ChangeViewModel()
        {
            UpdateCommand = new RelayCommand<IClosable>(UpdateMethod);
            DeleteCommand = new RelayCommand<IClosable>(DeleteMethod);
            Messenger.Default.Register<Member>(this, GetSelected);//NOT SURE ABOUT THIS, WAS UNDERLINE
        }
        /// <summary>
        /// The command that triggers saving the filled out member data.
        /// </summary>
        public ICommand UpdateCommand { get; private set; }
        /// <summary>
        /// The command that triggers removing the previously selected user.
        /// </summary>
        public ICommand DeleteCommand { get; private set; }
        /// <summary>
        /// Sends a valid member to the main VM to replace at the selected index with, then closes the change window.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void UpdateMethod(IClosable window)
        {
            try
            {
                Messenger.Default.Send(new MessageMember(ProductId, ProductName, Quantity, "update"));//NOT SURE ABOUT THIS, WAS UNDERLINED
                window.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Fields must be under 25 characters.", "Entry Error");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Fields cannot be empty.", "Entry Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("Must be a valid e-mail address.", "Entry Error");
            }
        }
        /// <summary>
        /// Sends out a message to initiate closing the change window.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void DeleteMethod(IClosable window)
        {
            if (window != null)
            {
                Messenger.Default.Send<NotificationMessage>(new NotificationMessage("DeleteMethod ChangeViewModel.cs"));
                window.Close();
            }
        }
        /// <summary>
        /// Receives a member from the main VM to auto-fill the change box with the currently selected member.
        /// </summary>
        /// <param name="m">The member data to fill in.</param>
        public void GetSelected(Member m)
        {
            productId = m.ProductId;
            productName = m.ProductName;
            quantity = m.Quantity;
        }
        /// <summary>
        /// The currently entered first name in the change window.
        /// </summary>
        public string ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                ProductId = value;
                RaisePropertyChanged("ProductID");
            }
        }

        /// <summary>
        /// The currently entered product name in the change window
        /// </summary>
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                ProductName = value;
                RaisePropertyChanged("ProductName");
            }
        }

        
        /// <summary>
        /// The currently entered product quantity in the change window
        /// </summary>
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }
    }
}
