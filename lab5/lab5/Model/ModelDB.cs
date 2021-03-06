﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Model
{
    /// <summary>
    /// A class that uses a text file to store information about the product objects longterm.
    /// </summary>
    class MemberDB : ObservableObject
    {
        /// <summary>
        /// The list of members to be saved.
        /// </summary>
        private ObservableCollection<Member> members;
        /// <summary>
        /// Where the database is stored.
        /// </summary>
        private const string filepath = "../members.txt";
        /// <summary>
        /// Creates a new member database.
        /// </summary>
        /// <param name="m">The list to saved from or written to.</param>
        public MemberDB(ObservableCollection<Member> m)
        {
            members = m;
        }
        /// <summary>
        /// Reads the saved text file database into the program's list of members.
        /// </summary>
        /// <returns>The list containing the text file data read in.</returns>
        public ObservableCollection<Member> GetMemberships()
        {
            try
            {
                StreamReader input = new StreamReader(new FileStream(filepath,
                FileMode.OpenOrCreate, FileAccess.Read));
                string[] delimiter = { "#" };

                while(input.Peek() != -1)
                {
                    string line = input.ReadLine();
                    string[] entry = line.Split(delimiter, System.StringSplitOptions.RemoveEmptyEntries);
                    members.Add(new Member(entry[0], entry[1], Int32.Parse(entry[2])));
                }
                input.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid product quantity.");
            }
            return members;
        }
        /// <summary>
        /// Saves the program's list of members into the text file database.
        /// </summary>
        public void SaveMemberships()
        {
            StreamWriter output = new StreamWriter(new FileStream(filepath,
           FileMode.Create, FileAccess.Write));
            foreach(Member m in members)
            {
                output.Write(m.ProductId + "#");
                output.Write(m.ProductName + "#");
                output.Write(m.Quantity + "#");
                output.WriteLine();
            }
            output.Close();
        }
    }
}

