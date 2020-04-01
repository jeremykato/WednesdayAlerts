using System;
using WednesdayAlerts.Models;

namespace WednesdayAlerts.Features.Builders
{
    public class WednesdayStatusBuilder : IWednesdayStatusBuilder
    {
        public WednesdayStatus BuildWednesdayStatus()
        {
            var currentDayOfWeek = DateTime.Now.DayOfWeek;

            if (currentDayOfWeek == DayOfWeek.Wednesday)
            {
                return new WednesdayStatus
                {
                    IsWednesday = true,
                    Message = "It is Wednesday, my dudes"
                };
            }

            return new WednesdayStatus
            {
                IsWednesday = false,
                Message = "It is not Wednesday, my dudes"
            };
        }
    }
}