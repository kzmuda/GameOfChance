using System;
using System.Collections.Generic;

namespace Codecool.GameOfChance
{
    public class HistoricalDataSet
    {
        public IReadOnlyList<HistoricalDataPoint> DataPoints
        {
            get => _dataPoints.AsReadOnly();
        }
        
        private ILogger _cl;
        private List<HistoricalDataPoint> _dataPoints;

        public HistoricalDataSet(ILogger logger)
        {
            _cl = logger;
        }

        public void Generate()
        {
            var horses = Horse.Read();

            var random = new Random();
            var randomNo = random.Next(horses.Count);
            
            HistoricalDataPoint
            
            int i = 0;
            while (i < 3)
            {
                horses[randomNo]
                i++;
            }
            
        }
        
    }
}
