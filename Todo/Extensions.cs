using System;
using System.Threading;

namespace Todo
{
    public static class Extensions
    {
        public static void UntilSuccessful(Action operation, int timeout)
        {
            Exception exception = null;

            for (var i=0; i < timeout; i++)
            {
                try 
                {
                    operation();
                    return;
                }
                catch(Exception e)
                {
                    exception = e;
                    Thread.Sleep(10000);
                }
            }

            throw new Exception("Timeout waiting for operation", exception);
        }
    }
}