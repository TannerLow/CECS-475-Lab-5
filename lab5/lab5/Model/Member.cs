using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Model
{
    /// <summary>
    /// A class that represents a member of a gym.
    /// </summary>
    public class Member : ObservableObject
    {
        /// <summary>
        /// The member's first name.
        /// </summary>
        private string productId, productName;
        private int quantity;
        private const int TEXT_LIMIT = 10;
        
        /// <summary>
        /// The member's last name.
        /// </summary>
        public Member() { }
        /// <summary>
        /// Creates a new member.
        /// </summary>
        /// <param name="fName">The member's first name.</param>
        /// <param name="lName">The member's last name.</param>
        /// <param name="mail">The member's e-mail.</param>
        public Member(string pId, string pName, int amount)
        {
            productId = pId;
            productName = pName;
            quantity = amount;
        }

        /// <summary>
        ///  A property that gets or sets the member's first name, and makes sure it's not too long.
        /// </summary>
        public string ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                if (value.Length > TEXT_LIMIT)
                {
                    throw new ArgumentException("Too long");
                }
                if (value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                foreach(char c in value)
                {
                    if(c < '0' || c > '9')
                    {
                        throw new FormatException("Must be numeric");
                    }
                }
                productId = value;
            }

        }

        /// <summary>
        /// A property that gets or sets the member's last name, and makes sure it's not too long.
        /// </summary>
        /// <returns>The member's last name.</returns>
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                if (value.Length > TEXT_LIMIT)
                {
                    throw new ArgumentException("Too long");
                }
                if (value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                productName = value;
            }
        }
         /// <summary>
         /// A property that gets or sets the member's e-mail, and makes sure it's not too long.
         /// </summary>
         /// <returns>The member's e-mail.</returns>
         public int Quantity
         {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 6 || value > 99)
                {
                    throw new ArgumentException("Invalid Number");
                }
                quantity = value;
            }
         }
         /// <summary>
         /// Text to be displayed in the list box.
         /// </summary>
         /// <returns>A concatenation of the member's first name, last name, and email.</returns>
         public override string ToString()
         {
            return "ID: " + productId + ", " + "Name: " + productName + ", " + "Quantity: " + quantity;
         }
    }
}