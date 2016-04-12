using System;
using System.ComponentModel;

namespace SwedishFramework
{
    public class SwedishBoolean
    {
        public enum Status
        {
            Sant,
            Falskt,
            Ibland,
            Kanske,
            Lagom
        }
        
        private Status _status;

        private SwedishBoolean() { }

        public SwedishBoolean(Status status)
        {
            _status = status;
        }

        public bool GetAnswer()
        {
            switch (_status)
            {
                case Status.Sant:
                    return true;
                case Status.Falskt:
                    return false;
                case Status.Ibland:
                    if (new Random().Next(1, 100) >= 90)
                        return true;
                    else
                        return false;
                case Status.Kanske:
                    if (new Random().Next(1, 100) == 100)
                        return true;
                    else
                        return false;
                case Status.Lagom:
                    if (new Random().Next(1, 100) >= 50)
                        return true;
                    else
                        return false;

            }
            throw new InvalidEnumArgumentException();
        }
    }
}
