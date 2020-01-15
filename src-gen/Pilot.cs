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
		private int __heading_information
			 = default(int);
		internal int heading_information { 
			get { return __heading_information; }
			set{
				if(__heading_information != value) __heading_information = value;
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
		private int __flight_experience_max
			 = 57;
		internal int flight_experience_max { 
			get { return __flight_experience_max; }
			set{
				if(__flight_experience_max != value) __flight_experience_max = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void go_to_next_state(string _state) 
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
		public void update_general_values() 
		{
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget207_5663 = (myAircraft.Get_position()
				);
				
				var _object207_5663 = this;
				
				_AgentLayer._PilotEnvironment.PosAt(_object207_5663, 
					_taget207_5663.Item1, _taget207_5663.Item2
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
		public bool skip_action(double base_probability, string action_name) 
		{
			{
			double random_value = Mars.Mathematics.Statistics.RandomHelper.NextDouble(_Random, 0, Mars.Components.Common.Math.Pow(10, 6))
			 / Mars.Components.Common.Math.Pow(10, 6);
			double threshold_value = base_probability + flight_experience / flight_experience_max * 0.1;
			if(random_value > threshold_value) {
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
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state("StartingEngine");
							System.Console.WriteLine("Next state -->" + state);
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
															Set_Engine__mixture_control(0);
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
																											timehandler.create_action_duration(1,0,"pilot_age_and_experience");
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
																																							Check_Instrument_Engine__oil_pressure();
																																							next_action = "Check_Instrument_Engine__oil_temperature"
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
																																											Check_Instrument_Engine__oil_temperature();
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
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state("TakeOffPreparationRequest");
							System.Console.WriteLine("Next state -->" + state);
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void TakeOffPreparationRequest_action() 
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
											System.Console.WriteLine("Communicating on frequency");;
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
															next_action = "Clear_frequency";
															System.Console.WriteLine("Listen on frequency successful");
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
																			System.Console.WriteLine("Clear on frequency successful");;
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state("Taxiing");
							state_after_taxiing = "TakeOffPreparation";
							System.Console.WriteLine("Next state -->" + state);
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void TakeOffPreparation_action() 
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
															Check_Instrument_Aircraft__climb_rate();
															Check_Instrument_Aircraft__angle_of_attack();
															Check_Instrument_Aircraft__speed_x();
															Check_Instrument_Engine__oil_temperature();
															Check_Instrument_Engine__oil_pressure();
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
																			Set_Engine__mixture_control(0.0);
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
																											temp_throttle_value = temp_throttle_value + 0.02;
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
																											Check_Instrument_Engine__oil_temperature();
																											Check_Instrument_Engine__oil_pressure();
																											Check_Instrument_Engine__RPM();
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
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state("TakeOffHoldShortRequest");
							System.Console.WriteLine("Next state -->" + state);
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void TakeOffHoldShortRequest_action() 
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
											System.Console.WriteLine("Communicating on frequency");;
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
															next_action = "Clear_frequency";
															System.Console.WriteLine("Listen on frequency successful");
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
																			System.Console.WriteLine("Clear on frequency successful");;
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state("Taxiing");
							state_after_taxiing = "TakeOffRequest";
							System.Console.WriteLine("Next state -->" + state);
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void TakeOffRequest_action() 
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
											System.Console.WriteLine("Communicating on frequency");;
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
															heading_information = agentlayer.Listen_message_information_heading();
															next_action = "Clear_frequency";
															System.Console.WriteLine("Listen on frequency successful");
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
																			System.Console.WriteLine("Clear on frequency successful");;
																			next_action = "End_of_Actions"
																			;}
																	;} 
															;}
													;} 
										;}
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state("Taxiing");
							state_after_taxiing = "TakeOff";
							System.Console.WriteLine("Next state -->" + state);
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void TakeOff_action() 
		{
			{
			if(Equals(first_action_set, false)) {
							{
							next_action = "Set_Throttle_and_Heading";
							first_action_set = true
							;}
					;} ;
			if(Equals(next_action, "Set_Throttle_and_Heading")) {
							{
							timehandler.create_action_duration(4,2,"pilot_age_and_experience");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											myAircraft.Set_Aircraft__heading_mode("BEARING");
											Set_Aircraft__heading_bearing(heading_information);
											Apply_Engine__throttle(1.0);
											Apply_Brake__deceleration(0.0);
											next_action = "ReadyForRotate"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "ReadyForRotate")) {
											{
											timehandler.create_action_duration(3,1,"pilot_age_and_experience");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															if(Check_Instrument_Aircraft__speed_x() > 30) {
																			{
																			temp_pitch_value = 8;
																			Apply_Aircraft__pitch(temp_pitch_value);
																			next_action = "ControlAircraft"
																			;}
																	;} 
															;}
													;} 
											;}
									;} else {
											if(Equals(next_action, "ControlAircraft")) {
															{
															timehandler.create_action_duration(1,1,"pilot_age_and_experience");
															if(timehandler.hold_action_time(timehandler.action_duration)
															) {
																			{
																			if(Check_Instrument_Aircraft__climb_rate() > 3) {
																							{
																							temp_pitch_value = temp_pitch_value - 1;
																							Apply_Aircraft__pitch(temp_pitch_value)
																							;}
																					;} else {
																							if(Check_Instrument_Aircraft__climb_rate() < 1) {
																											{
																											temp_pitch_value = temp_pitch_value + 1;
																											Apply_Aircraft__pitch(temp_pitch_value)
																											;}
																									;} 
																						;}
																			;}
																	;} ;
															System.Console.WriteLine("Aircraft Speed:");;
															System.Console.WriteLine(Check_Instrument_Aircraft__speed_x());;
															System.Console.WriteLine("Aircraft Height:");;
															System.Console.WriteLine(Check_Instrument_Aircraft__height());
															;}
													;} 
										;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Taxiing_to_final_point() 
		{
			{
			if(distance_to_next_point < 5) {
							{
							Apply_Brake__deceleration(0.5);
							Apply_Engine__throttle(0.10);
							next_action = "End_of_Actions"
							;}
					;} else {
							{
							if(Check_Instrument_Aircraft__speed_x() > 5) {
											{
											Apply_Engine__throttle(0.10);
											Apply_Brake__deceleration(0.2)
											;}
									;} else {
											{
											Apply_Engine__throttle(0.15)
											;}
										;}
							;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Taxiing_normal() 
		{
			{
			if(Check_Instrument_Aircraft__speed_x() > 8) {
							{
							Apply_Engine__throttle(0.10)
							;}
					;} else {
							if(Check_Instrument_Aircraft__speed_x() < 5) {
											{
											Apply_Engine__throttle(0.40)
											;}
									;} else {
											{
											Apply_Engine__throttle(0.20)
											;}
										;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Taxiing_action() 
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
											System.Console.WriteLine("Set braking park OFF and release brake application");;
											next_action = "Taxiing"
											;}
									;} 
							;}
					;} else {
							if(Equals(next_action, "Taxiing")) {
											{
											System.Tuple<double,double> active_taxi_point = taxi_path.Get(active_taxi_point_number);
											myAircraft.Set_Aircraft__heading_mode("COORDINATES");
											Set_Aircraft__heading_coordinates(active_taxi_point);
											distance_to_next_point = formula.haversine(myAircraft.Get_position(),
											active_taxi_point);
											if(distance_to_next_point < 20) {
															{
															if(Equals(taxi_path_points, (active_taxi_point_number + 1))) {
																			{
																			Taxiing_to_final_point()
																			;}
																	;} else {
																			{
																			active_taxi_point_number = active_taxi_point_number + 1;
																			Taxiing_normal()
																			;}
																		;}
															;}
													;} else {
															{
															Taxiing_normal()
															;}
														;};
											System.Console.WriteLine("-----Taxiing-----");;
											System.Console.WriteLine("taxi_path_points : " + taxi_path_points);;
											System.Console.WriteLine("active_taxi_point_number : " + active_taxi_point_number);;
											System.Console.WriteLine("My Position : ");;
											System.Console.WriteLine(myAircraft.Get_position()
											);;
											System.Console.WriteLine("active_taxi_point : ");;
											System.Console.WriteLine(active_taxi_point);;
											System.Console.WriteLine("Current speed : ");;
											System.Console.WriteLine(Check_Instrument_Aircraft__speed_x());;
											System.Console.WriteLine("distance: " + distance_to_next_point);
											;}
									;} 
						;};
			if(Equals(next_action, "End_of_Actions")) {
							{
							System.Console.WriteLine("Finished State -->" + state + " with next action flag -->" + next_action);;
							go_to_next_state(state_after_taxiing);
							System.Console.WriteLine("Next state -->" + state);;
							first_action_set = false
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_Engine__RPM() 
		{
			{
			System.Console.WriteLine("Checking Engine RPM via instrument");;
			return myAircraft.IP_Get_Engine__RPM()
			;}
			return default(double);;
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
		public double Check_Instrument_Aircraft__speed_x() 
		{
			{
			System.Console.WriteLine("Checking Aircraft Speed Instrument");;
			return myAircraft.IP_Get_Aircraft__speed_x()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_Aircraft__angle_of_attack() 
		{
			{
			System.Console.WriteLine("Checking Aircraft angle of attack via instrument");;
			return myAircraft.IP_Get_Aircraft__angle_of_attack()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_Aircraft__climb_rate() 
		{
			{
			System.Console.WriteLine("Checking Aircraft climb of rate via instrument");;
			return myAircraft.IP_Get_Aircraft__climb_rate()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_Aircraft__height() 
		{
			{
			System.Console.WriteLine("Checking Aircraft height via instrument");;
			return myAircraft.IP_Get_Aircraft__height()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_RWT__fuel_quantitity() 
		{
			{
			System.Console.WriteLine("Checking RWT fuel quantity via instrument");;
			return myAircraft.IP_Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Instrument_LWT__fuel_quantitity() 
		{
			{
			System.Console.WriteLine("Checking LWT fuel quantity via instrument");;
			return myAircraft.IP_Get_LWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_Aircraft__heading_bearing(int input) 
		{
			{
			System.Console.WriteLine("Apply heading bearing " + input);;
			myAircraft.CIP_Set_Aircraft__heading_bearing(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_Aircraft__heading_coordinates(System.Tuple<double,double> input) 
		{
			{
			System.Console.WriteLine("Apply heading coordinates");;
			myAircraft.CIP_Set_Aircraft__heading_coordinates(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Apply_Engine__throttle(double input) 
		{
			{
			System.Console.WriteLine("Apply throttle " + input);;
			myAircraft.CIP_Apply_Engine__throttle(input)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Apply_Aircraft__pitch(double input) 
		{
			{
			System.Console.WriteLine("Apply pitch (angle of attack):  " + input);;
			myAircraft.CIP_Apply_Aircraft__pitch(input)
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
		public void Apply_Brake__deceleration(double input) 
		{
			{
			System.Console.WriteLine("Apply Brake " + input);;
			myAircraft.CIP_Apply_Brake__deceleration(input)
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
		public int Check_Visual_TireRightMainWheel__inflation() 
		{
			{
			System.Console.WriteLine("Checking right Main Wheel Tire inflation");;
			return myAircraft.Get_TireRightMainWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Check_Visual_TireLeftMainWheel__inflation() 
		{
			{
			System.Console.WriteLine("Checking left Main Wheel Tire inflation");;
			return myAircraft.Get_TireLeftMainWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Check_Visual_TireNoseWheel__inflation() 
		{
			{
			System.Console.WriteLine("Checking Nose Wheel Tire inflation");;
			return myAircraft.Get_TireNoseWheel__inflation()
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Visual_RWT__fuel_quantity() 
		{
			{
			System.Console.WriteLine("Checking right wing tank fuel quantity");;
			return myAircraft.Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Visual_LWT__fuel_quantity() 
		{
			{
			System.Console.WriteLine("Checking left wing tank fuel quantity");;
			return myAircraft.Get_RWT__fuel_quantity()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Check_Visual_RWT__water_sediments() 
		{
			{
			System.Console.WriteLine("Checking right wing tank for water sediments");;
			return myAircraft.Get_RWT__water_sediments()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Repair_Visual_RWT__water_sediments() 
		{
			{
			System.Console.WriteLine("Repairing right wing tank water sediments");;
			myAircraft.Repair_RWT__water_sediments()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Check_Visual_LWT__water_sediments() 
		{
			{
			System.Console.WriteLine("Checking left wing tank for water sediments");;
			return myAircraft.Get_LWT__water_sediments()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Repair_Visual_LWT__water_sediments() 
		{
			{
			System.Console.WriteLine("Repairing left wing tank water sediments");;
			myAircraft.Repair_LWT__water_sediments()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Check_Visual_Engine__running() 
		{
			{
			System.Console.WriteLine("Checking Engine running");;
			return myAircraft.Get_Engine__running()
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Check_Visual_Engine__oil() 
		{
			{
			System.Console.WriteLine("Checking Engine oil");;
			return myAircraft.Get_Engine__oil()
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Refill_Visual_Engine__oil() 
		{
			{
			System.Console.WriteLine("Refill engine oil");;
			myAircraft.Refill_Engine__oil()
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
			double x_spawn = agentlayer.Get_spawn_x_coord();
			double y_spawn = agentlayer.Get_spawn_y_coord();
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget114_3057 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object114_3057 = this;
				
				_AgentLayer._PilotEnvironment.PosAt(_object114_3057, 
					_taget114_3057.Item1, _taget114_3057.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			myAircraft = new Func<cessna_digital_twin.Aircraft>(() => {
				Func<cessna_digital_twin.Aircraft, bool> _predicate117_3132 = new Func<cessna_digital_twin.Aircraft,bool>((cessna_digital_twin.Aircraft it) => 
				 {
						{
						return Equals(it.Get_occupy_bool()
						, false)
						;}
						;
						return default(bool);;
				});
				Func<cessna_digital_twin.Aircraft, bool> _predicateMod117_3132 = new Func<cessna_digital_twin.Aircraft, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate117_3132 != null)
					{
						return _predicate117_3132.Invoke(_it);
					} else return true;
				});
				
				const int _range117_3132 = -1;
				var _source117_3132 = this.Position;
				
				return _AgentLayer._AircraftEnvironment.Explore(_source117_3132, _range117_3132, 1, _predicateMod117_3132)?.FirstOrDefault();
			}).Invoke();
			myAircraft.Set_occupied();
			myAircraft_callsign = myAircraft.Get_callsign();
			update_general_values();
			state = "PreflightInspection";
			current_activity = "Initialization:)";
			event_info = "None";
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
