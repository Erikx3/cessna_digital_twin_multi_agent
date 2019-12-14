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
	public class Aircraft : Mars.Interfaces.Agent.IMarsDslAgent {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(Aircraft));
		private readonly System.Random _Random = new System.Random();
		private double __Failure
			 = 0.0;
		public double Failure { 
			get { return __Failure; }
			set{
				if(System.Math.Abs(__Failure - value) > 0.0000001) __Failure = value;
			}
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AirportStadeLayer _AirportStadeLayer { get; set; }
		public cessna_digital_twin.AirportStadeLayer airportstadelayer => _AirportStadeLayer;
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Aircraft (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment,
		cessna_digital_twin.AirportStadeLayer _AirportStadeLayer
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this._AirportStadeLayer = _AirportStadeLayer;
			_AgentLayer._AircraftEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget14_240 = new System.Tuple<double,double>(9.4987928,53.560392);
				
				var _object14_240 = this;
				
				_AgentLayer._AircraftEnvironment.PosAt(_object14_240, 
					_taget14_240.Item1, _taget14_240.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke()
					;
			}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			System.Console.WriteLine("Stepcounter: " + (int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep);;
			Failure = Failure + 0.1;
			Mars.Components.Common.MarsMap<string,System.Object> typeName = airportstadelayer.Get(this.Position.X,this.Position.Y);
			System.Console.WriteLine("typeName:");;
			System.Console.WriteLine(typeName.Get("aeroway")
			);;
			System.Tuple<double,double>[] result = new System.Func<System.Tuple<double, double>[]>(() => {
				
				var _source25_634 = this.Position.PositionArray;
				
				var _range25_634 = -1;
				
				Func<Mars.Components.Common.MarsMap<string, object>, bool> _predicate25_634 = new Func<Mars.Components.Common.MarsMap<string,System.Object>,bool>((Mars.Components.Common.MarsMap<string,System.Object> it) => 
				 {
						{
						return it.Contains("aeroway")
						 && Equals(it.Get("aeroway")
						, "taxiway")
						;}
						;
						return default(bool);;
				});
				var _exploreResult25_634 = _AirportStadeLayer.Explore(_source25_634, _range25_634, -1, 
					_element25_634 => _predicate25_634.Invoke((Mars.Components.Common.MarsMap<string, object>) _element25_634));
				if (_exploreResult25_634 != null) {
					return _exploreResult25_634
						.Where(result25_634 => result25_634.Node?.Value != null)
						.Select(result25_634 => new System.Tuple<double, double>(result25_634.Node.NodePosition.X, result25_634.Node.NodePosition.Y)).ToArray();
				}
				return new System.Tuple<double, double>[0];
					
			}).Invoke();
			System.Console.WriteLine(result[1]);;
			System.Tuple<double,double> res = new System.Func<System.Tuple<double,double>>(() => {
				
				var _source28_781 = this.Position.PositionArray;
				
				var _range28_781 = -1;
				
				Func<Mars.Components.Common.MarsMap<string, object>, bool> _predicate28_781 = new Func<Mars.Components.Common.MarsMap<string,System.Object>,bool>((Mars.Components.Common.MarsMap<string,System.Object> it) => 
				 {
						{
						return it.Contains("aeroway")
						 && Equals(it.Get("aeroway")
						, "taxiway")
						;}
						;
						return default(bool);;
				});
				var _exploreResult28_781 = _AirportStadeLayer.Explore(_source28_781, _range28_781, 1, 
					_element28_781 => _predicate28_781.Invoke((Mars.Components.Common.MarsMap<string, object>) _element28_781));
				
				return _exploreResult28_781
					.Select(result28_781 => new System.Tuple<double, double>(result28_781.Node.NodePosition.X, result28_781.Node.NodePosition.Y))
					.FirstOrDefault();
			}).Invoke();
			System.Console.WriteLine(res);
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Aircraft other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
