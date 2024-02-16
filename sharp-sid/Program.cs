using System;
using System.Security.Principal;

namespace sharp_sid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unknownSID = args[0];
            string objSID = "";

            try
            {
                // create a user object and parse the unknown SID
                objSID = new SecurityIdentifier(unknownSID).Translate(typeof(NTAccount)).ToString();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            // write username to stdout
            Console.WriteLine(objSID);
        }
    }
}