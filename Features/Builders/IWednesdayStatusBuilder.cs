using WednesdayAlerts.Models;

namespace WednesdayAlerts.Features.Builders
{
    /// <summary>
    /// Produces a WednesdayStatus by examining the current day of the week
    /// and returns the appropriate status.
    /// </summary>
    public interface IWednesdayStatusBuilder
    {
        /// <summary>
        /// Creates a WednesdayStatus based on the day of the week.
        /// </summary>
        /// <returns>Whether it is Wednesday or not (my dudes)</returns>
        WednesdayStatus BuildWednesdayStatus();
    }
}