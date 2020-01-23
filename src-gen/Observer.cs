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
		private double __left_xcor
			 = 9.4987928;
		internal double left_xcor { 
			get { return __left_xcor; }
			set{
				if(System.Math.Abs(__left_xcor - value) > 0.0000001) __left_xcor = value;
			}
		}
		private double __left_ycor
			 = 53.560392;
		internal double left_ycor { 
			get { return __left_ycor; }
			set{
				if(System.Math.Abs(__left_ycor - value) > 0.0000001) __left_ycor = value;
			}
		}
		private double __right_xcor
			 = 9.5009108;
		internal double right_xcor { 
			get { return __right_xcor; }
			set{
				if(System.Math.Abs(__right_xcor - value) > 0.0000001) __right_xcor = value;
			}
		}
		private double __right_ycor
			 = 53.5599218;
		internal double right_ycor { 
			get { return __right_ycor; }
			set{
				if(System.Math.Abs(__right_ycor - value) > 0.0000001) __right_ycor = value;
			}
		}
		private int __number_of_spawning_points
			 = 5;
		internal int number_of_spawning_points { 
			get { return __number_of_spawning_points; }
			set{
				if(__number_of_spawning_points != value) __number_of_spawning_points = value;
			}
		}
		private Mars.Components.Common.MarsList<double> __spawn_xcor_list
			 = default(Mars.Components.Common.MarsList<double>);
		internal Mars.Components.Common.MarsList<double> spawn_xcor_list { 
			get { return __spawn_xcor_list; }
			set{
				if(__spawn_xcor_list != value) __spawn_xcor_list = value;
			}
		}
		private Mars.Components.Common.MarsList<double> __spawn_ycor_list
			 = default(Mars.Components.Common.MarsList<double>);
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
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_spawn_cor() 
		{
			{
			double temp_deltastep_xcor = (left_xcor - right_xcor) / (number_of_spawning_points - 1);
			double temp_deltastep_ycor = (left_ycor - right_ycor) / (number_of_spawning_points - 1);
			for(int i = 0;
					 i < number_of_spawning_points;
					 i++){
					 	{
					 	spawn_xcor_list.Add(left_xcor + temp_deltastep_xcor * i);
					 	spawn_ycor_list.Add(left_ycor + temp_deltastep_ycor * i)
					 	;}
					 };
			spawn_location_number = 0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void spawn_pilot_and_aircraft() 
		{
			{
			new System.Func<cessna_digital_twin.Aircraft>(() => {
			var _target131_4135 = new System.Tuple<double,double>(spawn_xcor_list.Get(0),
			spawn_ycor_list.Get(0)
			);
			return _AgentLayer._SpawnAircraft(_target131_4135.Item1, _target131_4135.Item2);}).Invoke();
			new System.Func<cessna_digital_twin.Pilot>(() => {
			var _target132_4206 = new System.Tuple<double,double>(spawn_xcor_list.Get(0),
			spawn_ycor_list.Get(0)
			);
			return _AgentLayer._SpawnPilot(_target132_4206.Item1, _target132_4206.Item2);}).Invoke();
			spawn_location_number = spawn_location_number + 1;
			if(spawn_location_number >= number_of_spawning_points) {
							{
							spawn_location_number = 0
							;}
					;} ;
			System.Console.WriteLine("SPAWN U CUNTS");
			;}
			return;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment { get; set; }
		public cessna_digital_twin.AirportStadeLayer _AirportStadeLayer { get; set; }
		public cessna_digital_twin.AirportStadeLayer airportstadelayer => _AirportStadeLayer;
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Observer (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Observer> _ObserverEnvironment,
		cessna_digital_twin.AirportStadeLayer _AirportStadeLayer
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this._AirportStadeLayer = _AirportStadeLayer;
			_AgentLayer._ObserverEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			state_list = (new Mars.Components.Common.MarsList<string>() { "PreflightInspection","StartingEngine","TakeOffPreparationRequest","Taxiing","TakeOffPreparation","TakeOffHoldShortRequest","TakeOffRequest","TakeOff","LeavingAirspaceRequest" });
			initialize_spawn_cor()
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			if(Equals((int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep % 150, 0)) {
							{
							System.Console.WriteLine("Simulation Time: " + (int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep);;
							System.Console.WriteLine("Number of Pilots in each State");;
							foreach ( var state in state_list ) {
										{
										int count = 0;
										cessna_digital_twin.Pilot[] pilot_array = new System.Func<cessna_digital_twin.Pilot[]>(() => {
											
											var _sourceMapped155_4921 = this.Position;
											var _source155_4921 = _sourceMapped155_4921;
											var _range155_4921 = -1;
														
											Func<cessna_digital_twin.Pilot, bool> _predicate155_4921 = new Func<cessna_digital_twin.Pilot,bool>((cessna_digital_twin.Pilot x) => 
											 {
													{
													return Equals(x.Get_state()
													, state)
													;}
													;
													return default(bool);;
											});
											Func<cessna_digital_twin.Pilot, bool> _predicateMod155_4921 = new Func<cessna_digital_twin.Pilot, bool>(_it => 
											{
												if (_it?.ID == this.ID)
												{
													return false;
												} else if (_predicate155_4921 != null)
												{
													return _predicate155_4921.Invoke(_it);
												} else return true;
											});
											
											return _AgentLayer._PilotEnvironment.Explore(_source155_4921 , _range155_4921, -1, _predicate155_4921).ToArray();
										}).Invoke();
										foreach ( var temp in pilot_array ) {
													{
													count = count + 1
													;}
												};
										System.Console.WriteLine(state + ": " + count);
										;}
									};
							System.Console.WriteLine("-----End of information-----");
							;}
					;} ;
			if(Equals((int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep, 1) || Equals((int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep, 5)) {
							{
							spawn_pilot_and_aircraft()
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
