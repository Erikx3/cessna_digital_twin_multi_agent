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
		private bool __second_initialize_by_pilot_bool
			 = false;
		internal bool second_initialize_by_pilot_bool { 
			get { return __second_initialize_by_pilot_bool; }
			set{
				if(__second_initialize_by_pilot_bool != value) __second_initialize_by_pilot_bool = value;
			}
		}
		private cessna_digital_twin.UtilityClass __Utility
			 = new cessna_digital_twin.UtilityClass();
		internal cessna_digital_twin.UtilityClass Utility { 
			get { return __Utility; }
			set{
				if(__Utility != value) __Utility = value;
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
		private cessna_digital_twin.Pilot __myPilot
			 = default(cessna_digital_twin.Pilot);
		internal cessna_digital_twin.Pilot myPilot { 
			get { return __myPilot; }
			set{
				if(__myPilot != value) __myPilot = value;
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
		private bool __second_initialize_bool
			 = false;
		internal bool second_initialize_bool { 
			get { return __second_initialize_bool; }
			set{
				if(__second_initialize_bool != value) __second_initialize_bool = value;
			}
		}
		private string __Aircraft__callsign
			 = default(string);
		public string Aircraft__callsign { 
			get { return __Aircraft__callsign; }
			set{
				if(__Aircraft__callsign != value) __Aircraft__callsign = value;
			}
		}
		private int __callsign_number
			 = default(int);
		internal int callsign_number { 
			get { return __callsign_number; }
			set{
				if(__callsign_number != value) __callsign_number = value;
			}
		}
		private double __Aircraft__mass
			 = default(double);
		internal double Aircraft__mass { 
			get { return __Aircraft__mass; }
			set{
				if(System.Math.Abs(__Aircraft__mass - value) > 0.0000001) __Aircraft__mass = value;
			}
		}
		private double __Aircraft__wing_area
			 = default(double);
		internal double Aircraft__wing_area { 
			get { return __Aircraft__wing_area; }
			set{
				if(System.Math.Abs(__Aircraft__wing_area - value) > 0.0000001) __Aircraft__wing_area = value;
			}
		}
		private double __Aircraft__wing_span
			 = default(double);
		internal double Aircraft__wing_span { 
			get { return __Aircraft__wing_span; }
			set{
				if(System.Math.Abs(__Aircraft__wing_span - value) > 0.0000001) __Aircraft__wing_span = value;
			}
		}
		private double __Aircraft__stall_angle
			 = default(double);
		internal double Aircraft__stall_angle { 
			get { return __Aircraft__stall_angle; }
			set{
				if(System.Math.Abs(__Aircraft__stall_angle - value) > 0.0000001) __Aircraft__stall_angle = value;
			}
		}
		private double __Aircraft__acceleration_x
			 = default(double);
		public double Aircraft__acceleration_x { 
			get { return __Aircraft__acceleration_x; }
			set{
				if(System.Math.Abs(__Aircraft__acceleration_x - value) > 0.0000001) __Aircraft__acceleration_x = value;
			}
		}
		private double __Aircraft__true_air_speed_x
			 = default(double);
		public double Aircraft__true_air_speed_x { 
			get { return __Aircraft__true_air_speed_x; }
			set{
				if(System.Math.Abs(__Aircraft__true_air_speed_x - value) > 0.0000001) __Aircraft__true_air_speed_x = value;
			}
		}
		private double __Aircraft__ground_speed_x
			 = default(double);
		public double Aircraft__ground_speed_x { 
			get { return __Aircraft__ground_speed_x; }
			set{
				if(System.Math.Abs(__Aircraft__ground_speed_x - value) > 0.0000001) __Aircraft__ground_speed_x = value;
			}
		}
		private double __Aircraft__true_air_speed
			 = default(double);
		public double Aircraft__true_air_speed { 
			get { return __Aircraft__true_air_speed; }
			set{
				if(System.Math.Abs(__Aircraft__true_air_speed - value) > 0.0000001) __Aircraft__true_air_speed = value;
			}
		}
		private double __Aircraft__movement_x
			 = default(double);
		internal double Aircraft__movement_x { 
			get { return __Aircraft__movement_x; }
			set{
				if(System.Math.Abs(__Aircraft__movement_x - value) > 0.0000001) __Aircraft__movement_x = value;
			}
		}
		private double __Aircraft__heading_bearing
			 = default(double);
		public double Aircraft__heading_bearing { 
			get { return __Aircraft__heading_bearing; }
			set{
				if(System.Math.Abs(__Aircraft__heading_bearing - value) > 0.0000001) __Aircraft__heading_bearing = value;
			}
		}
		private double __Aircraft__height
			 = default(double);
		public double Aircraft__height { 
			get { return __Aircraft__height; }
			set{
				if(System.Math.Abs(__Aircraft__height - value) > 0.0000001) __Aircraft__height = value;
			}
		}
		private string __Aircraft__flight_phase
			 = default(string);
		public string Aircraft__flight_phase { 
			get { return __Aircraft__flight_phase; }
			set{
				if(__Aircraft__flight_phase != value) __Aircraft__flight_phase = value;
			}
		}
		private double __Aircraft__angle_of_attack
			 = default(double);
		public double Aircraft__angle_of_attack { 
			get { return __Aircraft__angle_of_attack; }
			set{
				if(System.Math.Abs(__Aircraft__angle_of_attack - value) > 0.0000001) __Aircraft__angle_of_attack = value;
			}
		}
		private double __Aircraft__pitch
			 = default(double);
		public double Aircraft__pitch { 
			get { return __Aircraft__pitch; }
			set{
				if(System.Math.Abs(__Aircraft__pitch - value) > 0.0000001) __Aircraft__pitch = value;
			}
		}
		private double __Aircraft__climb_angle
			 = default(double);
		public double Aircraft__climb_angle { 
			get { return __Aircraft__climb_angle; }
			set{
				if(System.Math.Abs(__Aircraft__climb_angle - value) > 0.0000001) __Aircraft__climb_angle = value;
			}
		}
		private double __Aircraft__lift
			 = default(double);
		public double Aircraft__lift { 
			get { return __Aircraft__lift; }
			set{
				if(System.Math.Abs(__Aircraft__lift - value) > 0.0000001) __Aircraft__lift = value;
			}
		}
		private double __Aircraft__acceleration_z
			 = default(double);
		public double Aircraft__acceleration_z { 
			get { return __Aircraft__acceleration_z; }
			set{
				if(System.Math.Abs(__Aircraft__acceleration_z - value) > 0.0000001) __Aircraft__acceleration_z = value;
			}
		}
		private double __Aircraft__rate_of_climb
			 = default(double);
		public double Aircraft__rate_of_climb { 
			get { return __Aircraft__rate_of_climb; }
			set{
				if(System.Math.Abs(__Aircraft__rate_of_climb - value) > 0.0000001) __Aircraft__rate_of_climb = value;
			}
		}
		private double __Aircraft__drag
			 = default(double);
		public double Aircraft__drag { 
			get { return __Aircraft__drag; }
			set{
				if(System.Math.Abs(__Aircraft__drag - value) > 0.0000001) __Aircraft__drag = value;
			}
		}
		private double __Aircraft__lift_coefficient
			 = default(double);
		public double Aircraft__lift_coefficient { 
			get { return __Aircraft__lift_coefficient; }
			set{
				if(System.Math.Abs(__Aircraft__lift_coefficient - value) > 0.0000001) __Aircraft__lift_coefficient = value;
			}
		}
		private double __Aircraft__lift_coefficient_slope
			 = default(double);
		internal double Aircraft__lift_coefficient_slope { 
			get { return __Aircraft__lift_coefficient_slope; }
			set{
				if(System.Math.Abs(__Aircraft__lift_coefficient_slope - value) > 0.0000001) __Aircraft__lift_coefficient_slope = value;
			}
		}
		private double __Aircraft__zero_lift_angle
			 = default(double);
		internal double Aircraft__zero_lift_angle { 
			get { return __Aircraft__zero_lift_angle; }
			set{
				if(System.Math.Abs(__Aircraft__zero_lift_angle - value) > 0.0000001) __Aircraft__zero_lift_angle = value;
			}
		}
		private double __Aircraft__total_stall_angle
			 = default(double);
		internal double Aircraft__total_stall_angle { 
			get { return __Aircraft__total_stall_angle; }
			set{
				if(System.Math.Abs(__Aircraft__total_stall_angle - value) > 0.0000001) __Aircraft__total_stall_angle = value;
			}
		}
		private double __Aircraft__drag_coefficient
			 = default(double);
		public double Aircraft__drag_coefficient { 
			get { return __Aircraft__drag_coefficient; }
			set{
				if(System.Math.Abs(__Aircraft__drag_coefficient - value) > 0.0000001) __Aircraft__drag_coefficient = value;
			}
		}
		private double __Aircraft__zero_lift_drag_coefficient
			 = default(double);
		internal double Aircraft__zero_lift_drag_coefficient { 
			get { return __Aircraft__zero_lift_drag_coefficient; }
			set{
				if(System.Math.Abs(__Aircraft__zero_lift_drag_coefficient - value) > 0.0000001) __Aircraft__zero_lift_drag_coefficient = value;
			}
		}
		private double __Aircraft__oswald_factor
			 = default(double);
		internal double Aircraft__oswald_factor { 
			get { return __Aircraft__oswald_factor; }
			set{
				if(System.Math.Abs(__Aircraft__oswald_factor - value) > 0.0000001) __Aircraft__oswald_factor = value;
			}
		}
		private int __n_cycle
			 = default(int);
		internal int n_cycle { 
			get { return __n_cycle; }
			set{
				if(__n_cycle != value) __n_cycle = value;
			}
		}
		private string __Brake__parking_brake
			 = default(string);
		public string Brake__parking_brake { 
			get { return __Brake__parking_brake; }
			set{
				if(__Brake__parking_brake != value) __Brake__parking_brake = value;
			}
		}
		private double __Brake__deceleration_application
			 = default(double);
		public double Brake__deceleration_application { 
			get { return __Brake__deceleration_application; }
			set{
				if(System.Math.Abs(__Brake__deceleration_application - value) > 0.0000001) __Brake__deceleration_application = value;
			}
		}
		private double __Brake__deceleration_force
			 = default(double);
		public double Brake__deceleration_force { 
			get { return __Brake__deceleration_force; }
			set{
				if(System.Math.Abs(__Brake__deceleration_force - value) > 0.0000001) __Brake__deceleration_force = value;
			}
		}
		private double __Brake__deceleration_force_max
			 = default(double);
		internal double Brake__deceleration_force_max { 
			get { return __Brake__deceleration_force_max; }
			set{
				if(System.Math.Abs(__Brake__deceleration_force_max - value) > 0.0000001) __Brake__deceleration_force_max = value;
			}
		}
		private double __Propeller__diameter
			 = default(double);
		internal double Propeller__diameter { 
			get { return __Propeller__diameter; }
			set{
				if(System.Math.Abs(__Propeller__diameter - value) > 0.0000001) __Propeller__diameter = value;
			}
		}
		private double __Propeller__thrust
			 = default(double);
		public double Propeller__thrust { 
			get { return __Propeller__thrust; }
			set{
				if(System.Math.Abs(__Propeller__thrust - value) > 0.0000001) __Propeller__thrust = value;
			}
		}
		private double __Propeller__thrust_coefficient
			 = default(double);
		public double Propeller__thrust_coefficient { 
			get { return __Propeller__thrust_coefficient; }
			set{
				if(System.Math.Abs(__Propeller__thrust_coefficient - value) > 0.0000001) __Propeller__thrust_coefficient = value;
			}
		}
		private double __Propeller__thrust_coefficient_slope
			 = default(double);
		internal double Propeller__thrust_coefficient_slope { 
			get { return __Propeller__thrust_coefficient_slope; }
			set{
				if(System.Math.Abs(__Propeller__thrust_coefficient_slope - value) > 0.0000001) __Propeller__thrust_coefficient_slope = value;
			}
		}
		private double __Propeller__thrust_coefficient_constant
			 = default(double);
		internal double Propeller__thrust_coefficient_constant { 
			get { return __Propeller__thrust_coefficient_constant; }
			set{
				if(System.Math.Abs(__Propeller__thrust_coefficient_constant - value) > 0.0000001) __Propeller__thrust_coefficient_constant = value;
			}
		}
		private double __Propeller__thrust_coefficient_speed_constant
			 = default(double);
		internal double Propeller__thrust_coefficient_speed_constant { 
			get { return __Propeller__thrust_coefficient_speed_constant; }
			set{
				if(System.Math.Abs(__Propeller__thrust_coefficient_speed_constant - value) > 0.0000001) __Propeller__thrust_coefficient_speed_constant = value;
			}
		}
		private double __Engine__oil
			 = default(double);
		public double Engine__oil { 
			get { return __Engine__oil; }
			set{
				if(System.Math.Abs(__Engine__oil - value) > 0.0000001) __Engine__oil = value;
			}
		}
		private double __Engine__oil_pressure
			 = default(double);
		public double Engine__oil_pressure { 
			get { return __Engine__oil_pressure; }
			set{
				if(System.Math.Abs(__Engine__oil_pressure - value) > 0.0000001) __Engine__oil_pressure = value;
			}
		}
		private double __Engine__oil_temperature
			 = default(double);
		public double Engine__oil_temperature { 
			get { return __Engine__oil_temperature; }
			set{
				if(System.Math.Abs(__Engine__oil_temperature - value) > 0.0000001) __Engine__oil_temperature = value;
			}
		}
		private string __Engine__mixture_control
			 = default(string);
		public string Engine__mixture_control { 
			get { return __Engine__mixture_control; }
			set{
				if(__Engine__mixture_control != value) __Engine__mixture_control = value;
			}
		}
		private double __Engine__throttle
			 = default(double);
		public double Engine__throttle { 
			get { return __Engine__throttle; }
			set{
				if(System.Math.Abs(__Engine__throttle - value) > 0.0000001) __Engine__throttle = value;
			}
		}
		private double __Engine__power
			 = default(double);
		public double Engine__power { 
			get { return __Engine__power; }
			set{
				if(System.Math.Abs(__Engine__power - value) > 0.0000001) __Engine__power = value;
			}
		}
		private string __Engine__ignition_switch
			 = default(string);
		public string Engine__ignition_switch { 
			get { return __Engine__ignition_switch; }
			set{
				if(__Engine__ignition_switch != value) __Engine__ignition_switch = value;
			}
		}
		private double __Engine__RPM
			 = default(double);
		public double Engine__RPM { 
			get { return __Engine__RPM; }
			set{
				if(System.Math.Abs(__Engine__RPM - value) > 0.0000001) __Engine__RPM = value;
			}
		}
		private bool __Engine__running
			 = default(bool);
		public bool Engine__running { 
			get { return __Engine__running; }
			set{
				if(__Engine__running != value) __Engine__running = value;
			}
		}
		private double __Engine__failure_probability
			 = default(double);
		public double Engine__failure_probability { 
			get { return __Engine__failure_probability; }
			set{
				if(System.Math.Abs(__Engine__failure_probability - value) > 0.0000001) __Engine__failure_probability = value;
			}
		}
		private bool __Engine__failure
			 = default(bool);
		public bool Engine__failure { 
			get { return __Engine__failure; }
			set{
				if(__Engine__failure != value) __Engine__failure = value;
			}
		}
		private double __Engine__fuel_consumption
			 = default(double);
		public double Engine__fuel_consumption { 
			get { return __Engine__fuel_consumption; }
			set{
				if(System.Math.Abs(__Engine__fuel_consumption - value) > 0.0000001) __Engine__fuel_consumption = value;
			}
		}
		private bool __Engine__oil_pump_condition
			 = default(bool);
		public bool Engine__oil_pump_condition { 
			get { return __Engine__oil_pump_condition; }
			set{
				if(__Engine__oil_pump_condition != value) __Engine__oil_pump_condition = value;
			}
		}
		private double __Engine__oil_leakage
			 = default(double);
		public double Engine__oil_leakage { 
			get { return __Engine__oil_leakage; }
			set{
				if(System.Math.Abs(__Engine__oil_leakage - value) > 0.0000001) __Engine__oil_leakage = value;
			}
		}
		private double __Engine__power_coefficient
			 = default(double);
		internal double Engine__power_coefficient { 
			get { return __Engine__power_coefficient; }
			set{
				if(System.Math.Abs(__Engine__power_coefficient - value) > 0.0000001) __Engine__power_coefficient = value;
			}
		}
		private double __Engine__power_coefficient_slope
			 = default(double);
		internal double Engine__power_coefficient_slope { 
			get { return __Engine__power_coefficient_slope; }
			set{
				if(System.Math.Abs(__Engine__power_coefficient_slope - value) > 0.0000001) __Engine__power_coefficient_slope = value;
			}
		}
		private double __Engine__power_coefficient_constant
			 = default(double);
		internal double Engine__power_coefficient_constant { 
			get { return __Engine__power_coefficient_constant; }
			set{
				if(System.Math.Abs(__Engine__power_coefficient_constant - value) > 0.0000001) __Engine__power_coefficient_constant = value;
			}
		}
		private double __Engine__power_coefficient_speed_constant
			 = default(double);
		internal double Engine__power_coefficient_speed_constant { 
			get { return __Engine__power_coefficient_speed_constant; }
			set{
				if(System.Math.Abs(__Engine__power_coefficient_speed_constant - value) > 0.0000001) __Engine__power_coefficient_speed_constant = value;
			}
		}
		private int __Engine__oil_max
			 = 6;
		internal int Engine__oil_max { 
			get { return __Engine__oil_max; }
			set{
				if(__Engine__oil_max != value) __Engine__oil_max = value;
			}
		}
		private int __Engine__oil_min
			 = 4;
		internal int Engine__oil_min { 
			get { return __Engine__oil_min; }
			set{
				if(__Engine__oil_min != value) __Engine__oil_min = value;
			}
		}
		private int __Engine__oil_critical_min
			 = 3;
		internal int Engine__oil_critical_min { 
			get { return __Engine__oil_critical_min; }
			set{
				if(__Engine__oil_critical_min != value) __Engine__oil_critical_min = value;
			}
		}
		private int __Engine__oil_pressure_normal_min
			 = 205000;
		internal int Engine__oil_pressure_normal_min { 
			get { return __Engine__oil_pressure_normal_min; }
			set{
				if(__Engine__oil_pressure_normal_min != value) __Engine__oil_pressure_normal_min = value;
			}
		}
		private int __Engine__oil_pressure_normal_max
			 = 410000;
		internal int Engine__oil_pressure_normal_max { 
			get { return __Engine__oil_pressure_normal_max; }
			set{
				if(__Engine__oil_pressure_normal_max != value) __Engine__oil_pressure_normal_max = value;
			}
		}
		private int __Engine__oil_temperature_normal_min
			 = 38;
		internal int Engine__oil_temperature_normal_min { 
			get { return __Engine__oil_temperature_normal_min; }
			set{
				if(__Engine__oil_temperature_normal_min != value) __Engine__oil_temperature_normal_min = value;
			}
		}
		private int __Engine__oil_temperature_normal_max
			 = 116;
		internal int Engine__oil_temperature_normal_max { 
			get { return __Engine__oil_temperature_normal_max; }
			set{
				if(__Engine__oil_temperature_normal_max != value) __Engine__oil_temperature_normal_max = value;
			}
		}
		private int __Engine__RPM_max
			 = default(int);
		internal int Engine__RPM_max { 
			get { return __Engine__RPM_max; }
			set{
				if(__Engine__RPM_max != value) __Engine__RPM_max = value;
			}
		}
		private int __Engine__power_max
			 = default(int);
		internal int Engine__power_max { 
			get { return __Engine__power_max; }
			set{
				if(__Engine__power_max != value) __Engine__power_max = value;
			}
		}
		private double __Engine__fuel_consumption_max
			 = default(double);
		internal double Engine__fuel_consumption_max { 
			get { return __Engine__fuel_consumption_max; }
			set{
				if(System.Math.Abs(__Engine__fuel_consumption_max - value) > 0.0000001) __Engine__fuel_consumption_max = value;
			}
		}
		private double __Engine__oil_pump_condition_probability
			 = default(double);
		internal double Engine__oil_pump_condition_probability { 
			get { return __Engine__oil_pump_condition_probability; }
			set{
				if(System.Math.Abs(__Engine__oil_pump_condition_probability - value) > 0.0000001) __Engine__oil_pump_condition_probability = value;
			}
		}
		private double __Engine__oil_leakage_probability
			 = default(double);
		internal double Engine__oil_leakage_probability { 
			get { return __Engine__oil_leakage_probability; }
			set{
				if(System.Math.Abs(__Engine__oil_leakage_probability - value) > 0.0000001) __Engine__oil_leakage_probability = value;
			}
		}
		private double __Engine__failure_probability_add_water_sediments
			 = default(double);
		internal double Engine__failure_probability_add_water_sediments { 
			get { return __Engine__failure_probability_add_water_sediments; }
			set{
				if(System.Math.Abs(__Engine__failure_probability_add_water_sediments - value) > 0.0000001) __Engine__failure_probability_add_water_sediments = value;
			}
		}
		private double __Engine__failure_probability_add_oil_min
			 = default(double);
		internal double Engine__failure_probability_add_oil_min { 
			get { return __Engine__failure_probability_add_oil_min; }
			set{
				if(System.Math.Abs(__Engine__failure_probability_add_oil_min - value) > 0.0000001) __Engine__failure_probability_add_oil_min = value;
			}
		}
		private double __Engine__failure_probability_add_oil_critical_min
			 = default(double);
		internal double Engine__failure_probability_add_oil_critical_min { 
			get { return __Engine__failure_probability_add_oil_critical_min; }
			set{
				if(System.Math.Abs(__Engine__failure_probability_add_oil_critical_min - value) > 0.0000001) __Engine__failure_probability_add_oil_critical_min = value;
			}
		}
		private double __Engine__failure_probability_add_oil_pump_condition
			 = default(double);
		internal double Engine__failure_probability_add_oil_pump_condition { 
			get { return __Engine__failure_probability_add_oil_pump_condition; }
			set{
				if(System.Math.Abs(__Engine__failure_probability_add_oil_pump_condition - value) > 0.0000001) __Engine__failure_probability_add_oil_pump_condition = value;
			}
		}
		private double __RWT__fuel_quantity
			 = default(double);
		public double RWT__fuel_quantity { 
			get { return __RWT__fuel_quantity; }
			set{
				if(System.Math.Abs(__RWT__fuel_quantity - value) > 0.0000001) __RWT__fuel_quantity = value;
			}
		}
		private bool __RWT__water_sediments
			 = default(bool);
		public bool RWT__water_sediments { 
			get { return __RWT__water_sediments; }
			set{
				if(__RWT__water_sediments != value) __RWT__water_sediments = value;
			}
		}
		private int __RWT__total_capacity
			 = 49;
		internal int RWT__total_capacity { 
			get { return __RWT__total_capacity; }
			set{
				if(__RWT__total_capacity != value) __RWT__total_capacity = value;
			}
		}
		private double __RWT__water_sediments_probability
			 = default(double);
		internal double RWT__water_sediments_probability { 
			get { return __RWT__water_sediments_probability; }
			set{
				if(System.Math.Abs(__RWT__water_sediments_probability - value) > 0.0000001) __RWT__water_sediments_probability = value;
			}
		}
		private double __LWT__fuel_quantity
			 = default(double);
		public double LWT__fuel_quantity { 
			get { return __LWT__fuel_quantity; }
			set{
				if(System.Math.Abs(__LWT__fuel_quantity - value) > 0.0000001) __LWT__fuel_quantity = value;
			}
		}
		private bool __LWT__water_sediments
			 = default(bool);
		public bool LWT__water_sediments { 
			get { return __LWT__water_sediments; }
			set{
				if(__LWT__water_sediments != value) __LWT__water_sediments = value;
			}
		}
		private int __LWT__total_capacity
			 = default(int);
		internal int LWT__total_capacity { 
			get { return __LWT__total_capacity; }
			set{
				if(__LWT__total_capacity != value) __LWT__total_capacity = value;
			}
		}
		private double __LWT__water_sediments_probability
			 = default(double);
		internal double LWT__water_sediments_probability { 
			get { return __LWT__water_sediments_probability; }
			set{
				if(System.Math.Abs(__LWT__water_sediments_probability - value) > 0.0000001) __LWT__water_sediments_probability = value;
			}
		}
		private int __TireRightMainWheel__inflation
			 = default(int);
		internal int TireRightMainWheel__inflation { 
			get { return __TireRightMainWheel__inflation; }
			set{
				if(__TireRightMainWheel__inflation != value) __TireRightMainWheel__inflation = value;
			}
		}
		private int __TireLeftMainWheel__inflation
			 = default(int);
		internal int TireLeftMainWheel__inflation { 
			get { return __TireLeftMainWheel__inflation; }
			set{
				if(__TireLeftMainWheel__inflation != value) __TireLeftMainWheel__inflation = value;
			}
		}
		private int __TireNoseWheel__inflation
			 = default(int);
		internal int TireNoseWheel__inflation { 
			get { return __TireNoseWheel__inflation; }
			set{
				if(__TireNoseWheel__inflation != value) __TireNoseWheel__inflation = value;
			}
		}
		private int __TireRightMainWheel__inflation_max
			 = 145000;
		internal int TireRightMainWheel__inflation_max { 
			get { return __TireRightMainWheel__inflation_max; }
			set{
				if(__TireRightMainWheel__inflation_max != value) __TireRightMainWheel__inflation_max = value;
			}
		}
		private int __TireLeftMainWheel__inflation_max
			 = 145000;
		internal int TireLeftMainWheel__inflation_max { 
			get { return __TireLeftMainWheel__inflation_max; }
			set{
				if(__TireLeftMainWheel__inflation_max != value) __TireLeftMainWheel__inflation_max = value;
			}
		}
		private int __TireNoseWheel__inflation_max
			 = 207000;
		internal int TireNoseWheel__inflation_max { 
			get { return __TireNoseWheel__inflation_max; }
			set{
				if(__TireNoseWheel__inflation_max != value) __TireNoseWheel__inflation_max = value;
			}
		}
		private double __Tire__wheel_radius
			 = default(double);
		internal double Tire__wheel_radius { 
			get { return __Tire__wheel_radius; }
			set{
				if(System.Math.Abs(__Tire__wheel_radius - value) > 0.0000001) __Tire__wheel_radius = value;
			}
		}
		private double __Tire__friction_force
			 = default(double);
		public double Tire__friction_force { 
			get { return __Tire__friction_force; }
			set{
				if(System.Math.Abs(__Tire__friction_force - value) > 0.0000001) __Tire__friction_force = value;
			}
		}
		private double __Tire__roll_coefficient
			 = default(double);
		internal double Tire__roll_coefficient { 
			get { return __Tire__roll_coefficient; }
			set{
				if(System.Math.Abs(__Tire__roll_coefficient - value) > 0.0000001) __Tire__roll_coefficient = value;
			}
		}
		private string __CIP__master_switch
			 = default(string);
		public string CIP__master_switch { 
			get { return __CIP__master_switch; }
			set{
				if(__CIP__master_switch != value) __CIP__master_switch = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_general_values() 
		{
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget2085_63422 = new System.Tuple<double,double>(9.4,53.4);
				
				var _object2085_63422 = this;
				
				_AgentLayer._AircraftEnvironment.PosAt(_object2085_63422, 
					_taget2085_63422.Item1, _taget2085_63422.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			Longitude = this.Position.X;
			Latitude = this.Position.Y;
			event_info = "None"
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_general_values() 
		{
			{
			Longitude = this.Position.X;
			Latitude = this.Position.Y
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void second_initialize() 
		{
			{
			if(Equals(second_initialize_bool, false)) {
							{
							cessna_digital_twin.Pilot[] myPilot_array = new System.Func<cessna_digital_twin.Pilot[]>(() => {
								
								var _sourceMapped2105_63884 = this.Position;
								var _source2105_63884 = _sourceMapped2105_63884;
								var _range2105_63884 = -1;
											
								Func<cessna_digital_twin.Pilot, bool> _predicate2105_63884 = new Func<cessna_digital_twin.Pilot,bool>((cessna_digital_twin.Pilot it) => 
								 {
										{
										return Equals(it.Get_callsign()
										, Aircraft__callsign)
										;}
										;
										return default(bool);;
								});
								Func<cessna_digital_twin.Pilot, bool> _predicateMod2105_63884 = new Func<cessna_digital_twin.Pilot, bool>(_it => 
								{
									if (_it?.ID == this.ID)
									{
										return false;
									} else if (_predicate2105_63884 != null)
									{
										return _predicate2105_63884.Invoke(_it);
									} else return true;
								});
								
								return _AgentLayer._PilotEnvironment.Explore(_source2105_63884 , _range2105_63884, -1, _predicate2105_63884).ToArray();
							}).Invoke();
							if(!Equals(myPilot_array.Length, 1)) {
											{
											System.Console.WriteLine("WARNING: Aircraft with callsign " + Aircraft__callsign + " did find " + myPilot_array.Length + " matching pilot(s) (not one) and will be removed!");;
											new System.Action(() => {
												var _target2109_64170 = this;
												if (_target2109_64170 != null) {
													_AgentLayer._KillAircraft(_target2109_64170, _target2109_64170._executionFrequency);
												}
											}).Invoke()
											;}
									;} else {
											{
											myPilot = myPilot_array[0]
											;}
										;};
							weather = new Func<cessna_digital_twin.Weather>(() => {
								Func<cessna_digital_twin.Weather, bool> _predicate2115_64251 = null;
								Func<cessna_digital_twin.Weather, bool> _predicateMod2115_64251 = new Func<cessna_digital_twin.Weather, bool>(_it => 
								{
									if (_it?.ID == this.ID)
									{
										return false;
									} else if (_predicate2115_64251 != null)
									{
										return _predicate2115_64251.Invoke(_it);
									} else return true;
								});
								
								const int _range2115_64251 = -1;
								var _source2115_64251 = this.Position;
								
								return _AgentLayer._WeatherEnvironment.Explore(_source2115_64251, _range2115_64251, 1, _predicateMod2115_64251)?.FirstOrDefault();
							}).Invoke();
							second_initialize_bool = true
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Aircraft__aspect_ratio() 
		{
			{
			return Mars.Components.Common.Math.Pow(Aircraft__wing_span, 2) / Aircraft__wing_area
					;
			}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_AircraftCharacteristics() 
		{
			{
			Aircraft__callsign = "Cessna" + callsign_number
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Aircraft__lift_coefficient() 
		{
			{
			if(Aircraft__angle_of_attack <= Aircraft__stall_angle) {
							{
							Aircraft__lift_coefficient = (Aircraft__angle_of_attack - Aircraft__zero_lift_angle) * Mars.Components.Common.Constants.Pi / 180 * Aircraft__lift_coefficient_slope
							;}
					;} else {
							if(Aircraft__angle_of_attack >= Aircraft__total_stall_angle) {
											{
											Aircraft__lift_coefficient = 0.0
											;}
									;} else {
											{
											Aircraft__lift_coefficient = (2 * Aircraft__stall_angle - Aircraft__angle_of_attack) * Mars.Components.Common.Constants.Pi / 180 * Aircraft__lift_coefficient_slope
											;}
										;}
						;};
			return Aircraft__lift_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Aircraft__drag_coefficient() 
		{
			{
			Aircraft__drag_coefficient = Aircraft__zero_lift_drag_coefficient + Mars.Components.Common.Math.Pow(Aircraft__lift_coefficient, 2) / (Aircraft__oswald_factor * Mars.Components.Common.Constants.Pi * Get_Aircraft__aspect_ratio());
			return Aircraft__drag_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_AircraftPhysics() 
		{
			{
			Aircraft__acceleration_x = 0.0;
			Aircraft__true_air_speed_x = 0.0;
			Aircraft__ground_speed_x = 0.0;
			Aircraft__true_air_speed = 0.0;
			Aircraft__height = 0.0;
			Aircraft__flight_phase = "on-ground";
			Aircraft__lift = 0.0;
			Aircraft__acceleration_z = 0.0;
			Aircraft__rate_of_climb = 0.0;
			Aircraft__angle_of_attack = 0.0;
			Aircraft__pitch = 0.0;
			Aircraft__climb_angle = 0.0;
			Aircraft__drag = 0.0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_AircraftPhysics() 
		{
			{
			if(Aircraft__height > 0) {
							{
							Aircraft__flight_phase = "in-air"
							;}
					;} else {
							{
							Aircraft__flight_phase = "on-ground"
							;}
						;};
			double delta_wind_bearing = ((Aircraft__heading_bearing - weather.Get_wind_bearing()
			) + 180) % 360 - 180;
			double delta_wind_bearing_rad = delta_wind_bearing * Mars.Components.Common.Constants.Pi / 180;
			Aircraft__movement_x = 0;
			for(int i = 0;
					 i < n_cycle;
					 i++){
					 	{
					 	update_Engine_RPM();
					 	update_Propeller();
					 	update_Tire_friction_force();
					 	Aircraft__climb_angle = Mars.Components.Common.Math.Asin(Aircraft__rate_of_climb / Aircraft__true_air_speed)
					 	 * 180 / Mars.Components.Common.Constants.Pi;
					 	Aircraft__angle_of_attack = (Aircraft__pitch - Aircraft__rate_of_climb);
					 	double Aircraft__climb_angle_rad = Aircraft__climb_angle * Mars.Components.Common.Constants.Pi / 180;
					 	Aircraft__lift_coefficient = Get_Aircraft__lift_coefficient();
					 	Aircraft__lift = Aircraft__lift_coefficient * weather.Get_density(Aircraft__height)
					 	 * Mars.Components.Common.Math.Pow(Aircraft__true_air_speed, 2) * Aircraft__wing_area / 2;
					 	Aircraft__drag_coefficient = Get_Aircraft__drag_coefficient();
					 	Aircraft__drag = Aircraft__drag_coefficient * weather.Get_density(Aircraft__height)
					 	 * Mars.Components.Common.Math.Pow(Aircraft__true_air_speed, 2) * Aircraft__wing_area / 2;
					 	Aircraft__acceleration_z = ((Propeller__thrust - Tire__friction_force - Aircraft__drag) * Mars.Components.Common.Math.Sin(Aircraft__climb_angle_rad)
					 	 + Aircraft__lift * Mars.Components.Common.Math.Cos(Aircraft__climb_angle_rad)
					 	 - Aircraft__mass * weather.Get_gravity()
					 	) / Aircraft__mass;
					 	Aircraft__rate_of_climb = Aircraft__rate_of_climb + Aircraft__acceleration_z / n_cycle;
					 	Aircraft__height = Aircraft__height + Aircraft__rate_of_climb / n_cycle;
					 	if(Aircraft__height < 0) {
					 					{
					 					Aircraft__rate_of_climb = 0;
					 					Aircraft__height = 0
					 					;}
					 			;} ;
					 	Aircraft__acceleration_x = ((Propeller__thrust - Tire__friction_force - Aircraft__drag - Brake__deceleration_force) * Mars.Components.Common.Math.Cos(Aircraft__climb_angle_rad)
					 	 - Aircraft__lift * Mars.Components.Common.Math.Sin(Aircraft__climb_angle_rad)
					 	) / Aircraft__mass;
					 	Aircraft__ground_speed_x = Aircraft__ground_speed_x + Aircraft__acceleration_x / n_cycle;
					 	Aircraft__true_air_speed_x = Aircraft__ground_speed_x + weather.Get_wind_speed()
					 	 * Mars.Components.Common.Math.Cos(delta_wind_bearing_rad);
					 	if(Aircraft__true_air_speed_x < 0) {
					 					{
					 					Aircraft__true_air_speed_x = 0
					 					;}
					 			;} ;
					 	if(Aircraft__ground_speed_x < 0) {
					 					{
					 					Aircraft__ground_speed_x = 0
					 					;}
					 			;} ;
					 	Aircraft__movement_x = Aircraft__movement_x + Aircraft__ground_speed_x / n_cycle;
					 	Aircraft__true_air_speed = Mars.Components.Common.Math.Pow((Mars.Components.Common.Math.Pow(Aircraft__true_air_speed_x, 2) + Mars.Components.Common.Math.Pow(Aircraft__rate_of_climb, 2)), 0.5)
					 	;}
					 };
			if(Aircraft__movement_x > 0) {
							{
							new System.Func<Tuple<double,double>>(() => {
								
								var _speed2303_71832 = Aircraft__movement_x
							;
								
								var _entity2303_71832 = this;
								
								Func<double[], bool> _predicate2303_71832 = null;
								
								_AgentLayer._AircraftEnvironment.MoveTowards(_entity2303_71832, Aircraft__heading_bearing, _speed2303_71832);	
								
								return new Tuple<double, double>(Position.X, Position.Y);
							}).Invoke()
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_Brake() 
		{
			{
			Brake__parking_brake = "SET";
			Brake__deceleration_force = 0.0;
			Brake__deceleration_application = 0.0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_Brake() 
		{
			{
			if(Equals(Aircraft__flight_phase, "on-ground")) {
							{
							Brake__deceleration_force = Brake__deceleration_application * Brake__deceleration_force_max;
							if(Equals(Brake__parking_brake, "SET")) {
											{
											Brake__deceleration_force = Brake__deceleration_force_max
											;}
									;} 
							;}
					;} else {
							{
							Brake__deceleration_force = 0
							;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Propeller__thrust_coefficient() 
		{
			{
			if(Aircraft__true_air_speed > Propeller__thrust_coefficient_speed_constant) {
							{
							Propeller__thrust_coefficient = Propeller__thrust_coefficient_slope * (Aircraft__true_air_speed - Propeller__thrust_coefficient_speed_constant) + Propeller__thrust_coefficient_constant
							;}
					;} else {
							{
							Propeller__thrust_coefficient = Propeller__thrust_coefficient_constant
							;}
						;};
			if(Propeller__thrust_coefficient < 0) {
							{
							Propeller__thrust_coefficient = 0
							;}
					;} ;
			return Propeller__thrust_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_Propeller() 
		{
			{
			Propeller__thrust = 0.0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_Propeller() 
		{
			{
			Propeller__thrust_coefficient = Get_Propeller__thrust_coefficient();
			Propeller__thrust = Propeller__thrust_coefficient * weather.Get_density(Aircraft__height)
			 * Mars.Components.Common.Math.Pow((Engine__RPM / 60), 2) * Mars.Components.Common.Math.Pow(Propeller__diameter, 4)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Engine__power_coefficient() 
		{
			{
			if(Aircraft__true_air_speed > Engine__power_coefficient_speed_constant) {
							{
							Engine__power_coefficient = Engine__power_coefficient_slope * (Aircraft__true_air_speed - Engine__power_coefficient_speed_constant) + Engine__power_coefficient_constant
							;}
					;} else {
							{
							Engine__power_coefficient = Engine__power_coefficient_constant
							;}
						;};
			return Engine__power_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_Engine() 
		{
			{
			Engine__oil_pump_condition = Utility.probability_check(Engine__oil_pump_condition_probability);
			Engine__oil_leakage = 0.0;
			if(Equals(Utility.probability_check(Engine__oil_leakage_probability)
			, true)) {
							{
							Engine__oil_leakage = 0.01
							;}
					;} ;
			Engine__oil = 3.1 + _Random.Next(3)
			 + (_Random.Next(10)
			 / 10.0);
			Engine__mixture_control = (new Mars.Components.Common.MarsList<string>() { "LEAN","RICH" }).Get(_Random.Next(2)
			);
			Engine__throttle = _Random.Next(10)
			 / 10.0;
			Engine__ignition_switch = "OFF";
			Engine__RPM = 0.0;
			Engine__power = 0.0;
			Engine__running = false;
			Engine__oil_pressure = 101325;
			Engine__oil_temperature = 15;
			Engine__failure_probability = 0.0;
			Engine__failure = false;
			Engine__fuel_consumption = 0.0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Set_Engine__not_running_values() 
		{
			{
			Engine__running = false;
			Engine__RPM = 0.0;
			Engine__power = 0.0;
			Engine__oil_pressure = 101325;
			Engine__oil_temperature = 15;
			Engine__fuel_consumption = 0.0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Add_Engine__failure_probability(double add) 
		{
			{
			Engine__failure_probability = Engine__failure_probability + add
					;
			}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Calculate_Engine__failure_probability() 
		{
			{
			Engine__failure_probability = 0.0;
			if(Equals(RWT__water_sediments, true)) {
							{
							Add_Engine__failure_probability(Engine__failure_probability_add_water_sediments)
							;}
					;} ;
			if(Equals(LWT__water_sediments, true)) {
							{
							Add_Engine__failure_probability(Engine__failure_probability_add_water_sediments)
							;}
					;} ;
			if(Engine__oil < Engine__oil_min) {
							{
							Add_Engine__failure_probability(Engine__failure_probability_add_oil_min)
							;}
					;} ;
			if(Engine__oil < Engine__oil_critical_min) {
							{
							Add_Engine__failure_probability(Engine__failure_probability_add_oil_critical_min)
							;}
					;} ;
			if(Equals(Engine__oil_pump_condition, false)) {
							{
							Add_Engine__failure_probability(Engine__failure_probability_add_oil_pump_condition)
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_Engine_RPM() 
		{
			{
			Engine__power_coefficient = Get_Engine__power_coefficient();
			Engine__RPM = Mars.Components.Common.Math.Pow((Engine__power / (Engine__power_coefficient * weather.Get_density(Aircraft__height)
			 * Mars.Components.Common.Math.Pow(Propeller__diameter, 5))), 0.3333) * 60;
			if(Engine__RPM > Engine__RPM_max) {
							{
							Engine__RPM = Engine__RPM_max
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_Engine() 
		{
			{
			if(Equals(Engine__running, false) || Equals(Engine__failure, true)) {
							{
							Set_Engine__not_running_values();
							if(Equals(Engine__ignition_switch, "START") && Equals(CIP__master_switch, "ON") && Equals(Engine__failure, false)) {
											{
											if(_Random.Next(100)
											 <= 40) {
															{
															Engine__running = true
															;}
													;} 
											;}
									;} 
							;}
					;} ;
			if(Equals(Engine__running, true) && Equals(Engine__failure, false)) {
							{
							Engine__power = Engine__power_max * Engine__throttle;
							if(Equals(Engine__mixture_control, "LEAN")) {
											{
											Engine__power = Engine__power - Engine__power * 0.1
											;}
									;} ;
							Calculate_Engine__failure_probability();
							if(Equals(Utility.probability_check(Engine__failure_probability)
							, true)) {
											{
											event_info = "Engine Failure";
											Engine__failure = true
											;}
									;} ;
							if(Equals(Engine__ignition_switch, "OFF") || Equals(CIP__master_switch, "OFF")) {
											{
											Engine__running = false
											;}
									;} ;
							Engine__fuel_consumption = Engine__fuel_consumption_max * Engine__throttle;
							Engine__oil = Engine__oil - Engine__oil_leakage;
							int Engine__oil_temperature_slope = (Engine__oil_temperature_normal_min - Engine__oil_temperature_normal_max) / (Engine__oil_max - Engine__oil_min);
							int Engine__oil_pressure_slope = (Engine__oil_pressure_normal_max - Engine__oil_pressure_normal_min) / (Engine__oil_max - Engine__oil_min);
							Engine__oil_pressure = (Engine__oil_pressure_normal_min - Engine__oil_pressure_slope * Engine__oil_min) + Engine__oil_pressure_slope * Engine__oil;
							Engine__oil_temperature = (Engine__oil_temperature_normal_max - Engine__oil_temperature_slope * Engine__oil_min) + Engine__oil_temperature_slope * Engine__oil;
							if(Equals(Engine__oil_pump_condition, false)) {
											{
											Engine__oil_temperature = Engine__oil_temperature + (Engine__oil_temperature_normal_max - Engine__oil_temperature_normal_min) / 2;
											Engine__oil_pressure = Engine__oil_pressure - (Engine__oil_pressure_normal_max - Engine__oil_pressure_normal_min) / 2
											;}
									;} ;
							if(Engine__oil_pressure < 101325) {
											{
											Engine__oil_pressure = 101325
											;}
									;} 
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_RightWingTank() 
		{
			{
			RWT__fuel_quantity = _Random.Next(RWT__total_capacity + 1);
			RWT__water_sediments = Utility.probability_check(RWT__water_sediments_probability)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_RightWingTank() 
		{
			{
			RWT__fuel_quantity = RWT__fuel_quantity - Engine__fuel_consumption / 2
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_LeftWingTank() 
		{
			{
			LWT__fuel_quantity = _Random.Next(LWT__total_capacity + 1);
			LWT__water_sediments = Utility.probability_check(LWT__water_sediments_probability)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_LeftWingTank() 
		{
			{
			LWT__fuel_quantity = LWT__fuel_quantity - Engine__fuel_consumption / 2
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_Tire() 
		{
			{
			TireRightMainWheel__inflation = TireRightMainWheel__inflation_max;
			TireLeftMainWheel__inflation = TireLeftMainWheel__inflation_max;
			TireNoseWheel__inflation = TireNoseWheel__inflation_max;
			Tire__friction_force = 0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_Tire_alternative() 
		{
			{
			if(_Random.Next(100)
			 <= 99) {
							{
							TireRightMainWheel__inflation = TireRightMainWheel__inflation_max
							;}
					;} else {
							{
							TireRightMainWheel__inflation = _Random.Next(TireRightMainWheel__inflation_max)
							;}
						;};
			if(_Random.Next(100)
			 <= 99) {
							{
							TireLeftMainWheel__inflation = TireLeftMainWheel__inflation_max
							;}
					;} else {
							{
							TireLeftMainWheel__inflation = _Random.Next(TireLeftMainWheel__inflation_max)
							;}
						;};
			if(_Random.Next(100)
			 <= 99) {
							{
							TireNoseWheel__inflation = TireNoseWheel__inflation_max
							;}
					;} else {
							{
							TireNoseWheel__inflation = _Random.Next(TireNoseWheel__inflation_max)
							;}
						;};
			Tire__friction_force = 0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void update_Tire_friction_force() 
		{
			{
			if(Equals(Aircraft__flight_phase, "on-ground")) {
							{
							Tire__friction_force = (Aircraft__mass * weather.Get_gravity()
							 - Aircraft__lift) * Tire__roll_coefficient / Tire__wheel_radius
							;}
					;} else {
							{
							Tire__friction_force = 0
							;}
						;};
			if(Tire__friction_force < 0) {
							{
							Tire__friction_force = 0
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_CIP() 
		{
			{
			CIP__master_switch = "OFF"
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Initialize_landing(
		double heading) {
			{
			RWT__fuel_quantity = RWT__total_capacity / 2;
			RWT__water_sediments = false;
			LWT__fuel_quantity = LWT__total_capacity / 2;
			LWT__water_sediments = false;
			TireRightMainWheel__inflation = TireRightMainWheel__inflation_max;
			TireLeftMainWheel__inflation = TireLeftMainWheel__inflation_max;
			TireNoseWheel__inflation = TireNoseWheel__inflation_max;
			Brake__parking_brake = "OFF";
			Engine__oil_pump_condition = true;
			Engine__oil_leakage = 0.0;
			Engine__oil = Engine__oil_max;
			Engine__mixture_control = "RICH";
			Engine__throttle = 0.1;
			Engine__ignition_switch = "BOTH";
			Engine__running = true;
			Engine__failure_probability = 0.0;
			CIP__master_switch = "ON";
			Aircraft__true_air_speed_x = 32.0;
			Aircraft__ground_speed_x = 30.0;
			Aircraft__true_air_speed = 32.04;
			Aircraft__height = 140;
			Aircraft__flight_phase = "in-air";
			Aircraft__rate_of_climb = -1.5;
			Aircraft__pitch = 3.5;
			Aircraft__heading_bearing = heading;
			update_general_values();
			update_Engine();
			update_LeftWingTank();
			update_RightWingTank();
			update_Brake();
			update_AircraftPhysics()
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_second_init_bool(
		bool bo) {
			{
			second_initialize_by_pilot_bool = bo
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public cessna_digital_twin.Pilot Get_pilot() {
			{
			return myPilot
					;
			}
			
			return default(cessna_digital_twin.Pilot);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Remove() {
			{
			new System.Action(() => {
				var _target2078_63258 = this;
				if (_target2078_63258 != null) {
					_AgentLayer._KillAircraft(_target2078_63258, _target2078_63258._executionFrequency);
				}
			}).Invoke()
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Teleport(
		System.Tuple<double,double> cor) {
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget2079_63313 = cor;
				
				var _object2079_63313 = this;
				
				_AgentLayer._AircraftEnvironment.PosAt(_object2079_63313, 
					_taget2079_63313.Item1, _taget2079_63313.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke()
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public System.Tuple<double,double> Get_position() {
			{
			return new System.Tuple<double,double>(this.Position.X,this.Position.Y)
					;
			}
			
			return default(System.Tuple<double,double>);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public string Get_callsign() {
			{
			return Aircraft__callsign
					;
			}
			
			return default(string);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft__acceleration_x() {
			{
			return Aircraft__acceleration_x
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft__acceleration_z() {
			{
			return Aircraft__acceleration_z
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft__ground_speed_x() {
			{
			return Aircraft__ground_speed_x
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Get_Aircraft__stall_sound() {
			{
			if(Aircraft__angle_of_attack >= Aircraft__stall_angle - 1) {
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
		public string Get_Aircraft__flight_phase() {
			{
			return Aircraft__flight_phase
					;
			}
			
			return default(string);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft_heading_bearing() {
			{
			return Aircraft__heading_bearing
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Get_Engine__oil_min() {
			{
			return Engine__oil_min
					;
			}
			
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Get_Engine__oil_temperature_normal_max() {
			{
			return Engine__oil_temperature_normal_max
					;
			}
			
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Get_Engine__oil_pressure_normal_min() {
			{
			return Engine__oil_pressure_normal_min
					;
			}
			
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Get_Engine__failure() {
			{
			return Engine__failure
					;
			}
			
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Get_Engine__running() {
			{
			return Engine__running
					;
			}
			
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Engine__oil() {
			{
			return Engine__oil
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Refill_Engine__oil() {
			{
			Engine__oil = Engine__oil_max
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_RWT__fuel_quantity() {
			{
			return RWT__fuel_quantity
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Get_RWT__water_sediments() {
			{
			return RWT__water_sediments
					;
			}
			
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Repair_RWT__water_sediments() {
			{
			RWT__water_sediments = false
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_LWT__fuel_quantity() {
			{
			return LWT__fuel_quantity
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Get_LWT__water_sediments() {
			{
			return LWT__water_sediments
					;
			}
			
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Repair_LWT__water_sediments() {
			{
			LWT__water_sediments = false
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Get_TireRightMainWheel__inflation() {
			{
			return TireRightMainWheel__inflation
					;
			}
			
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Get_TireLeftMainWheel__inflation() {
			{
			return TireLeftMainWheel__inflation
					;
			}
			
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int Get_TireNoseWheel__inflation() {
			{
			return TireNoseWheel__inflation
					;
			}
			
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Set_Engine__ignition_switch(
		string input) {
			{
			Engine__ignition_switch = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Apply_Engine__throttle(
		double input) {
			{
			Engine__throttle = input;
			if(Engine__throttle < 0) {
							{
							Engine__throttle = 0
							;}
					;} else {
							if(Engine__throttle > 1) {
											{
											Engine__throttle = 1
											;}
									;} 
						;}
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Set_Aircraft__heading_bearing(
		double input) {
			{
			Aircraft__heading_bearing = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Apply_Aircraft__pitch(
		double input) {
			{
			Aircraft__pitch = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Set__master_switch(
		string input) {
			{
			CIP__master_switch = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Set_Brake__parking_brake(
		string input) {
			{
			Brake__parking_brake = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Apply_Brake__deceleration(
		double input) {
			{
			Brake__deceleration_application = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void CIP_Set_Engine__mixture_control(
		string input) {
			{
			Engine__mixture_control = input
			;}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Engine__oil_pressure() {
			{
			return Engine__oil_pressure
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Engine__oil_temperature() {
			{
			return Engine__oil_temperature
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Aircraft__true_air_speed() {
			{
			return Aircraft__true_air_speed
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Aircraft__pitch() {
			{
			return Aircraft__pitch
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Aircraft__rate_of_climb() {
			{
			return Aircraft__rate_of_climb
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Aircraft__height() {
			{
			return Aircraft__height
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_RWT__fuel_quantity() {
			{
			return RWT__fuel_quantity
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_LWT__fuel_quantity() {
			{
			return LWT__fuel_quantity
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double IP_Get_Engine__RPM() {
			{
			return Engine__RPM
			;}
			
			return default(double);;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Weather> _WeatherEnvironment { get; set; }
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Aircraft (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment,
		int callsign_number,
		double Aircraft__mass,
		double Aircraft__wing_area,
		double Aircraft__wing_span,
		double Aircraft__stall_angle,
		double Aircraft__lift_coefficient_slope,
		double Aircraft__zero_lift_angle,
		double Aircraft__total_stall_angle,
		double Aircraft__zero_lift_drag_coefficient,
		double Aircraft__oswald_factor,
		int n_cycle,
		double Brake__deceleration_force_max,
		double Propeller__diameter,
		double Propeller__thrust_coefficient_slope,
		double Propeller__thrust_coefficient_constant,
		double Propeller__thrust_coefficient_speed_constant,
		double Engine__power_coefficient_slope,
		double Engine__power_coefficient_constant,
		double Engine__power_coefficient_speed_constant,
		int Engine__RPM_max,
		int Engine__power_max,
		double Engine__fuel_consumption_max,
		double Engine__oil_pump_condition_probability,
		double Engine__oil_leakage_probability,
		double Engine__failure_probability_add_water_sediments,
		double Engine__failure_probability_add_oil_min,
		double Engine__failure_probability_add_oil_critical_min,
		double Engine__failure_probability_add_oil_pump_condition,
		int RWT__total_capacity,
		double RWT__water_sediments_probability,
		int LWT__total_capacity,
		double LWT__water_sediments_probability,
		double Tire__wheel_radius,
		double Tire__roll_coefficient
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this.callsign_number = callsign_number;
			this.Aircraft__mass = Aircraft__mass;
			this.Aircraft__wing_area = Aircraft__wing_area;
			this.Aircraft__wing_span = Aircraft__wing_span;
			this.Aircraft__stall_angle = Aircraft__stall_angle;
			this.Aircraft__lift_coefficient_slope = Aircraft__lift_coefficient_slope;
			this.Aircraft__zero_lift_angle = Aircraft__zero_lift_angle;
			this.Aircraft__total_stall_angle = Aircraft__total_stall_angle;
			this.Aircraft__zero_lift_drag_coefficient = Aircraft__zero_lift_drag_coefficient;
			this.Aircraft__oswald_factor = Aircraft__oswald_factor;
			this.n_cycle = n_cycle;
			this.Brake__deceleration_force_max = Brake__deceleration_force_max;
			this.Propeller__diameter = Propeller__diameter;
			this.Propeller__thrust_coefficient_slope = Propeller__thrust_coefficient_slope;
			this.Propeller__thrust_coefficient_constant = Propeller__thrust_coefficient_constant;
			this.Propeller__thrust_coefficient_speed_constant = Propeller__thrust_coefficient_speed_constant;
			this.Engine__power_coefficient_slope = Engine__power_coefficient_slope;
			this.Engine__power_coefficient_constant = Engine__power_coefficient_constant;
			this.Engine__power_coefficient_speed_constant = Engine__power_coefficient_speed_constant;
			this.Engine__RPM_max = Engine__RPM_max;
			this.Engine__power_max = Engine__power_max;
			this.Engine__fuel_consumption_max = Engine__fuel_consumption_max;
			this.Engine__oil_pump_condition_probability = Engine__oil_pump_condition_probability;
			this.Engine__oil_leakage_probability = Engine__oil_leakage_probability;
			this.Engine__failure_probability_add_water_sediments = Engine__failure_probability_add_water_sediments;
			this.Engine__failure_probability_add_oil_min = Engine__failure_probability_add_oil_min;
			this.Engine__failure_probability_add_oil_critical_min = Engine__failure_probability_add_oil_critical_min;
			this.Engine__failure_probability_add_oil_pump_condition = Engine__failure_probability_add_oil_pump_condition;
			this.RWT__total_capacity = RWT__total_capacity;
			this.RWT__water_sediments_probability = RWT__water_sediments_probability;
			this.LWT__total_capacity = LWT__total_capacity;
			this.LWT__water_sediments_probability = LWT__water_sediments_probability;
			this.Tire__wheel_radius = Tire__wheel_radius;
			this.Tire__roll_coefficient = Tire__roll_coefficient;
			_AgentLayer._AircraftEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			initialize_general_values();
			initialize_AircraftCharacteristics();
			initialize_RightWingTank();
			initialize_LeftWingTank();
			initialize_Tire();
			initialize_Brake();
			initialize_Engine();
			initialize_Propeller();
			initialize_AircraftPhysics();
			initialize_CIP()
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			second_initialize();
			if(Equals(second_initialize_by_pilot_bool, true)) {
							{
							update_general_values();
							update_Engine();
							update_LeftWingTank();
							update_RightWingTank();
							update_Brake();
							update_AircraftPhysics()
							;}
					;} 
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Aircraft other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
