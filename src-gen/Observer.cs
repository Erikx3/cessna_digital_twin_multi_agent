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
	public class Observer : Mars.Interfaces.Agent.IMarsDslAgent {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(Observer));
		private readonly System.Random _Random = new System.Random();
		private Mars.Components.Common.MarsList<string> __state_list
			 = new Mars.Components.Common.MarsList<string>();
		internal Mars.Components.Common.MarsList<string> state_list { 
			get { return __state_list; }
			set{
				if(__state_list != value) __state_list = value;
			}
		}
		private cessna_digital_twin.Formula __formula
			 = new cessna_digital_twin.Formula();
		internal cessna_digital_twin.Formula formula { 
			get { return __formula; }
			set{
				if(__formula != value) __formula = value;
			}
		}
		private cessna_digital_twin.AirportStade __airportstade
			 = new cessna_digital_twin.AirportStade();
		internal cessna_digital_twin.AirportStade airportstade { 
			get { return __airportstade; }
			set{
				if(__airportstade != value) __airportstade = value;
			}
		}
		private int __number_of_spawning_points
			 = default(int);
		internal int number_of_spawning_points { 
			get { return __number_of_spawning_points; }
			set{
				if(__number_of_spawning_points != value) __number_of_spawning_points = value;
			}
		}
		private int __print_interval
			 = default(int);
		internal int print_interval { 
			get { return __print_interval; }
			set{
				if(__print_interval != value) __print_interval = value;
			}
		}
		private double __left_xcor
			 = default(double);
		internal double left_xcor { 
			get { return __left_xcor; }
			set{
				if(System.Math.Abs(__left_xcor - value) > 0.0000001) __left_xcor = value;
			}
		}
		private double __left_ycor
			 = default(double);
		internal double left_ycor { 
			get { return __left_ycor; }
			set{
				if(System.Math.Abs(__left_ycor - value) > 0.0000001) __left_ycor = value;
			}
		}
		private double __right_xcor
			 = default(double);
		internal double right_xcor { 
			get { return __right_xcor; }
			set{
				if(System.Math.Abs(__right_xcor - value) > 0.0000001) __right_xcor = value;
			}
		}
		private double __right_ycor
			 = default(double);
		internal double right_ycor { 
			get { return __right_ycor; }
			set{
				if(System.Math.Abs(__right_ycor - value) > 0.0000001) __right_ycor = value;
			}
		}
		private Mars.Components.Common.MarsList<double> __spawn_xcor_list
			 = new Mars.Components.Common.MarsList<double>();
		internal Mars.Components.Common.MarsList<double> spawn_xcor_list { 
			get { return __spawn_xcor_list; }
			set{
				if(__spawn_xcor_list != value) __spawn_xcor_list = value;
			}
		}
		private Mars.Components.Common.MarsList<double> __spawn_ycor_list
			 = new Mars.Components.Common.MarsList<double>();
		internal Mars.Components.Common.MarsList<double> spawn_ycor_list { 
			get { return __spawn_ycor_list; }
			set{
				if(__spawn_ycor_list != value) __spawn_ycor_list = value;
			}
		}
		private int __spawn_location_number
			 = default(int);
		internal int spawn_location_number { 
			get { return __spawn_location_number; }
			set{
				if(__spawn_location_number != value) __spawn_location_number = value;
			}
		}
		private Mars.Components.Common.MarsList<double> __available_runway_heading
			 = default(Mars.Components.Common.MarsList<double>);
		internal Mars.Components.Common.MarsList<double> available_runway_heading { 
			get { return __available_runway_heading; }
			set{
				if(__available_runway_heading != value) __available_runway_heading = value;
			}
		}
		private double __runway_heading_calculated
			 = default(double);
		internal double runway_heading_calculated { 
			get { return __runway_heading_calculated; }
			set{
				if(System.Math.Abs(__runway_heading_calculated - value) > 0.0000001) __runway_heading_calculated = value;
			}
		}
		private cessna_digital_twin.Weather __weather
			 = default(cessna_digital_twin.Weather);
		internal cessna_digital_twin.Weather weather { 
			get { return __weather; }
			set{
				if(__weather != value) __weather = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_spawn_cor() 
		{
			{
			left_xcor = airportstade.Get_left_apron_coordinates()
			.Item1;
			left_ycor = airportstade.Get_left_apron_coordinates()
			.Item2;
			right_xcor = airportstade.Get_right_apron_coordinates()
			.Item1;
			right_ycor = airportstade.Get_right_apron_coordinates()
			.Item2;
			double temp_deltastep_xcor = (left_xcor - right_xcor) / (number_of_spawning_points - 1);
			double temp_deltastep_ycor = (left_ycor - right_ycor) / (number_of_spawning_points - 1);
			for(int i = 0;
					 i < number_of_spawning_points;
					 i++){
					 	{
					 	spawn_xcor_list.Add(left_xcor - temp_deltastep_xcor * i);
					 	spawn_ycor_list.Add(left_ycor - temp_deltastep_ycor * i)
					 	;}
					 };
			spawn_location_number = 0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void spawn_pilot_and_aircraft_on_ground() 
		{
			{
			bool spawn_successful = false;
			int i = 0;
			while(i < number_of_spawning_points && Equals(spawn_successful, false)) { 
							{
							i = i + 1;
							System.Tuple<double,double> spawn_cor = new System.Tuple<double,double>(spawn_xcor_list.Get(spawn_location_number),
							spawn_ycor_list.Get(spawn_location_number)
							);
							cessna_digital_twin.Aircraft[] aircraft_array = new System.Func<cessna_digital_twin.Aircraft[]>(() => {
								
								var _sourceMapped191_7040 = this.Position;
								var _source191_7040 = _sourceMapped191_7040;
								var _range191_7040 = -1;
											
								Func<cessna_digital_twin.Aircraft, bool> _predicate191_7040 = new Func<cessna_digital_twin.Aircraft,bool>((cessna_digital_twin.Aircraft x) => 
								 {
										{
										return formula.haversine(x.Get_position(),
										spawn_cor)
										 < 10
										;}
										;
										return default(bool);;
								});
								Func<cessna_digital_twin.Aircraft, bool> _predicateMod191_7040 = new Func<cessna_digital_twin.Aircraft, bool>(_it => 
								{
									if (_it?.ID == this.ID)
									{
										return false;
									} else if (_predicate191_7040 != null)
									{
										return _predicate191_7040.Invoke(_it);
									} else return true;
								});
								
								return _AgentLayer._AircraftEnvironment.Explore(_source191_7040 , _range191_7040, -1, _predicate191_7040).ToArray();
							}).Invoke();
							if(Equals(aircraft_array.Length, 0)) {
											{
											new System.Func<cessna_digital_twin.Aircraft>(() => {
											var _target195_7252 = spawn_cor;
											return _AgentLayer._SpawnAircraft(_target195_7252.Item1, _target195_7252.Item2);}).Invoke();
											new System.Func<cessna_digital_twin.Pilot>(() => {
											var _target196_7285 = spawn_cor;
											return _AgentLayer._SpawnPilot(_target196_7285.Item1, _target196_7285.Item2);}).Invoke();
											spawn_successful = true
											;}
									;} ;
							spawn_location_number = spawn_location_number + 1;
							if(spawn_location_number >= number_of_spawning_points) {
											{
											spawn_location_number = 0
											;}
									;} 
							;}
						}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_runway_heading() {
			{
			double wind_bearing = weather.Get_wind_bearing();
			runway_heading_calculated = formula.calculate_runway_heading(available_runway_heading,wind_bearing);
			return runway_heading_calculated
			;}
			
			return default(double);;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Weather> _WeatherEnvironment { get; set; }
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Observer (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Observer> _ObserverEnvironment,
		int number_of_spawning_points,
		int print_interval
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this.number_of_spawning_points = number_of_spawning_points;
			this.print_interval = print_interval;
			_AgentLayer._ObserverEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			state_list = (new Mars.Components.Common.MarsList<string>() { "Initialization","PreflightInspection","StartingEngine","TakeOffPreparationRequest","Taxiing","TakeOffPreparation","TakeOffHoldShortRequest","TakeOffRequest","TakeOff","Climb","LeavingFrequencyRequest","LandingRequest","GoAround","Landing","LeavingFrequency" });
			available_runway_heading = airportstade.Get_available_runway_heading_list();
			initialize_spawn_cor()
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			weather = new Func<cessna_digital_twin.Weather>(() => {
				Func<cessna_digital_twin.Weather, bool> _predicate128_4794 = null;
				Func<cessna_digital_twin.Weather, bool> _predicateMod128_4794 = new Func<cessna_digital_twin.Weather, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate128_4794 != null)
					{
						return _predicate128_4794.Invoke(_it);
					} else return true;
				});
				
				const int _range128_4794 = -1;
				var _source128_4794 = this.Position;
				
				return _AgentLayer._WeatherEnvironment.Explore(_source128_4794, _range128_4794, 1, _predicateMod128_4794)?.FirstOrDefault();
			}).Invoke();
			if(Equals((int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep % print_interval, 0)) {
							{
							System.Console.WriteLine("Simulation Time: " + (int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep);;
							System.Console.WriteLine("Number of Pilots in each State");;
							foreach ( var state in state_list ) {
										{
										cessna_digital_twin.Pilot[] pilot_array = new System.Func<cessna_digital_twin.Pilot[]>(() => {
											
											var _sourceMapped137_5105 = this.Position;
											var _source137_5105 = _sourceMapped137_5105;
											var _range137_5105 = -1;
														
											Func<cessna_digital_twin.Pilot, bool> _predicate137_5105 = new Func<cessna_digital_twin.Pilot,bool>((cessna_digital_twin.Pilot x) => 
											 {
													{
													return Equals(x.Get_state()
													, state)
													;}
													;
													return default(bool);;
											});
											Func<cessna_digital_twin.Pilot, bool> _predicateMod137_5105 = new Func<cessna_digital_twin.Pilot, bool>(_it => 
											{
												if (_it?.ID == this.ID)
												{
													return false;
												} else if (_predicate137_5105 != null)
												{
													return _predicate137_5105.Invoke(_it);
												} else return true;
											});
											
											return _AgentLayer._PilotEnvironment.Explore(_source137_5105 , _range137_5105, -1, _predicate137_5105).ToArray();
										}).Invoke();
										System.Console.WriteLine(state + ": " + pilot_array.Length);
										;}
									};
							System.Console.WriteLine("-----End of information-----");
							;}
					;} 
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Observer other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
