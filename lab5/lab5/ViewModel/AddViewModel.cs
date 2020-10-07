using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using lab5.Model;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;
namespace lab5.ViewModel
{
    /// <summary>
    /// The VM for adding products to the list.
    /// </summary>
    public class AddViewModel : ViewModelBase
    {
        /// <summary>
        /// The currently entered product ID in the add window.
        /// </summary>
        private string enteredPId;
        /// <summary>
        /// The currently entered product name in the add window.
        /// </summary>
        private string enteredPName;
        /// <summary>
        /// The currently entered amount in the add window.
        /// </summary>
        private int enteredAmount;
        /// <summary>
        /// Initializes a new instance of the AddViewModel class.
        /// </summary>
        public AddViewModel()
        {
            SaveCommand = new RelayCommand<IClosable>(SaveMethod);
            CancelCommand = new RelayCommand<IClosable>(CancelMethod);
        }
        /// <summary>
        /// The command that triggers saving the filled out member data.
        /// </summary>
        public ICommand SaveCommand { get; private set; }
        /// <summary>
        /// The command that triggers closing the add window.
        /// </summary>
        public ICommand CancelCommand { get; private set; }
        /// <summary>
        /// Sends a valid member to the Main VM to add to the list, then closes the window.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void SaveMethod(IClosable window)
        {
            try
            {
                if (window != null)
                {
                    Messenger.Default.Send<MessageMember>(new MessageMember(EnteredPId, EnteredPName, EnteredAmount, "Add"));
                    ClearFields();
                    window.Close();
                }
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
        /// Closes the window.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void CancelMethod(IClosable window)
        {
            if (window != null)
            {
                ClearFields();
                window.Close();
            }
        }
        /// <summary>
        /// The currently entered product ID in the add window.
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
        /// The currently entered product's name in the add window.
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
        /// The currently entered amount in the add window.
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

        private void ClearFields()
        {
            EnteredPId = "";
            EnteredPName =  "";
            EnteredAmount = 0;        
        }

    }
}
