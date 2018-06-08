using System;
using System.Collections.Generic;
using System.Linq;
using DummyFramework.Core.Controls;

namespace AutomatedTests.Challenges
{
    public static class ArraysChallange
    {
        public static int? FindCenter(IEnumerable<IElement> rowCells)
        {
            var cellValues = rowCells.Select(x => Convert.ToInt32(x.Content)).ToArray();
            var totalSum = cellValues.Sum();
            var currSum = 0;
            var result = default(int?);

            for (var i = 0; i < cellValues.Length; i++)
            {
                var currVal = cellValues[i];
                currSum += cellValues[i];

                if (currSum - currVal == (totalSum - currVal) / 2)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}