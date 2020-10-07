using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab5.Model
{
    /// <summary>
    /// An extension of member that also includes a message for some sort of extra description.
    /// </summary>
    public class MessageMember : Member
    {
        /// <summary>
        /// Creates a new member.
        /// </summary>
        /// <param name="pId">The product's ID.</param>
        /// <param name="pName">The product's name.</param>
        /// <param name="amount">The product's quantity.</param>
        /// <param name="message">The extra description</param>
        public MessageMember(string pId, string pName, int amount, string message) :
            base(pId, pName, amount)
        {
            Message = message;
        }
        /// <summary>
        /// A property that includes the message.
        /// </summary>
        public string Message { get; private set; }
    }
}