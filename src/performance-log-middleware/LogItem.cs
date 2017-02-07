﻿namespace PerformanceLog
{
    public class LogItem
    {
        public long Duration { get; set; }
        public string Operation { get; set; }

        public string CorrelationId { get; set; }

        public override string ToString()
        {
            return $"Operation: {Operation}; Duration: {Duration}; CorrelationId: {CorrelationId}";
        }
    }
}