﻿    using System;
    namespace mallgate
    {
	    public class Friend {

            public string firstName { get; set; }

            public string lastName { get; set; }
            public string location { get; set; }

        public Friend(string firstName, string lastName, string location)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.location = location;
        }
    }
    }

