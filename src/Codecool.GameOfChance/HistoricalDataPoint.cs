using System;
using System.Collections.Generic;

namespace Codecool.GameOfChance
{
    public class HistoricalDataPoint
    {
        private List<string> _rankingOfNameHorses;


        public HistoricalDataPoint(List<string> rankingOfNameHorses)
        {
            _rankingOfNameHorses = rankingOfNameHorses;
        }

        public override string ToString()
        {
            return String.Join(',' , _rankingOfNameHorses);
        }
    }
}
