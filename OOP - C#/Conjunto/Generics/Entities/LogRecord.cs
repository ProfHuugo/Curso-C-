using System;
using System.Collections.Generic;

namespace Course.Entities
{
    public class LogRecord
    {
        public string Username { get; set; } = string.Empty;
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = (LogRecord)obj;
            return Username.Equals(other.Username);

        }
    }
}
