﻿namespace Inklewriter.Runtime
{
    public class StoryException : System.Exception
    {
        public StoryException () { }
        public StoryException(string message) : base(message) {}
    }
}
