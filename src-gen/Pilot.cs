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
		private string __myAircraft_callsign
			 = default(string);
		public string myAircraft_callsign { 
			get { return __myAircraft_callsign; }
			set{
				if(__myAircraft_callsign != value) __myAircraft_callsign = value;
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
		private cessna_digital_twin.Aircraft __myAircraft
			 = default(cessna_digital_twin.Aircraft);
		internal cessna_digital_twin.Aircraft myAircraft { 
			get { return __myAircraft; }
			set{
				if(__myAircraft != value) __myAircraft = value;
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
		private bool __first_action_set
			 = false;
		internal bool first_action_set { 
			get { return __first_action_set; }
			set{
				if(__first_action_set != value) __first_action_set = value;
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
		private int __age_max
			 = 75;
		internal int age_max { 
			get { return __age_max; }
			set{
				if(__age_max != value) __age_max = value;
			}
		}
		private int __age_min
			 = 18;
		internal int age_min { 
			get { return __age_min; }
			set{
				if(__age_min != value) __age_min = value;
			}
		}
		private int __age
			 = default(int);
		public int age { 
			get { return __age; }
			set{
				if(__age != value) __age = value;
			}
		}
		private int __flight_experience
			 = default(int);
		public int flight_experience { 
			get { return __flight_experience; }
			set{
				if(__flight_experience != value) __flight_experience = value;
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
			if(Equals(first_action_set, false)) {
							{
							next_action = "Check_TireRightMainWheel__inflation";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Check_TireRightMainWheel__inflation")) {
							{
							timehandler.create_action_duration(10,10,"age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											int check_value = Check_TireRightMainWheel__inflation();
											if(check_value >= 0) {
															{
															next_action = "Check_RWT__water_sediments"
															;}
													;} 
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Check_RWT__water_sediments")) {
											{
											timehandler.create_action_duration(20,20,"age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															bool check_value = Check_RWT__water_sediments();
															if(Equals(check_value, true) || Equals(check_value, false)) {
																			{
																			next_action = "Check_RWT__fuel_quantity"
																			;}
																	;} 
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Check_RWT__fuel_quantity")) {
															{
															timehandler.create_action_duration(20,20,"age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			double check_value = Check_RWT__fuel_quantity();
																			if(check_value >= 0) {
																							{
																							next_action = "Check_Engine__oil"
																							;}
																					;} 
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "Check_Engine__oil")) {
																			{
																			timehandler.create_action_duration(20,20,"age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							double check_value = Check_Engine__oil();
																							if(check_value >= 0) {
																											{
																											next_action = "Check_TireNoseWheel__inflation"
																											;}
																									;} 
																							;}
																					;} 
																			;}
																	;} else {
																			if(Equals(next_action, "Check_TireNoseWheel__inflation")) {
																							{
																							timehandler.create_action_duration(10,10,"age_and_experience");
																							if(timehandler.hold_action_time(timehandler.action_duration)
																							) {
																											{
																											int check_value = Check_TireNoseWheel__inflation();
																											if(check_value >= 0) {
																															{
																															next_action = "Check_TireLeftMainWheel__inflation"
																															;}
																													;} 
																											;}
																									;} 
																							;}
																					;} else {
																							if(Equals(next_action, "Check_TireLeftMainWheel__inflation")) {
																											{
																											timehandler.create_action_duration(10,10,"age_and_experience");
																											if(timehandler.hold_action_time(timehandler.action_duration)
																											) {
																															{
																															int check_value = Check_TireLeftMainWheel__inflation();
																															if(check_value >= 0) {
																																			{
																																			next_action = "Check_LWT__water_sediments"
																																			;}
																																	;} 
																															;}
																													;} 
																											;}
																									;} else {
																											if(Equals(next_action, "Check_LWT__water_sediments")) {
																															{
																															timehandler.create_action_duration(20,20,"age_and_experience");
																															if(timehandler.hold_action_time(timehandler.action_duration)
																															) {
																																			{
																																			bool check_value = Check_LWT__water_sediments();
																																			if(Equals(check_value, true) || Equals(check_value, false)) {
																																							{
																																							next_action = "Check_LWT__fuel_quantity"
																																							;}
																																					;} 
																																			;}
																																	;} 
																															;}
																													;} else {
																															if(Equals(next_action, "Check_LWT__fuel_quantity")) {
																																			{
																																			timehandler.create_action_duration(20,20,"age_and_experience");
																																			if(timehandler.hold_action_time(timehandler.action_duration)
																																			) {
																																							{
																																							double check_value = Check_LWT__fuel_quantity();
																																							if(check_value >= 0) {
																																											{
																																											next_action = "End_of_Actions"
																																											;}
																																									;} 
																																							;}
																																					;} 
																																			;}
																																	;} 
																														;}
																										;}
																						;}
																		;}
														;}
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							state = "StartingEngine";
							System.Console.WriteLine("Next state -->" + state);;
							first_action_set = false
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void StartingEngine_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Set_Brake__parking_brake";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Set_Brake__parking_brake")) {
							{
							timehandler.create_action_duration(4,2,"age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											Set_Brake__parking_brake("SET");
											next_action = "Set_Engine__mixture_control"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Set_Engine__mixture_control")) {
											{
											timehandler.create_action_duration(4,2,"age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															Set_Engine__mixture_control(0);
															next_action = "Set_CIP__master_switch"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Set_CIP__master_switch")) {
															{
															timehandler.create_action_duration(4,2,"age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			Set_CIP__master_switch("ON");
																			next_action = "Apply_Engine__throttle"
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "Apply_Engine__throttle")) {
																			{
																			timehandler.create_action_duration(4,2,"age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							double throttle_value = 0.05 + (_Random.Next(11)
																							 / 100.0);
																							Apply_Engine__throttle(throttle_value);
																							next_action = "Set_Engine__ignition_switch_START"
																							;}
																					;} 
																			;}
																	;} else {
																			if(Equals(next_action, "Set_Engine__ignition_switch_START")) {
																							{
																							timehandler.create_action_duration(4,2,"age_and_experience");
																							if(timehandler.hold_action_time(timehandler.action_duration)
																							) {
																											{
																											Set_Engine__ignition_switch("START");
																											next_action = "Check_Engine__running"
																											;}
																									;} 
																							;}
																					;} else {
																							if(Equals(next_action, "Check_Engine__running")) {
																											{
																											timehandler.create_action_duration(1,0,"age_and_experience");
																											if(timehandler.hold_action_time(timehandler.action_duration)
																											) {
																															{
																															bool check_value = Check_Engine__running();
																															if(Equals(check_value, true)) {
																																			{
																																			next_action = "Set_Engine__ignition_switch_BOTH"
																																			;}
																																	;} else {
																																			if(Equals(check_value, false)) {
																																							{
																																							next_action = "Check_Engine__running"
																																							;}
																																					;} 
																																		;}
																															;}
																													;} 
																											;}
																									;} else {
																											if(Equals(next_action, "Set_Engine__ignition_switch_BOTH")) {
																															{
																															timehandler.create_action_duration(2,2,"age_and_experience");
																															if(timehandler.hold_action_time(timehandler.action_duration)
																															) {
																																			{
																																			Set_Engine__ignition_switch("BOTH");
																																			next_action = "Check_Instrument_Engine__oil_pressure"
																																			;}
																																	;} 
																															;}
																													;} else {
																															if(Equals(next_action, "Check_Instrument_Engine__oil_pressure")) {
																																			{
																																			timehandler.create_action_duration(30,2,"age_and_experience");
																																			if(timehandler.hold_action_time(timehandler.action_duration)
																																			) {
																																							{
																																							Check_Instrument_Engine__oil_pressure();
																																							next_action = "Check_Instrument_Engine__oil_temperature"
																																							;}
																																					;} 
																																			;}
																																	;} else {
																																			if(Equals(next_action, "Check_Instrument_Engine__oil_temperature")) {
																																							{
																																							timehandler.create_action_duration(3,2,"age_and_experience");
																																							if(timehandler.hold_action_time(timehandler.action_duration)
																																							) {
																																											{
																																											Check_Instrument_Engine__oil_temperature();
																																											next_action = "End_of_action"
																																											;}
																																									;} 
																																							;}
																																					;} 
																																		;}
																														;}
																										;}
																						;}
																		;}
														;}
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							state = "NextState";
							System.Console.WriteLine("Next state -->" + state);;
							first_action_set = false
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_Engine__oil_pressure() 
		{
			{
			System.Console.WriteLine("Checking Engine oil pressure instrument");;
			return myAircraft.IP_Get_Engine__oil_pressure()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_Engine__oil_temperature() 
		{
			{
			System.Console.WriteLine("Checking Engine oil temperature instrument");;
			return myAircraft.IP_Get_Engine__oil_temperature()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Apply_Engine__throttle(double input) 
		{
			{
			System.Console.WriteLine("Apply throttle");;
			myAircraft.CIP_Apply_Engine__throttle(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_Engine__ignition_switch(string input) 
		{
			{
			System.Console.WriteLine("Set ignition switch to " + input);;
			myAircraft.CIP_Set_Engine__ignition_switch(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_Brake__parking_brake(string input) 
		{
			{
			System.Console.WriteLine("Set Parking Brake to " + input);;
			myAircraft.CIP_Set_Brake__parking_brake(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_Engine__mixture_control(double input) 
		{
			{
			System.Console.WriteLine("Set Mixture Control");;
			myAircraft.CIP_Set_Engine__mixture_control(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_CIP__master_switch(string input) 
		{
			{
			System.Console.WriteLine("Set Master Switch to " + input);;
			myAircraft.CIP_Set__master_switch(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Check_TireRightMainWheel__inflation() 
		{
			{
			System.Console.WriteLine("Checking right Main Wheel Tire inflation");;
			return myAircraft.Get_TireRightMainWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Check_TireLeftMainWheel__inflation() 
		{
			{
			System.Console.WriteLine("Checking left Main Wheel Tire inflation");;
			return myAircraft.Get_TireLeftMainWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Check_TireNoseWheel__inflation() 
		{
			{
			System.Console.WriteLine("Checking Nose Wheel Tire inflation");;
			return myAircraft.Get_TireNoseWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_RWT__fuel_quantity() 
		{
			{
			System.Console.WriteLine("Checking right wing tank fuel quantity");;
			return myAircraft.Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_LWT__fuel_quantity() 
		{
			{
			System.Console.WriteLine("Checking left wing tank fuel quantity");;
			return myAircraft.Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Check_RWT__water_sediments() 
		{
			{
			System.Console.WriteLine("Checking right wing tank for water sediments");;
			return myAircraft.Get_RWT__water_sediments()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Check_LWT__water_sediments() 
		{
			{
			System.Console.WriteLine("Checking left wing tank for water sediments");;
			return myAircraft.Get_LWT__water_sediments()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Check_Engine__running() 
		{
			{
			System.Console.WriteLine("Checking Engine running");;
			return myAircraft.Get_Engine__running()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Engine__oil() 
		{
			{
			System.Console.WriteLine("Checking Engine oil");;
			return myAircraft.Get_Engine__oil()
			;}
			return default(double);;
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
			double x_spawn = agentlayer.Get_spawn_x_coord();
			double y_spawn = agentlayer.Get_spawn_y_coord();
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget372_10115 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object372_10115 = this;
				
				_AgentLayer._PilotEnvironment.PosAt(_object372_10115, 
					_taget372_10115.Item1, _taget372_10115.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			myAircraft = new Func<cessna_digital_twin.Aircraft>(() => {
				Func<cessna_digital_twin.Aircraft, bool> _predicate376_10271 = null;
				Func<cessna_digital_twin.Aircraft, bool> _predicateMod376_10271 = new Func<cessna_digital_twin.Aircraft, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate376_10271 != null)
					{
						return _predicate376_10271.Invoke(_it);
					} else return true;
				});
				
				const int _range376_10271 = -1;
				var _source376_10271 = this.Position;
				
				return _AgentLayer._AircraftEnvironment.Explore(_source376_10271, _range376_10271, 1, _predicateMod376_10271)?.FirstOrDefault();
			}).Invoke();
			myAircraft_callsign = myAircraft.Get_callsign();
			update_general_values();
			state = "PreflightInspection";
			age = age_min + _Random.Next((age_max - age_min) + 1);
			flight_experience = _Random.Next(age - age_min)
			 + 1;
			timehandler.initialize_variables(age,flight_experience,age_max,age_min)
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			if(Equals(state, "PreflightInspection")) {
							{
							PreflightInspection_action()
							;}
					;} else {
							if(Equals(state, "StartingEngine")) {
											{
											StartingEngine_action()
											;}
									;} 
						;};
			update_general_values()
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Pilot other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
