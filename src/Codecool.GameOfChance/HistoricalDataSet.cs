using System;
using System.Collections.Generic;
using System.IO;

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
            
            //HistoricalDataPoint
            
            int i = 0;
            List<int> indexes = new List<int>();
            
            while (i < 3)
            {
                var randomInt = random.Next(horses.Count);
                
                if (!indexes.Contains(randomInt))
                {
                    indexes.Add(randomInt);
                    
                    i++;
                }
            }

            List<string> data = new List<string>();
            foreach (var index in indexes)
            {
                data.Add(horses[index].Name);
            }

            _dataPoints = new List<HistoricalDataPoint>();
            
            _dataPoints.Add(new HistoricalDataPoint(data));

            using (StreamWriter writer = File.AppendText("history.csv"))
            {
                foreach (var element in _dataPoints)
                {
                    writer.WriteLine(element);
                }
            }
        }
        
    }
}
