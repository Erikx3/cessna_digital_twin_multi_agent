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
		private string __event_info
			 = default(string);
		public string event_info { 
			get { return __event_info; }
			set{
				if(__event_info != value) __event_info = value;
			}
		}
		private double __takeoff_distance
			 = default(double);
		public double takeoff_distance { 
			get { return __takeoff_distance; }
			set{
				if(System.Math.Abs(__takeoff_distance - value) > 0.0000001) __takeoff_distance = value;
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
		private cessna_digital_twin.Weather __weather
			 = default(cessna_digital_twin.Weather);
		internal cessna_digital_twin.Weather weather { 
			get { return __weather; }
			set{
				if(__weather != value) __weather = value;
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
		private cessna_digital_twin.Formula __formula
			 = new cessna_digital_twin.Formula();
		internal cessna_digital_twin.Formula formula { 
			get { return __formula; }
			set{
				if(__formula != value) __formula = value;
			}
		}
		private double __temp_throttle_value
			 = default(double);
		internal double temp_throttle_value { 
			get { return __temp_throttle_value; }
			set{
				if(System.Math.Abs(__temp_throttle_value - value) > 0.0000001) __temp_throttle_value = value;
			}
		}
		private double __temp_pitch_value
			 = default(double);
		internal double temp_pitch_value { 
			get { return __temp_pitch_value; }
			set{
				if(System.Math.Abs(__temp_pitch_value - value) > 0.0000001) __temp_pitch_value = value;
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
		private bool __first_action_set
			 = false;
		internal bool first_action_set { 
			get { return __first_action_set; }
			set{
				if(__first_action_set != value) __first_action_set = value;
			}
		}
		private Mars.Components.Common.MarsList<System.Tuple<double,double>> __taxi_path
			 = default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);
		internal Mars.Components.Common.MarsList<System.Tuple<double,double>> taxi_path { 
			get { return __taxi_path; }
			set{
				if(__taxi_path != value) __taxi_path = value;
			}
		}
		private int __active_taxi_point_number
			 = 0;
		internal int active_taxi_point_number { 
			get { return __active_taxi_point_number; }
			set{
				if(__active_taxi_point_number != value) __active_taxi_point_number = value;
			}
		}
		private double __heading_information
			 = default(double);
		internal double heading_information { 
			get { return __heading_information; }
			set{
				if(System.Math.Abs(__heading_information - value) > 0.0000001) __heading_information = value;
			}
		}
		private string __state_after_taxiing
			 = default(string);
		internal string state_after_taxiing { 
			get { return __state_after_taxiing; }
			set{
				if(__state_after_taxiing != value) __state_after_taxiing = value;
			}
		}
		private double __distance_to_next_point
			 = default(double);
		internal double distance_to_next_point { 
			get { return __distance_to_next_point; }
			set{
				if(System.Math.Abs(__distance_to_next_point - value) > 0.0000001) __distance_to_next_point = value;
			}
		}
		private bool __first_fixing_attempt
			 = true;
		internal bool first_fixing_attempt { 
			get { return __first_fixing_attempt; }
			set{
				if(__first_fixing_attempt != value) __first_fixing_attempt = value;
			}
		}
		private int __request_attempts
			 = default(int);
		internal int request_attempts { 
			get { return __request_attempts; }
			set{
				if(__request_attempts != value) __request_attempts = value;
			}
		}
		private string __killme_info
			 = default(string);
		internal string killme_info { 
			get { return __killme_info; }
			set{
				if(__killme_info != value) __killme_info = value;
			}
		}
		private double __V_rotate
			 = 30;
		internal double V_rotate { 
			get { return __V_rotate; }
			set{
				if(System.Math.Abs(__V_rotate - value) > 0.0000001) __V_rotate = value;
			}
		}
		private double __spacing_to_next_aircraft
			 = 30.0;
		internal double spacing_to_next_aircraft { 
			get { return __spacing_to_next_aircraft; }
			set{
				if(System.Math.Abs(__spacing_to_next_aircraft - value) > 0.0000001) __spacing_to_next_aircraft = value;
			}
		}
		private double __angle_of_vision
			 = 60.0;
		internal double angle_of_vision { 
			get { return __angle_of_vision; }
			set{
				if(System.Math.Abs(__angle_of_vision - value) > 0.0000001) __angle_of_vision = value;
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
		private double __flight_experience
			 = default(double);
		public double flight_experience { 
			get { return __flight_experience; }
			set{
				if(System.Math.Abs(__flight_experience - value) > 0.0000001) __flight_experience = value;
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
		private double __flight_experience_max
			 = 5700.0;
		internal double flight_experience_max { 
			get { return __flight_experience_max; }
			set{
				if(System.Math.Abs(__flight_experience_max - value) > 0.0000001) __flight_experience_max = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void go_to_next_state(string _state) 
		{
			{
			state = _state;
			first_action_set = false;
			if(Equals(state, "Taxiing")) {
							{
							active_taxi_point_number = 0
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void remove_me_and_my_aircraft(string info) 
		{
			{
			event_info = "End flight mission due to " + info;
			myAircraft.Remove();
			new System.Action(() => {
				var _target376_12586 = this;
				if (_target376_12586 != null) {
					_AgentLayer._KillPilot(_target376_12586, _target376_12586._executionFrequency);
				}
			}).Invoke()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_general_values() 
		{
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget381_12637 = (myAircraft.Get_position()
				);
				
				var _object381_12637 = this;
				
				_AgentLayer._PilotEnvironment.PosAt(_object381_12637, 
					_taget381_12637.Item1, _taget381_12637.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			Longitude = this.Position.X;
			Latitude = this.Position.Y;
			current_activity = next_action
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool skip_action(double base_probability, string action_name) 
		{
			{
			double random_value = Mars.Mathematics.Statistics.RandomHelper.NextDouble(_Random, 0, Mars.Components.Common.Math.Pow(10, 6))
			 / Mars.Components.Common.Math.Pow(10, 6);
			double threshold_value = base_probability + flight_experience / flight_experience_max * 0.1;
			if(random_value >= threshold_value) {
							{
							return false
							;}
					;} else {
							{
							event_info = "Skipped " + action_name;
							return true
							;}
						;}
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void PreflightInspection_action() 
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
							timehandler.create_action_duration(10,10,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											int check_value = Check_Visual_TireRightMainWheel__inflation();
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
											timehandler.create_action_duration(20,20,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															bool check_value = Check_Visual_RWT__water_sediments();
															next_action = "Check_RWT__fuel_quantity";
															if(Equals(check_value, true)) {
																			{
																			if(Equals(skip_action(0.05,"Repair_RWT__water_sediments"), false)) {
																							{
																							next_action = "Repair_RWT__water_sediments"
																							;}
																					;} 
																			;}
																	;} 
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Repair_RWT__water_sediments")) {
															{
															timehandler.create_action_duration(20,20,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			Repair_Visual_RWT__water_sediments();
																			next_action = "Check_RWT__fuel_quantity"
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "Check_RWT__fuel_quantity")) {
																			{
																			timehandler.create_action_duration(20,20,"pilot_age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							double check_value = Check_Visual_RWT__fuel_quantity();
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
																							timehandler.create_action_duration(20,20,"pilot_age_and_experience");
																							if(timehandler.hold_action_time(timehandler.action_duration)
																							) {
																											{
																											double check_value = Check_Visual_Engine__oil();
																											next_action = "Check_TireNoseWheel__inflation";
																											if(check_value < myAircraft.Get_Engine__oil_min()
																											) {
																															{
																															if(Equals(skip_action(0.05,"Refill_Engine__oil"), false)) {
																																			{
																																			next_action = "Refill_Engine__oil"
																																			;}
																																	;} 
																															;}
																													;} 
																											;}
																									;} 
																							;}
																					;} else {
																							if(Equals(next_action, "Refill_Engine__oil")) {
																											{
																											timehandler.create_action_duration(20,20,"pilot_age_and_experience");
																											if(timehandler.hold_action_time(timehandler.action_duration)
																											) {
																															{
																															Refill_Visual_Engine__oil();
																															next_action = "Check_TireNoseWheel__inflation"
																															;}
																													;} 
																											;}
																									;} else {
																											if(Equals(next_action, "Check_TireNoseWheel__inflation")) {
																															{
																															timehandler.create_action_duration(10,10,"pilot_age_and_experience");
																															if(timehandler.hold_action_time(timehandler.action_duration)
																															) {
																																			{
																																			int check_value = Check_Visual_TireNoseWheel__inflation();
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
																																			timehandler.create_action_duration(10,10,"pilot_age_and_experience");
																																			if(timehandler.hold_action_time(timehandler.action_duration)
																																			) {
																																							{
																																							int check_value = Check_Visual_TireLeftMainWheel__inflation();
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
																																							timehandler.create_action_duration(20,20,"pilot_age_and_experience");
																																							if(timehandler.hold_action_time(timehandler.action_duration)
																																							) {
																																											{
																																											bool check_value = Check_Visual_LWT__water_sediments();
																																											next_action = "Check_LWT__fuel_quantity";
																																											if(Equals(check_value, true)) {
																																															{
																																															if(Equals(skip_action(0.05,"Repair_LWT__water_sediments"), false)) {
																																																			{
																																																			next_action = "Repair_LWT__water_sediments"
																																																			;}
																																																	;} 
																																															;}
																																													;} 
																																											;}
																																									;} 
																																							;}
																																					;} else {
																																							if(Equals(next_action, "Repair_LWT__water_sediments")) {
																																											{
																																											timehandler.create_action_duration(20,20,"pilot_age_and_experience");
																																											if(timehandler.hold_action_time(timehandler.action_duration)
																																											) {
																																															{
																																															Repair_Visual_LWT__water_sediments();
																																															next_action = "Check_LWT__fuel_quantity"
																																															;}
																																													;} 
																																											;}
																																									;} else {
																																											if(Equals(next_action, "Check_LWT__fuel_quantity")) {
																																															{
																																															timehandler.create_action_duration(20,20,"pilot_age_and_experience");
																																															if(timehandler.hold_action_time(timehandler.action_duration)
																																															) {
																																																			{
																																																			double check_value = Check_Visual_LWT__fuel_quantity();
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
																		;}
														;}
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("StartingEngine")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void StartingEngine_action() 
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
							timehandler.create_action_duration(4,2,"pilot_age_and_experience");
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
											timehandler.create_action_duration(4,2,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															if(Equals(skip_action(0.05,"Set_Engine__mixture_control"), false)) {
																			{
																			Set_Engine__mixture_control("RICH")
																			;}
																	;} ;
															next_action = "Set_CIP__master_switch"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Set_CIP__master_switch")) {
															{
															timehandler.create_action_duration(4,2,"pilot_age_and_experience");
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
																			timehandler.create_action_duration(4,2,"pilot_age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							temp_throttle_value = 0.10;
																							Apply_Engine__throttle(temp_throttle_value);
																							next_action = "Set_Engine__ignition_switch_START"
																							;}
																					;} 
																			;}
																	;} else {
																			if(Equals(next_action, "Set_Engine__ignition_switch_START")) {
																							{
																							timehandler.create_action_duration(4,2,"pilot_age_and_experience");
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
																											timehandler.create_action_duration(2,1,"pilot_age_and_experience");
																											if(timehandler.hold_action_time(timehandler.action_duration)
																											) {
																															{
																															bool check_value = Check_Visual_Engine__running();
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
																															timehandler.create_action_duration(2,2,"pilot_age_and_experience");
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
																																			timehandler.create_action_duration(30,2,"pilot_age_and_experience");
																																			if(timehandler.hold_action_time(timehandler.action_duration)
																																			) {
																																							{
																																							next_action = "Check_Instrument_Engine__oil_temperature";
																																							if(Check_Instrument_Engine__oil_pressure() < myAircraft.Get_Engine__oil_pressure_normal_min()
																																							) {
																																											{
																																											if(Equals(skip_action(0.05,"Check_Instrument_Engine__oil_pressure"), false)) {
																																															{
																																															if(Equals(first_fixing_attempt, true)) {
																																																			{
																																																			event_info = "Engine__oil_pressure too low, back to state PreflightInspection";
																																																			go_to_next_state("PreflightInspection");
																																																			first_fixing_attempt = false;
																																																			Set_Engine__ignition_switch("OFF")
																																																			;}
																																																	;} else {
																																																			{
																																																			killme_info = "low engine oil pressure";
																																																			go_to_next_state("LeavingFrequency")
																																																			;}
																																																		;}
																																															;}
																																													;} 
																																											;}
																																									;} 
																																							;}
																																					;} 
																																			;}
																																	;} else {
																																			if(Equals(next_action, "Check_Instrument_Engine__oil_temperature")) {
																																							{
																																							timehandler.create_action_duration(3,2,"pilot_age_and_experience");
																																							if(timehandler.hold_action_time(timehandler.action_duration)
																																							) {
																																											{
																																											next_action = "End_of_Actions";
																																											if(Check_Instrument_Engine__oil_temperature() > myAircraft.Get_Engine__oil_temperature_normal_max()
																																											) {
																																															{
																																															if(Equals(skip_action(0.05,"Check_Instrument_Engine__oil_temperature"), false)) {
																																																			{
																																																			if(Equals(first_fixing_attempt, true)) {
																																																							{
																																																							event_info = "Engine__oil_temperature too high, back to state PreflightInspection";
																																																							go_to_next_state("PreflightInspection");
																																																							first_fixing_attempt = false;
																																																							Set_Engine__ignition_switch("OFF")
																																																							;}
																																																					;} else {
																																																							{
																																																							killme_info = "high engine oil temperature";
																																																							go_to_next_state("LeavingFrequency")
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
																										;}
																						;}
																		;}
														;}
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("TakeOffPreparationRequest")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void TakeOffPreparationRequest_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Communicate_on_frequency";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Communicate_on_frequency")) {
							{
							timehandler.create_action_duration(2,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											agentlayer.Communicate_request_on_frequency(myAircraft_callsign,"Tower","RequestTakeOffPreparationPoint");
											next_action = "Listen_receiver_on_frequency"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Listen_receiver_on_frequency")) {
											{
											string temp_receiver = agentlayer.Listen_receiver_on_frequency();
											if(Equals(temp_receiver, myAircraft_callsign)) {
															{
															taxi_path = agentlayer.Listen_message_information_path_on_frequency();
															next_action = "Clear_frequency"
															;}
													;} ;
											timehandler.create_action_duration(10,5,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															next_action = "Communicate_on_frequency"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Clear_frequency")) {
															{
															timehandler.create_action_duration(2,2,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			agentlayer.Clear_frequency();
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("Taxiing");
							state_after_taxiing = "TakeOffPreparation"
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void TakeOffPreparation_action() 
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
							timehandler.create_action_duration(2,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											Set_Brake__parking_brake("SET");
											next_action = "Check_all_Flight_Instruments"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Check_all_Flight_Instruments")) {
											{
											timehandler.create_action_duration(20,10,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															Check_Instrument_LWT__fuel_quantitity();
															Check_Instrument_RWT__fuel_quantitity();
															Check_Instrument_Aircraft__height();
															Check_Instrument_Aircraft__rate_of_climb();
															Check_Instrument_Aircraft__pitch();
															Check_Instrument_Aircraft__true_air_speed();
															next_action = "Set_Engine__mixture_control"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Set_Engine__mixture_control")) {
															{
															timehandler.create_action_duration(4,2,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			if(Equals(skip_action(0.05,"Set_Engine__mixture_control"), false)) {
																							{
																							Set_Engine__mixture_control("RICH")
																							;}
																					;} ;
																			next_action = "Apply_Engine__throttle_to_1700RPM";
																			temp_throttle_value = 0.20
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "Apply_Engine__throttle_to_1700RPM")) {
																			{
																			timehandler.create_action_duration(1,1,"pilot_age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							Apply_Engine__throttle(temp_throttle_value);
																							if(Check_Instrument_Engine__RPM() < 1700) {
																											{
																											temp_throttle_value = temp_throttle_value + 0.05;
																											next_action = "Apply_Engine__throttle_to_1700RPM"
																											;}
																									;} else {
																											{
																											next_action = "Check_Engine_Instruments"
																											;}
																										;}
																							;}
																					;} 
																			;}
																	;} else {
																			if(Equals(next_action, "Check_Engine_Instruments")) {
																							{
																							timehandler.create_action_duration(10,5,"pilot_age_and_experience");
																							if(timehandler.hold_action_time(timehandler.action_duration)
																							) {
																											{
																											if(Check_Instrument_Engine__oil_temperature() > myAircraft.Get_Engine__oil_temperature_normal_max()
																											) {
																															{
																															if(Equals(skip_action(0.05,"Check_Instrument_Engine__oil_temperature"), false)) {
																																			{
																																			killme_info = "high engine oil temperature";
																																			go_to_next_state("LeavingFrequency")
																																			;}
																																	;} 
																															;}
																													;} ;
																											if(Check_Instrument_Engine__oil_pressure() < myAircraft.Get_Engine__oil_pressure_normal_min()
																											) {
																															{
																															if(Equals(skip_action(0.05,"Check_Instrument_Engine__oil_pressure"), false)) {
																																			{
																																			killme_info = "low engine oil pressure";
																																			go_to_next_state("LeavingFrequency")
																																			;}
																																	;} 
																															;}
																													;} ;
																											next_action = "Apply_Engine__throttle_idle";
																											temp_throttle_value = 0.10
																											;}
																									;} 
																							;}
																					;} else {
																							if(Equals(next_action, "Apply_Engine__throttle_idle")) {
																											{
																											timehandler.create_action_duration(3,2,"pilot_age_and_experience");
																											if(timehandler.hold_action_time(timehandler.action_duration)
																											) {
																															{
																															Apply_Engine__throttle(temp_throttle_value);
																															next_action = "End_of_Actions"
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
							go_to_next_state("TakeOffHoldShortRequest")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void TakeOffHoldShortRequest_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Communicate_on_frequency";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Communicate_on_frequency")) {
							{
							timehandler.create_action_duration(2,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											agentlayer.Communicate_request_on_frequency(myAircraft_callsign,"Tower","RequestTakeOffHoldShortPoint");
											next_action = "Listen_receiver_on_frequency"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Listen_receiver_on_frequency")) {
											{
											string temp_receiver = agentlayer.Listen_receiver_on_frequency();
											if(Equals(temp_receiver, myAircraft_callsign)) {
															{
															taxi_path = agentlayer.Listen_message_information_path_on_frequency();
															next_action = "Clear_frequency"
															;}
													;} ;
											timehandler.create_action_duration(10,5,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															next_action = "Communicate_on_frequency"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Clear_frequency")) {
															{
															timehandler.create_action_duration(2,2,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			agentlayer.Clear_frequency();
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("Taxiing");
							state_after_taxiing = "TakeOffRequest"
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void TakeOffRequest_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Communicate_on_frequency";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Communicate_on_frequency")) {
							{
							timehandler.create_action_duration(2,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											agentlayer.Communicate_request_on_frequency(myAircraft_callsign,"Tower","RequestTakeOff");
											next_action = "Listen_receiver_on_frequency"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Listen_receiver_on_frequency")) {
											{
											string temp_receiver = agentlayer.Listen_receiver_on_frequency();
											if(Equals(temp_receiver, myAircraft_callsign)) {
															{
															bool temp_bool = agentlayer.Listen_message_information_bool();
															if(Equals(temp_bool, true)) {
																			{
																			taxi_path = agentlayer.Listen_message_information_path_on_frequency();
																			heading_information = agentlayer.Listen_message_information_heading();
																			next_action = "Clear_frequency"
																			;}
																	;} else {
																			{
																			agentlayer.Clear_frequency();
																			next_action = "Wait_to_communicate_on_frequency"
																			;}
																		;}
															;}
													;} ;
											timehandler.create_action_duration(15,5,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															next_action = "Communicate_on_frequency"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Wait_to_communicate_on_frequency")) {
															{
															timehandler.create_action_duration(20,5,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			next_action = "Communicate_on_frequency"
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "Clear_frequency")) {
																			{
																			timehandler.create_action_duration(2,2,"pilot_age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							agentlayer.Clear_frequency();
																							next_action = "End_of_Actions"
																							;}
																					;} 
																			;}
																	;} 
														;}
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("Taxiing");
							state_after_taxiing = "TakeOff"
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void TakeOff_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Set_Throttle_and_Heading";
							first_action_set = true
							;}
					;} ;
			if(Equals(myAircraft.Get_Aircraft__flight_phase()
			, "on-ground")) {
							{
							takeoff_distance = takeoff_distance + myAircraft.Get_Aircraft__ground_speed_x()
							 * 1
							;}
					;} ;
			if(Equals(next_action, "Set_Throttle_and_Heading")) {
							{
							timehandler.create_action_duration(4,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											Set_Aircraft__heading_bearing(heading_information);
											Apply_Engine__throttle(1.0);
											Apply_Brake__deceleration(0.0);
											temp_pitch_value = 0;
											next_action = "ReadyForRotate"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "ReadyForRotate")) {
											{
											timehandler.create_action_duration(1,1,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															if(Check_Instrument_Aircraft__true_air_speed() > V_rotate) {
																			{
																			temp_pitch_value = temp_pitch_value + 2;
																			Apply_Aircraft__pitch(temp_pitch_value);
																			if(temp_pitch_value >= 8) {
																							{
																							next_action = "HoldAircraft"
																							;}
																					;} 
																			;}
																	;} 
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "HoldAircraft")) {
															{
															timehandler.create_action_duration(5,1,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			if(Check_Instrument_Aircraft__height() > 0) {
																							{
																							next_action = "End_of_Actions"
																							;}
																					;} else {
																							{
																							temp_pitch_value = 0;
																							Apply_Aircraft__pitch(temp_pitch_value);
																							V_rotate = V_rotate + 5;
																							next_action = "ReadyForRotate"
																							;}
																						;}
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "ControlAircraft")) {
																			{
																			timehandler.create_action_duration(3,1,"pilot_age_and_experience");
																			if(timehandler.hold_action_time(timehandler.action_duration)
																			) {
																							{
																							if(Equals(Hear_Aircraft__stall_sound(), true)) {
																											{
																											temp_pitch_value = temp_pitch_value - 1
																											;}
																									;} else {
																											if(Check_Instrument_Aircraft__rate_of_climb() > 3) {
																															{
																															if(Equals(Feel_Aircraft__deceleration_z(), false)) {
																																			{
																																			temp_pitch_value = temp_pitch_value - 0.5
																																			;}
																																	;} 
																															;}
																													;} else {
																															if(Check_Instrument_Aircraft__rate_of_climb() < 1) {
																																			{
																																			if(Equals(Feel_Aircraft__acceleration_z(), false)) {
																																							{
																																							temp_pitch_value = temp_pitch_value + 0.5
																																							;}
																																					;} 
																																			;}
																																	;} 
																														;}
																										;};
																							Apply_Aircraft__pitch(temp_pitch_value);
																							if(Check_Instrument_Aircraft__height() > 300) {
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
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("Climb")
							;}
					;} ;
			if(Equals(myAircraft.Get_Engine__failure()
			, true)) {
							{
							killme_info = "Engine__Failure during TakeOff";
							go_to_next_state("LeavingFrequency")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Climb_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "ControlAircraft"
							;}
					;} ;
			if(Equals(next_action, "ControlAircraft")) {
							{
							timehandler.create_action_duration(3,1,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											if(Equals(Hear_Aircraft__stall_sound(), true)) {
															{
															temp_pitch_value = temp_pitch_value - 1
															;}
													;} else {
															if(Check_Instrument_Aircraft__rate_of_climb() > 3) {
																			{
																			if(Equals(Feel_Aircraft__deceleration_z(), false)) {
																							{
																							temp_pitch_value = temp_pitch_value - 0.5
																							;}
																					;} 
																			;}
																	;} else {
																			if(Check_Instrument_Aircraft__rate_of_climb() < 1) {
																							{
																							if(Equals(Feel_Aircraft__acceleration_z(), false)) {
																											{
																											temp_pitch_value = temp_pitch_value + 0.5
																											;}
																									;} 
																							;}
																					;} 
																		;}
														;};
											Apply_Aircraft__pitch(temp_pitch_value);
											if(Check_Instrument_Aircraft__height() > 250) {
															{
															next_action = "End_of_Actions"
															;}
													;} 
											;}
									;} 
							;}
					;} ;
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("LeavingFrequencyRequest")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void LeavingFrequencyRequest_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Communicate_on_frequency";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Communicate_on_frequency")) {
							{
							timehandler.create_action_duration(2,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											agentlayer.Communicate_request_on_frequency(myAircraft_callsign,"Tower","RequestLeavingAirpsace");
											next_action = "Listen_receiver_on_frequency"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Listen_receiver_on_frequency")) {
											{
											string temp_receiver = agentlayer.Listen_receiver_on_frequency();
											if(Equals(temp_receiver, myAircraft_callsign)) {
															{
															bool temp_bool = agentlayer.Listen_message_information_bool();
															if(Equals(temp_bool, true)) {
																			{
																			next_action = "Clear_frequency"
																			;}
																	;} 
															;}
													;} ;
											timehandler.create_action_duration(10,5,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															next_action = "Communicate_on_frequency"
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Clear_frequency")) {
															{
															timehandler.create_action_duration(2,2,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			agentlayer.Clear_frequency();
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("LeavingFrequency");
							killme_info = "TakeOffComplete"
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void LandingRequest_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Communicate_on_frequency";
							first_action_set = true;
							request_attempts = 0
							;}
					;} ;
			if(Equals(next_action, "Communicate_on_frequency")) {
							{
							timehandler.create_action_duration(3,0,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											agentlayer.Communicate_request_on_frequency(myAircraft_callsign,"Tower","RequestLanding");
											next_action = "Listen_receiver_on_frequency"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Listen_receiver_on_frequency")) {
											{
											string temp_receiver = agentlayer.Listen_receiver_on_frequency();
											if(Equals(temp_receiver, myAircraft_callsign)) {
															{
															taxi_path = agentlayer.Listen_message_information_path_on_frequency();
															bool temp_bool = agentlayer.Listen_message_information_bool();
															if(Equals(temp_bool, true)) {
																			{
																			next_action = "Clear_frequency"
																			;}
																	;} else {
																			{
																			agentlayer.Clear_frequency()
																			;}
																		;}
															;}
													;} ;
											timehandler.create_action_duration(10,0,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															if(request_attempts >= 3) {
																			{
																			go_to_next_state("GoAround")
																			;}
																	;} else {
																			{
																			request_attempts = request_attempts + 1;
																			next_action = "Communicate_on_frequency"
																			;}
																		;}
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "Clear_frequency")) {
															{
															timehandler.create_action_duration(3,0,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			agentlayer.Clear_frequency();
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("Landing")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void GoAround_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "GoAround";
							first_action_set = true;
							temp_pitch_value = 3.5
							;}
					;} else {
							if(Equals(next_action, "GoAround")) {
											{
											if(Equals(Hear_Aircraft__stall_sound(), true)) {
															{
															temp_pitch_value = temp_pitch_value - 1
															;}
													;} else {
															if(Check_Instrument_Aircraft__rate_of_climb() > 3) {
																			{
																			if(Equals(Feel_Aircraft__deceleration_z(), false)) {
																							{
																							temp_pitch_value = temp_pitch_value - 0.5
																							;}
																					;} 
																			;}
																	;} else {
																			if(Check_Instrument_Aircraft__rate_of_climb() < 2) {
																							{
																							if(Equals(Feel_Aircraft__acceleration_z(), false)) {
																											{
																											temp_pitch_value = temp_pitch_value + 0.5
																											;}
																									;} 
																							;}
																					;} 
																		;}
														;};
											Set_Aircraft__heading_bearing(myAircraft.Get_Aircraft_heading_bearing()
											 + 5.0);
											Apply_Aircraft__pitch(temp_pitch_value);
											Apply_Engine__throttle(1.0);
											if(Check_Instrument_Aircraft__height() > 100) {
															{
															next_action = "End_of_Actions"
															;}
													;} 
											;}
									;} 
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("LeavingFrequency");
							killme_info = "Go around, no Landing Clearance"
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Landing_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "DescentAircraft";
							first_action_set = true;
							temp_throttle_value = 0.1;
							temp_pitch_value = 3.5
							;}
					;} else {
							if(Equals(next_action, "DescentAircraft")) {
											{
											timehandler.create_action_duration(3,1,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															Set_Aircraft__heading_bearing(heading_information);
															if(Equals(Hear_Aircraft__stall_sound(), true)) {
																			{
																			temp_pitch_value = temp_pitch_value - 1
																			;}
																	;} else {
																			if(Check_Instrument_Aircraft__rate_of_climb() > -0.5) {
																							{
																							if(Equals(Feel_Aircraft__deceleration_z(), false)) {
																											{
																											temp_pitch_value = temp_pitch_value - 0.5
																											;}
																									;} 
																							;}
																					;} else {
																							if(Check_Instrument_Aircraft__rate_of_climb() < -2) {
																											{
																											if(Equals(Feel_Aircraft__acceleration_z(), false)) {
																															{
																															temp_pitch_value = temp_pitch_value + 0.5
																															;}
																													;} 
																											;}
																									;} 
																						;}
																		;};
															Apply_Aircraft__pitch(temp_pitch_value);
															if(Check_Instrument_Aircraft__true_air_speed() > 35) {
																			{
																			if(Equals(Feel_Aircraft__deceleration_x(), false)) {
																							{
																							temp_throttle_value = temp_throttle_value - 0.05
																							;}
																					;} 
																			;}
																	;} else {
																			if(Check_Instrument_Aircraft__true_air_speed() < 25) {
																							{
																							if(Equals(Feel_Aircraft__acceleration_x(), false)) {
																											{
																											temp_throttle_value = temp_throttle_value + 0.05
																											;}
																									;} 
																							;}
																					;} 
																		;};
															if(temp_throttle_value < 0.05) {
																			{
																			temp_throttle_value = 0.05
																			;}
																	;} ;
															Apply_Engine__throttle(temp_throttle_value);
															if(Check_Instrument_Aircraft__height() <= 0) {
																			{
																			next_action = "ApplyBrake"
																			;}
																	;} 
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "ApplyBrake")) {
															{
															Apply_Engine__throttle(0.1);
															Apply_Aircraft__pitch(0.0);
															Apply_Brake__deceleration(0.7);
															timehandler.create_action_duration(2,1,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			if(Check_Visual_Aircraft__ground_speed_x() < 9) {
																							{
																							next_action = "Taxiing_off_runway"
																							;}
																					;} 
																			;}
																	;} 
															;}
													;} else {
															if(Equals(next_action, "Taxiing_off_runway")) {
																			{
																			System.Tuple<double,double> active_taxi_point = taxi_path.Get(active_taxi_point_number);
																			double myAircraft__heading = formula.bearing(myAircraft.Get_position(),
																			active_taxi_point);
																			Set_Aircraft__heading_bearing(myAircraft__heading);
																			distance_to_next_point = formula.haversine(myAircraft.Get_position(),
																			active_taxi_point);
																			Taxiing_normal();
																			if(distance_to_next_point < 15) {
																							{
																							next_action = "End_of_Actions"
																							;}
																					;} 
																			;}
																	;} 
														;}
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							go_to_next_state("Taxiing");
							state_after_taxiing = "LeavingFrequency";
							killme_info = "LandingComplete"
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void LeavingFrequency_action() 
		{
			{
			myAircraft.Teleport(new System.Tuple<double,double>(9.501273,53.559141));
			timehandler.create_action_duration(3,0,"None");
			if(timehandler.hold_action_time(timehandler.action_duration)
			) {
							{
							remove_me_and_my_aircraft(killme_info)
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Taxiing_brake(double throttle, double brake) 
		{
			{
			temp_throttle_value = throttle;
			Apply_Brake__deceleration(brake);
			Apply_Engine__throttle(temp_throttle_value)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Taxiing_to_final_point() 
		{
			{
			if(distance_to_next_point < 20) {
							{
							if(distance_to_next_point < 10) {
											{
											Taxiing_brake(0.1,0.8);
											next_action = "End_of_Actions"
											;}
									;} else {
											{
											if(Check_Visual_Aircraft__ground_speed_x() > 5) {
															{
															Taxiing_brake(0.1,0.2)
															;}
													;} else {
															if(Check_Visual_Aircraft__ground_speed_x() < 1) {
																			{
																			Apply_Brake__deceleration(0.0);
																			if(Equals(Feel_Aircraft__acceleration_x(), false)) {
																							{
																							temp_throttle_value = temp_throttle_value + 0.10;
																							Apply_Engine__throttle(temp_throttle_value)
																							;}
																					;} 
																			;}
																	;} 
														;}
											;}
										;}
							;}
					;} else {
							{
							Taxiing_normal()
							;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Taxiing_normal() 
		{
			{
			Apply_Brake__deceleration(0.0);
			if(Check_Visual_Aircraft__ground_speed_x() > 6) {
							{
							if(Equals(Feel_Aircraft__deceleration_x(), false)) {
											{
											temp_throttle_value = temp_throttle_value - 0.10
											;}
									;} 
							;}
					;} else {
							if(Check_Visual_Aircraft__ground_speed_x() < 2) {
											{
											if(Equals(Feel_Aircraft__acceleration_x(), false)) {
															{
															temp_throttle_value = temp_throttle_value + 0.30
															;}
													;} 
											;}
									;} else {
											if(Check_Visual_Aircraft__ground_speed_x() < 5) {
															{
															if(Equals(Feel_Aircraft__acceleration_x(), false)) {
																			{
																			temp_throttle_value = temp_throttle_value + 0.05
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(temp_throttle_value < 0.05) {
							{
							temp_throttle_value = 0.05
							;}
					;} ;
			Apply_Engine__throttle(temp_throttle_value)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Taxiing_action() 
		{
			{
			int taxi_path_points = taxi_path.Size();
			if(Equals(first_action_set, false)) {
							{
							next_action = "Set_Brake__parking_brake";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Set_Brake__parking_brake")) {
							{
							timehandler.create_action_duration(2,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											Set_Brake__parking_brake("OFF");
											Apply_Brake__deceleration(0.0);
											next_action = "Taxiing"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Taxiing")) {
											{
											bool avoid_collision = false;
											System.Tuple<double,double> active_taxi_point = taxi_path.Get(active_taxi_point_number);
											double myAircraft__heading = formula.bearing(myAircraft.Get_position(),
											active_taxi_point);
											Set_Aircraft__heading_bearing(myAircraft__heading);
											distance_to_next_point = formula.haversine(myAircraft.Get_position(),
											active_taxi_point);
											cessna_digital_twin.Aircraft[] aircraft_array = new System.Func<cessna_digital_twin.Aircraft[]>(() => {
												
												var _sourceMapped1614_48350 = this.Position;
												var _source1614_48350 = _sourceMapped1614_48350;
												var _range1614_48350 = -1;
															
												Func<cessna_digital_twin.Aircraft, bool> _predicate1614_48350 = new Func<cessna_digital_twin.Aircraft,bool>((cessna_digital_twin.Aircraft x) => 
												 {
														{
														return formula.haversine(myAircraft.Get_position(),
														x.Get_position()
														)
														 < spacing_to_next_aircraft
														;}
														;
														return default(bool);;
												});
												Func<cessna_digital_twin.Aircraft, bool> _predicateMod1614_48350 = new Func<cessna_digital_twin.Aircraft, bool>(_it => 
												{
													if (_it?.ID == this.ID)
													{
														return false;
													} else if (_predicate1614_48350 != null)
													{
														return _predicate1614_48350.Invoke(_it);
													} else return true;
												});
												
												return _AgentLayer._AircraftEnvironment.Explore(_source1614_48350 , _range1614_48350, -1, _predicate1614_48350).ToArray();
											}).Invoke();
											if(aircraft_array.Length > 1) {
															{
															for(int i = 1;
																	 i < aircraft_array.Length;
																	 i++){
																	 	{
																	 	double bearing_to_next_aircraft = formula.bearing(myAircraft.Get_position(),
																	 	aircraft_array[i].Get_position()
																	 	);
																	 	if(Equals(formula.bearing_between_thresholds(myAircraft__heading,angle_of_vision,bearing_to_next_aircraft)
																	 	, true)) {
																	 					{
																	 					avoid_collision = true
																	 					;}
																	 			;} 
																	 	;}
																	 }
															;}
													;} ;
											if(Equals(avoid_collision, true)) {
															{
															Taxiing_brake(0.1,0.8)
															;}
													;} else {
															{
															if(Equals(taxi_path_points, (active_taxi_point_number + 1))) {
																			{
																			Taxiing_to_final_point()
																			;}
																	;} else {
																			{
																			Taxiing_normal();
																			if(distance_to_next_point < 8) {
																							{
																							active_taxi_point_number = active_taxi_point_number + 1
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
							go_to_next_state(state_after_taxiing);
							first_action_set = false
							;}
					;} ;
			if(Equals(myAircraft.Get_Engine__failure()
			, true)) {
							{
							killme_info = "Engine__Failure during Taxiing";
							go_to_next_state("LeavingFrequency")
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Engine__RPM() 
		{
			{
			return myAircraft.IP_Get_Engine__RPM()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Engine__oil_pressure() 
		{
			{
			return myAircraft.IP_Get_Engine__oil_pressure()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Engine__oil_temperature() 
		{
			{
			return myAircraft.IP_Get_Engine__oil_temperature()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Aircraft__true_air_speed() 
		{
			{
			return myAircraft.IP_Get_Aircraft__true_air_speed()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Aircraft__pitch() 
		{
			{
			return myAircraft.IP_Get_Aircraft__pitch()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Aircraft__rate_of_climb() 
		{
			{
			return myAircraft.IP_Get_Aircraft__rate_of_climb()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_Aircraft__height() 
		{
			{
			return myAircraft.IP_Get_Aircraft__height()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_RWT__fuel_quantitity() 
		{
			{
			return myAircraft.IP_Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Instrument_LWT__fuel_quantitity() 
		{
			{
			return myAircraft.IP_Get_LWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Visual_Aircraft__ground_speed_x() 
		{
			{
			return myAircraft.Get_Aircraft__ground_speed_x()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Feel_Aircraft__acceleration_x() 
		{
			{
			if(myAircraft.Get_Aircraft__acceleration_x()
			 > 0.2) {
							{
							return true
							;}
					;} else {
							{
							return false
							;}
						;}
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Feel_Aircraft__deceleration_x() 
		{
			{
			if(myAircraft.Get_Aircraft__acceleration_x()
			 < -0.2) {
							{
							return true
							;}
					;} else {
							{
							return false
							;}
						;}
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Feel_Aircraft__acceleration_z() 
		{
			{
			if(myAircraft.Get_Aircraft__acceleration_z()
			 > 0.2) {
							{
							return true
							;}
					;} else {
							{
							return false
							;}
						;}
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Feel_Aircraft__deceleration_z() 
		{
			{
			if(myAircraft.Get_Aircraft__acceleration_z()
			 < -0.2) {
							{
							return true
							;}
					;} else {
							{
							return false
							;}
						;}
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Hear_Aircraft__stall_sound() 
		{
			{
			return myAircraft.Get_Aircraft__stall_sound()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Set_Aircraft__heading_bearing(double input) 
		{
			{
			myAircraft.CIP_Set_Aircraft__heading_bearing(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Apply_Engine__throttle(double input) 
		{
			{
			myAircraft.CIP_Apply_Engine__throttle(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Apply_Aircraft__pitch(double input) 
		{
			{
			myAircraft.CIP_Apply_Aircraft__pitch(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Set_Engine__ignition_switch(string input) 
		{
			{
			myAircraft.CIP_Set_Engine__ignition_switch(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Apply_Brake__deceleration(double input) 
		{
			{
			myAircraft.CIP_Apply_Brake__deceleration(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Set_Brake__parking_brake(string input) 
		{
			{
			myAircraft.CIP_Set_Brake__parking_brake(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Set_Engine__mixture_control(string input) 
		{
			{
			myAircraft.CIP_Set_Engine__mixture_control(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Set_CIP__master_switch(string input) 
		{
			{
			myAircraft.CIP_Set__master_switch(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual int Check_Visual_TireRightMainWheel__inflation() 
		{
			{
			return myAircraft.Get_TireRightMainWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual int Check_Visual_TireLeftMainWheel__inflation() 
		{
			{
			return myAircraft.Get_TireLeftMainWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual int Check_Visual_TireNoseWheel__inflation() 
		{
			{
			return myAircraft.Get_TireNoseWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Visual_RWT__fuel_quantity() 
		{
			{
			return myAircraft.Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Visual_LWT__fuel_quantity() 
		{
			{
			return myAircraft.Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Check_Visual_RWT__water_sediments() 
		{
			{
			return myAircraft.Get_RWT__water_sediments()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Repair_Visual_RWT__water_sediments() 
		{
			{
			myAircraft.Repair_RWT__water_sediments()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Check_Visual_LWT__water_sediments() 
		{
			{
			return myAircraft.Get_LWT__water_sediments()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Repair_Visual_LWT__water_sediments() 
		{
			{
			myAircraft.Repair_LWT__water_sediments()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Check_Visual_Engine__running() 
		{
			{
			return myAircraft.Get_Engine__running()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Check_Visual_Engine__oil() 
		{
			{
			return myAircraft.Get_Engine__oil()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Refill_Visual_Engine__oil() 
		{
			{
			myAircraft.Refill_Engine__oil()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public string Get_state() {
			{
			return state
					;
			}
			
			return default(string);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Initialize_landing(
		double heading) {
			{
			state = "LandingRequest";
			heading_information = heading
			;}
			
			return;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Weather> _WeatherEnvironment { get; set; }
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Pilot (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment,
		double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			_AgentLayer._PilotEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			myAircraft = new Func<cessna_digital_twin.Aircraft>(() => {
				Func<cessna_digital_twin.Aircraft, bool> _predicate248_8618 = new Func<cessna_digital_twin.Aircraft,bool>((cessna_digital_twin.Aircraft it) => 
				 {
						{
						return Equals(it.Get_occupy_bool()
						, false)
						;}
						;
						return default(bool);;
				});
				Func<cessna_digital_twin.Aircraft, bool> _predicateMod248_8618 = new Func<cessna_digital_twin.Aircraft, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate248_8618 != null)
					{
						return _predicate248_8618.Invoke(_it);
					} else return true;
				});
				
				const int _range248_8618 = -1;
				var _source248_8618 = this.Position;
				
				return _AgentLayer._AircraftEnvironment.Explore(_source248_8618, _range248_8618, 1, _predicateMod248_8618)?.FirstOrDefault();
			}).Invoke();
			myAircraft.Set_occupied();
			myAircraft_callsign = myAircraft.Get_callsign();
			weather = new Func<cessna_digital_twin.Weather>(() => {
				Func<cessna_digital_twin.Weather, bool> _predicate251_8824 = null;
				Func<cessna_digital_twin.Weather, bool> _predicateMod251_8824 = new Func<cessna_digital_twin.Weather, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate251_8824 != null)
					{
						return _predicate251_8824.Invoke(_it);
					} else return true;
				});
				
				const int _range251_8824 = -1;
				var _source251_8824 = this.Position;
				
				return _AgentLayer._WeatherEnvironment.Explore(_source251_8824, _range251_8824, 1, _predicateMod251_8824)?.FirstOrDefault();
			}).Invoke();
			update_general_values();
			state = "PreflightInspection";
			current_activity = "Initialization:)";
			event_info = "None";
			takeoff_distance = 0;
			age = age_min + _Random.Next((age_max - age_min) + 1);
			flight_experience = Mars.Mathematics.Statistics.RandomHelper.NextDouble(_Random, 0, (age - age_min) * flight_experience_max / (age_max - age_min));
			timehandler.initialize_variables(age,flight_experience,flight_experience_max,age_max,age_min)
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
									;} else {
											if(Equals(state, "TakeOffPreparationRequest")) {
															{
															TakeOffPreparationRequest_action()
															;}
													;} else {
															if(Equals(state, "Taxiing")) {
																			{
																			Taxiing_action()
																			;}
																	;} else {
																			if(Equals(state, "TakeOffPreparation")) {
																							{
																							TakeOffPreparation_action()
																							;}
																					;} else {
																							if(Equals(state, "TakeOffHoldShortRequest")) {
																											{
																											TakeOffHoldShortRequest_action()
																											;}
																									;} else {
																											if(Equals(state, "TakeOffRequest")) {
																															{
																															TakeOffRequest_action()
																															;}
																													;} else {
																															if(Equals(state, "TakeOff")) {
																																			{
																																			TakeOff_action()
																																			;}
																																	;} else {
																																			if(Equals(state, "Climb")) {
																																							{
																																							Climb_action()
																																							;}
																																					;} else {
																																							if(Equals(state, "LeavingFrequencyRequest")) {
																																											{
																																											LeavingFrequencyRequest_action()
																																											;}
																																									;} else {
																																											if(Equals(state, "LandingRequest")) {
																																															{
																																															LandingRequest_action()
																																															;}
																																													;} else {
																																															if(Equals(state, "GoAround")) {
																																																			{
																																																			GoAround_action()
																																																			;}
																																																	;} else {
																																																			if(Equals(state, "Landing")) {
																																																							{
																																																							Landing_action()
																																																							;}
																																																					;} else {
																																																							if(Equals(state, "LeavingFrequency")) {
																																																											{
																																																											LeavingFrequency_action()
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
