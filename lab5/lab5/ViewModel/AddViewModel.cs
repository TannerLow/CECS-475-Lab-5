﻿using GalaSoft.MvvmLight;
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
    /// The VM for adding users to the list.
    /// </summary>
    public class AddViewModel : ViewModelBase
    {
        /// <summary>
        /// The currently entered first name in the add window.
        /// </summary>
        private string enteredPId;
        /// <summary>
        /// The currently entered last name in the add window.
        /// </summary>
        private string enteredPName;
        /// <summary>
        /// The currently entered email in the add window.
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
                    Messenger.Default.Send("SaveMethod AddViewModel.cs");//NOT SURE ABOUT THIS, WAS AN UNDERLINE
                    window.Close();
                }
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
        /// Closes the window.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void CancelMethod(IClosable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        /// <summary>
        /// The currently entered first name in the add window.
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
        /// The currently entered first name in the add window.
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
        /// The currently entered first name in the add window.
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
