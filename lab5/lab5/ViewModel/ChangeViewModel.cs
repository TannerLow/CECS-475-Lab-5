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
        private string enteredPId;
        /// <summary>
        /// The currently entered last name in the change window.
        /// </summary>
        private string enteredPName;
        /// <summary>
        /// The currently entered email in the change window.
        /// </summary>
        private int enteredAmount;
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
                Messenger.Default.Send(new MessageMember(EnteredPId, EnteredPName, EnteredAmount, "Update"));//NOT SURE ABOUT THIS, WAS UNDERLINED
                window.Close();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Entry Error");
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message, "Entry Error");
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "Entry Error");
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
                Messenger.Default.Send<NotificationMessage>(new NotificationMessage("Delete"));
                window.Close();
            }
        }
        /// <summary>
        /// Receives a member from the main VM to auto-fill the change box with the currently selected member.
        /// </summary>
        /// <param name="m">The member data to fill in.</param>
        public void GetSelected(Member m)
        {
            EnteredPId = m.ProductId;
            EnteredPName = m.ProductName;
            EnteredAmount = m.Quantity;
        }
        /// <summary>
        /// The currently entered first name in the change window.
        /// </summary>
        public string EnteredPId
        {
            get
            {
                return enteredPId;
            }
            set
            {
                enteredPId = value;
                RaisePropertyChanged("EnteredPId");
            }
        }

        /// <summary>
        /// The currently entered product name in the change window
        /// </summary>
        public string EnteredPName
        {
            get
            {
                return enteredPName;
            }
            set
            {
                enteredPName = value;
                RaisePropertyChanged("EnteredPName");
            }
        }

        
        /// <summary>
        /// The currently entered product quantity in the change window
        /// </summary>
        public int EnteredAmount
        {
            get
            {
                return enteredAmount;
            }
            set
            {
                enteredAmount = value;
                RaisePropertyChanged("EnteredAmount");
            }
        }
    }
}
