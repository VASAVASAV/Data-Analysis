using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thing_2._1
{
	class ComputingTools
	{
		double FindStandDev(List<double> target)
		{
			double ExpectedVal = 0;
			int i = 0;
			for (i = 0; i < target.Count; i++)
			{
				ExpectedVal += target[i];
			}
			ExpectedVal /= target.Count;
			double result = 0;
			for (i = 0; i < target.Count; i++)
			{
				result += Math.Pow((target[i] - ExpectedVal),2);
			}
			result /= target.Count - 1;
			return result;
		}
	}
}
