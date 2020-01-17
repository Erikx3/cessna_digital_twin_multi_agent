namespace cessna_digital_twin {
	using System;
	using System.Linq;
	using System.Collections.Generic;
	// Pragma and ReSharper disable all warnings for generated code
	#pragma warning disable 162
	#pragma warning disable 219
	#pragma warning disable 169
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "UnusedParameter.Local")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "ExpressionIsAlwaysNull")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "MemberInitializerValueIgnored")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantCheckBeforeAssignment")]
	public class Formula {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(Formula));
		private readonly System.Random _Random = new System.Random();
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double haversine(System.Tuple<double,double> point1, System.Tuple<double,double> point2) 
		{
			{
			double deg_to_rad_factor = Mars.Components.Common.Constants.Pi / 180;
			double lon1 = point1.Item1
			 * deg_to_rad_factor;
			double lat1 = point1.Item2
			 * deg_to_rad_factor;
			double lon2 = point2.Item1
			 * deg_to_rad_factor;
			double lat2 = point2.Item2
			 * deg_to_rad_factor;
			double dlon = lon2 - lon1;
			double dlat = lat2 - lat1;
			double summand1 = Mars.Components.Common.Math.Pow((Mars.Components.Common.Math.Sin(dlat / 2)
			), 2);
			double factor1 = Mars.Components.Common.Math.Cos(lat1);
			double factor2 = Mars.Components.Common.Math.Cos(lat2);
			double factor3 = Mars.Components.Common.Math.Pow((Mars.Components.Common.Math.Sin(dlon / 2)
			), 2);
			double a = summand1 + (factor1 * factor2 * factor3);
			double c = 2 * Mars.Components.Common.Math.Atan2(Mars.Components.Common.Math.Pow(a, 0.5),Mars.Components.Common.Math.Pow((1 - a), 0.5));
			int r = 6371000;
			return c * r
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double bearing(System.Tuple<double,double> point1, System.Tuple<double,double> point2) 
		{
			{
			double deg_to_rad_factor = Mars.Components.Common.Constants.Pi / 180;
			double rad_to_deg_factor = 180 / Mars.Components.Common.Constants.Pi;
			double lon1 = point1.Item1
			 * deg_to_rad_factor;
			double lat1 = point1.Item2
			 * deg_to_rad_factor;
			double lon2 = point2.Item1
			 * deg_to_rad_factor;
			double lat2 = point2.Item2
			 * deg_to_rad_factor;
			double dlon = lon2 - lon1;
			double y = Mars.Components.Common.Math.Sin(dlon)
			 * Mars.Components.Common.Math.Cos(lat2);
			double x1 = Mars.Components.Common.Math.Cos(lat1)
			 * Mars.Components.Common.Math.Sin(lat2);
			double x2 = Mars.Components.Common.Math.Sin(lat1)
			 * Mars.Components.Common.Math.Cos(lat2);
			double x3 = Mars.Components.Common.Math.Cos(dlon);
			double x = x1 - x2 * x3;
			double bearing = Mars.Components.Common.Math.Atan2(y,x)
			 * rad_to_deg_factor;
			bearing = (bearing + 360) % 360;
			return bearing
			;}
			return default(double);;
		}
	}
}
