namespace ThoughtfulAutomationSort.Domain.Test
{
    using System;

    public static class Record
    {
        public static Exception Exception(Action action)
        {
            // Normally would use xUnit but using MsTest for ease of review, needed this logic from xUnit.

            if (action == null)
            {
                throw new InvalidOperationException("Invalid setup, missing action.");
            }

            try
            {
                action();
            }
            catch (Exception ex)
            {
                return ex;
            }

            throw new InvalidOperationException("Expected exception and none thrown.");
        }
    }
}
