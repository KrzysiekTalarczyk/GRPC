using Statistic.Domain;
using System.Collections.Generic;

namespace Statistic.Application
{
    public class ReportService : IReportService
    {

        public IList<Report> GetReport()
        {
            return new List<Report>() { new Report(), new Report() };
        }
    }
}
