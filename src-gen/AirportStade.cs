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
	public class AirportStade {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(AirportStade));
		private readonly System.Random _Random = new System.Random();
		private Mars.Components.Common.MarsList<System.Tuple<double,double>> __taxipath
			 = default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);
		internal Mars.Components.Common.MarsList<System.Tuple<double,double>> taxipath { 
			get { return __taxipath; }
			set{
				if(__taxipath != value) __taxipath = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public Mars.Components.Common.MarsList<System.Tuple<double,double>> Get_taxipath_to_TakeOffPreparationPoint(int heading) 
		{
			{
			if(Equals(heading, 107)) {
							{
							taxipath = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(9.4994287,53.5604441),new System.Tuple<double,double>(9.4934248,53.5617509),new System.Tuple<double,double>(9.4931937,53.5618008),new System.Tuple<double,double>(9.4930632,53.5618664) });
							return taxipath
							;}
					;} else {
							if(Equals(heading, 287)) {
											{
											taxipath = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(9.4994287,53.5604441),new System.Tuple<double,double>(9.5010603,53.5600816),new System.Tuple<double,double>(9.5018283,53.559911),new System.Tuple<double,double>(9.5041687,53.5594248),new System.Tuple<double,double>(9.5043157,53.5594584) });
											return taxipath
											;}
									;} 
						;}
			;}
			return default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public Mars.Components.Common.MarsList<System.Tuple<double,double>> Get_taxipath_to_RunwayHoldShortPoint(int heading) 
		{
			{
			if(Equals(heading, 107)) {
							{
							taxipath = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(9.4930632,53.5618664),new System.Tuple<double,double>(9.4930261,53.5619488),new System.Tuple<double,double>(9.4930324,53.562018),new System.Tuple<double,double>(9.4930903,53.5620665),new System.Tuple<double,double>(9.4931671,53.5621049),new System.Tuple<double,double>(9.4932789,53.5621333),new System.Tuple<double,double>(9.493448,53.5621513),new System.Tuple<double,double>(9.4936651,53.5621639),new System.Tuple<double,double>(9.4939417,53.562171) });
							return taxipath
							;}
					;} else {
							if(Equals(heading, 287)) {
											{
											taxipath = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(9.5043157,53.5594584),new System.Tuple<double,double>(9.5044877,53.5595613),new System.Tuple<double,double>(9.5046714,53.5597239) });
											return taxipath
											;}
									;} 
						;}
			;}
			return default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public Mars.Components.Common.MarsList<System.Tuple<double,double>> Get_taxipath_to_RunwayLineUpPoint(int heading) 
		{
			{
			if(Equals(heading, 107)) {
							{
							taxipath = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(9.4939417,53.562171),new System.Tuple<double,double>(9.494201,53.5621611),new System.Tuple<double,double>(9.494446,53.5621252) });
							return taxipath
							;}
					;} else {
							if(Equals(heading, 287)) {
											{
											taxipath = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(9.5046714,53.5597239),new System.Tuple<double,double>(9.5048527,53.5598626),new System.Tuple<double,double>(9.5028175,53.5603097) });
											return taxipath
											;}
									;} 
						;}
			;}
			return default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);;
		}
	}
}