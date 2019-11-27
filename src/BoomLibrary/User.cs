using System.Collections.Generic;
using System;

namespace BoomLibrary
{
    [Serializable]
    public class User
    {
        private string name;
        private int boomSum;
        // TODO: Id Guid  
        private List<Note> notes = new List<Note>();       
        // Konstruktor
        static void CreatUser()
        {
            var user = new User();
        }
    }
}
