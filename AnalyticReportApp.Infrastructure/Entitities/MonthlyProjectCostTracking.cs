using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class MonthlyProjectCostTracking
    {
        public long ExpenseId { get; set; }
        public string? ExpenseCategory { get; set; }
        public string? ExpenseName { get; set; }
        public string? OperationName { get; set; }
        public byte[]? OperationRate { get; set; }
        public long? HrsForWeek1 { get; set; }
        public long? HrsForWeek2 { get; set; }
        public long? HrsForWeek3 { get; set; }
        public long? HrsForWeek4 { get; set; }
        public long? HrsForWeek5 { get; set; }
        public long? HrsForWeek6 { get; set; }
        public long? HrsForWeek7 { get; set; }
        public long? HrsForWeek8 { get; set; }
    }
}
