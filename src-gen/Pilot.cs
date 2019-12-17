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
	public class Pilot : Mars.Interfaces.Agent.IMarsDslAgent {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(Pilot));
		private readonly System.Random _Random = new System.Random();
		private double __Latitude
			 = default(double);
		public double Latitude { 
			get { return __Latitude; }
			set{
				if(System.Math.Abs(__Latitude - value) > 0.0000001) __Latitude = value;
			}
		}
		private double __Longitude
			 = default(double);
		public double Longitude { 
			get { return __Longitude; }
			set{
				if(System.Math.Abs(__Longitude - value) > 0.0000001) __Longitude = value;
			}
		}
		private cessna_digital_twin.Aircraft __myAircraft
			 = default(cessna_digital_twin.Aircraft);
		internal cessna_digital_twin.Aircraft myAircraft { 
			get { return __myAircraft; }
			set{
				if(__myAircraft != value) __myAircraft = value;
			}
		}
		private string __state
			 = default(string);
		public string state { 
			get { return __state; }
			set{
				if(__state != value) __state = value;
			}
		}
		private string __current_activity
			 = default(string);
		public string current_activity { 
			get { return __current_activity; }
			set{
				if(__current_activity != value) __current_activity = value;
			}
		}
		private cessna_digital_twin.TimeHandler __timehandler
			 = new cessna_digital_twin.TimeHandler();
		internal cessna_digital_twin.TimeHandler timehandler { 
			get { return __timehandler; }
			set{
				if(__timehandler != value) __timehandler = value;
			}
		}
		private bool __first_action_done
			 = false;
		internal bool first_action_done { 
			get { return __first_action_done; }
			set{
				if(__first_action_done != value) __first_action_done = value;
			}
		}
		private string __next_action
			 = default(string);
		internal string next_action { 
			get { return __next_action; }
			set{
				if(__next_action != value) __next_action = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void update_general_values() 
		{
			{
			Longitude = this.Position.X;
			Latitude = this.Position.Y;
			current_activity = next_action
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void PreflightInspection_action() 
		{
			{
			if(Equals(first_action_done, false)) {
							{
							Check_TireRightMainWheel__inflation("Check_RWT__water_sediments");
							if(Equals(next_action, "Check_RWT__water_sediments")) {
											{
											first_action_done = true
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Check_RWT__water_sediments")) {
											{
											Check_RWT__water_sediments("End_of_Actions");
											if(Equals(next_action, "End_of_Actions")) {
															{
															System.Console.WriteLine("Finished State >" + state + " with next action flag >" + next_action);;
															state = "my_second_state";
															first_action_done = false
															;}
													;} 
											;}
									;} 
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Check_TireRightMainWheel__inflation(string next_act) 
		{
			{
			timehandler.create_action_duration(5,2);
			if(timehandler.hold_action_time(timehandler.action_duration)
			) {
							{
							System.Console.WriteLine("Checking right Main Wheel Tire inflation");;
							System.Console.WriteLine(myAircraft.Get_TireRightMainWheel__inflation()
							);;
							next_action = next_act
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Check_RWT__water_sediments(string next_act) 
		{
			{
			timehandler.create_action_duration(20,10);
			if(timehandler.hold_action_time(timehandler.action_duration)
			) {
							{
							System.Console.WriteLine("Checking right wing tank for water sediments");;
							System.Console.WriteLine(myAircraft.Get_RWT__water_sediments()
							);;
							next_action = next_act
							;}
					;} 
			;}
			return;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment { get; set; }
		public cessna_digital_twin.AirportStadeLayer _AirportStadeLayer { get; set; }
		public cessna_digital_twin.AirportStadeLayer airportstadelayer => _AirportStadeLayer;
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Pilot (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment,
		cessna_digital_twin.AirportStadeLayer _AirportStadeLayer
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this._AirportStadeLayer = _AirportStadeLayer;
			_AgentLayer._PilotEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			double x_spawn = agentlayer.get_spawn_x_coord();
			double y_spawn = agentlayer.get_spawn_y_coord();
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget171_3957 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object171_3957 = this;
				
				_AgentLayer._PilotEnvironment.PosAt(_object171_3957, 
					_taget171_3957.Item1, _taget171_3957.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			myAircraft = new Func<cessna_digital_twin.Aircraft>(() => {
				Func<cessna_digital_twin.Aircraft, bool> _predicate172_4000 = null;
				Func<cessna_digital_twin.Aircraft, bool> _predicateMod172_4000 = new Func<cessna_digital_twin.Aircraft, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate172_4000 != null)
					{
						return _predicate172_4000.Invoke(_it);
					} else return true;
				});
				
				const int _range172_4000 = -1;
				var _source172_4000 = this.Position;
				
				return _AgentLayer._AircraftEnvironment.Explore(_source172_4000, _range172_4000, 1, _predicateMod172_4000)?.FirstOrDefault();
			}).Invoke();
			update_general_values();
			state = "PreflightInspection"
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			System.Console.WriteLine((int) Mars.Core.SimulationManager.Entities.SimulationClock.CurrentStep);;
			if(Equals(state, "PreflightInspection")) {
							{
							PreflightInspection_action()
							;}
					;} ;
			update_general_values()
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Pilot other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
