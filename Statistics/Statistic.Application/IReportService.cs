using Statistic.Domain;
using System.Collections.Generic;

namespace Statistic.Application
{
   public interface IReportService
    {
        IList<Report> GetReport();
    }
}
