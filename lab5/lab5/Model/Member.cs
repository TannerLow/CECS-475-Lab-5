using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Model
{
    /// <summary>
    /// A class that represents a product.
    /// </summary>
    public class Member : ObservableObject
    {
        /// <summary>
        /// The product's ID, Name and quantity.
        /// </summary>
        private string productId, productName;
        private int quantity;
        private const int TEXT_LIMIT = 10;
        
      
        /// <summary>
        /// Member object Constructor
        /// </summary>
        public Member() { }
        /// <summary>
        /// Overloaded Constructor for Member().
        /// </summary>
        /// <param name="pId">The product's ID.</param>
        /// <param name="pName">The product's name.</param>
        /// <param name="amount">The product's quantity.</param>
        public Member(string pId, string pName, int amount)
        {
            ProductId = pId;
            ProductName = pName;
            Quantity = amount;
        }

        /// <summary>
        ///  A property that gets or sets the product'd ID, and makes sure it's not too long.
        /// </summary>
        /// <returns>The product's ID</returns>
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
        /// A property that gets or sets the product's  name, and makes sure it's not too long.
        /// </summary>
        /// <returns>The product's name.</returns>
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
         /// A property that gets or sets the product's quantity and makes sure it's not too long.
         /// </summary>
         /// <returns>THe product's quantity</returns>
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
         /// <returns>A concatenation of the the product's ID, product's Name and product's quantity.</returns>
         public override string ToString()
         {
            return "ID: " + productId + ", " + "Name: " + productName + ", " + "Quantity: " + quantity;
         }
    }
}