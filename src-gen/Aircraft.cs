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
		private string __Aircraft__callsign
			 = default(string);
		public string Aircraft__callsign { 
			get { return __Aircraft__callsign; }
			set{
				if(__Aircraft__callsign != value) __Aircraft__callsign = value;
			}
		}
		private double __Aircraft__weight
			 = 725.0;
		internal double Aircraft__weight { 
			get { return __Aircraft__weight; }
			set{
				if(System.Math.Abs(__Aircraft__weight - value) > 0.0000001) __Aircraft__weight = value;
			}
		}
		private double __Aircraft__wing_area
			 = 15.0;
		internal double Aircraft__wing_area { 
			get { return __Aircraft__wing_area; }
			set{
				if(System.Math.Abs(__Aircraft__wing_area - value) > 0.0000001) __Aircraft__wing_area = value;
			}
		}
		private double __Aircraft__wing_span
			 = 10.1;
		internal double Aircraft__wing_span { 
			get { return __Aircraft__wing_span; }
			set{
				if(System.Math.Abs(__Aircraft__wing_span - value) > 0.0000001) __Aircraft__wing_span = value;
			}
		}
		private double __Aircraft__stall_angle
			 = 14.0;
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
		private double __Aircraft__speed
			 = default(double);
		public double Aircraft__speed { 
			get { return __Aircraft__speed; }
			set{
				if(System.Math.Abs(__Aircraft__speed - value) > 0.0000001) __Aircraft__speed = value;
			}
		}
		private double __Aircraft__movement_x
			 = default(double);
		public double Aircraft__movement_x { 
			get { return __Aircraft__movement_x; }
			set{
				if(System.Math.Abs(__Aircraft__movement_x - value) > 0.0000001) __Aircraft__movement_x = value;
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
		private double __Aircraft__climb_rate
			 = default(double);
		public double Aircraft__climb_rate { 
			get { return __Aircraft__climb_rate; }
			set{
				if(System.Math.Abs(__Aircraft__climb_rate - value) > 0.0000001) __Aircraft__climb_rate = value;
			}
		}
		private double __Aircraft__height_gain
			 = default(double);
		public double Aircraft__height_gain { 
			get { return __Aircraft__height_gain; }
			set{
				if(System.Math.Abs(__Aircraft__height_gain - value) > 0.0000001) __Aircraft__height_gain = value;
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
		internal double Aircraft__lift_coefficient { 
			get { return __Aircraft__lift_coefficient; }
			set{
				if(System.Math.Abs(__Aircraft__lift_coefficient - value) > 0.0000001) __Aircraft__lift_coefficient = value;
			}
		}
		private double __Aircraft__lift_coefficient_slope
			 = 4.9;
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
			 = 18.0;
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
			 = 0.03;
		internal double Aircraft__zero_lift_drag_coefficient { 
			get { return __Aircraft__zero_lift_drag_coefficient; }
			set{
				if(System.Math.Abs(__Aircraft__zero_lift_drag_coefficient - value) > 0.0000001) __Aircraft__zero_lift_drag_coefficient = value;
			}
		}
		private double __Aircraft__oswald_factor
			 = 0.7;
		internal double Aircraft__oswald_factor { 
			get { return __Aircraft__oswald_factor; }
			set{
				if(System.Math.Abs(__Aircraft__oswald_factor - value) > 0.0000001) __Aircraft__oswald_factor = value;
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
		private double __Propeller__diameter
			 = 1.75;
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
			 = 0.1;
		internal double Propeller__thrust_coefficient_constant { 
			get { return __Propeller__thrust_coefficient_constant; }
			set{
				if(System.Math.Abs(__Propeller__thrust_coefficient_constant - value) > 0.0000001) __Propeller__thrust_coefficient_constant = value;
			}
		}
		private double __Propeller__thrust_coefficient_speed_constant
			 = 25.0;
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
		private double __Engine__mixture_control
			 = default(double);
		public double Engine__mixture_control { 
			get { return __Engine__mixture_control; }
			set{
				if(System.Math.Abs(__Engine__mixture_control - value) > 0.0000001) __Engine__mixture_control = value;
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
			 = 0.05;
		internal double Engine__power_coefficient_constant { 
			get { return __Engine__power_coefficient_constant; }
			set{
				if(System.Math.Abs(__Engine__power_coefficient_constant - value) > 0.0000001) __Engine__power_coefficient_constant = value;
			}
		}
		private double __Engine__power_coefficient_speed_constant
			 = 30.0;
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
		private int __Engine__oil_normal
			 = 5;
		internal int Engine__oil_normal { 
			get { return __Engine__oil_normal; }
			set{
				if(__Engine__oil_normal != value) __Engine__oil_normal = value;
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
		private int __Engine__oil_pressure_min
			 = 70000;
		internal int Engine__oil_pressure_min { 
			get { return __Engine__oil_pressure_min; }
			set{
				if(__Engine__oil_pressure_min != value) __Engine__oil_pressure_min = value;
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
			 = 2750;
		internal int Engine__RPM_max { 
			get { return __Engine__RPM_max; }
			set{
				if(__Engine__RPM_max != value) __Engine__RPM_max = value;
			}
		}
		private int __Engine__power_max
			 = 75000;
		internal int Engine__power_max { 
			get { return __Engine__power_max; }
			set{
				if(__Engine__power_max != value) __Engine__power_max = value;
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
			 = 49;
		internal int LWT__total_capacity { 
			get { return __LWT__total_capacity; }
			set{
				if(__LWT__total_capacity != value) __LWT__total_capacity = value;
			}
		}
		private int __TireRightMainWheel__inflation
			 = default(int);
		public int TireRightMainWheel__inflation { 
			get { return __TireRightMainWheel__inflation; }
			set{
				if(__TireRightMainWheel__inflation != value) __TireRightMainWheel__inflation = value;
			}
		}
		private int __TireLeftMainWheel__inflation
			 = default(int);
		public int TireLeftMainWheel__inflation { 
			get { return __TireLeftMainWheel__inflation; }
			set{
				if(__TireLeftMainWheel__inflation != value) __TireLeftMainWheel__inflation = value;
			}
		}
		private int __TireNoseWheel__inflation
			 = default(int);
		public int TireNoseWheel__inflation { 
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
		private int __Tire__number_of_wheels
			 = 3;
		internal int Tire__number_of_wheels { 
			get { return __Tire__number_of_wheels; }
			set{
				if(__Tire__number_of_wheels != value) __Tire__number_of_wheels = value;
			}
		}
		private double __Tire__wheel_radius
			 = 0.075;
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
			 = 0.0015;
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
		public void initialize_general_values() 
		{
			{
			double x_spawn = agentlayer.Get_spawn_x_coord();
			double y_spawn = agentlayer.Get_spawn_y_coord();
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget133_3265 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object133_3265 = this;
				
				_AgentLayer._AircraftEnvironment.PosAt(_object133_3265, 
					_taget133_3265.Item1, _taget133_3265.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			Longitude = this.Position.X;
			Latitude = this.Position.Y
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void update_general_values() 
		{
			{
			Longitude = this.Position.X;
			Latitude = this.Position.Y
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft__aspect_ratio() 
		{
			{
			return Mars.Components.Common.Math.Pow(Aircraft__wing_span, 2) / Aircraft__wing_area
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_AircraftCharacteristics() 
		{
			{
			Aircraft__callsign = "Cessna" + _Random.Next(10000)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft__lift_coefficient() 
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
											Aircraft__lift_coefficient = (2 * Aircraft__zero_lift_angle - Aircraft__angle_of_attack) * Mars.Components.Common.Constants.Pi / 180 * Aircraft__lift_coefficient_slope
											;}
										;}
						;};
			return Aircraft__lift_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Aircraft__drag_coefficient() 
		{
			{
			Aircraft__drag_coefficient = Aircraft__zero_lift_drag_coefficient + Mars.Components.Common.Math.Pow(Aircraft__lift_coefficient, 2) / (Aircraft__oswald_factor * Mars.Components.Common.Constants.Pi * Get_Aircraft__aspect_ratio());
			return Aircraft__drag_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_AircraftPhysics() 
		{
			{
			Aircraft__acceleration_x = 0.0;
			Aircraft__speed = 0.0;
			Aircraft__height = 0.0;
			Aircraft__flight_phase = "on-ground";
			Aircraft__lift = 0.0;
			Aircraft__acceleration_z = 0.0;
			Aircraft__climb_rate = 0.0;
			Aircraft__angle_of_attack = 0.0;
			Aircraft__drag = 0.0;
			Aircraft__zero_lift_angle = -4.0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void update_AircraftPhysics() 
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
			Aircraft__lift_coefficient = Get_Aircraft__lift_coefficient();
			Aircraft__lift = Aircraft__lift_coefficient * agentlayer.Get_Weather__density()
			 * Mars.Components.Common.Math.Pow(Aircraft__speed, 2) * Aircraft__wing_area / 2;
			Aircraft__drag_coefficient = Get_Aircraft__drag_coefficient();
			Aircraft__drag = Aircraft__drag_coefficient * agentlayer.Get_Weather__density()
			 * Mars.Components.Common.Math.Pow(Aircraft__speed, 2) * Aircraft__wing_area / 2
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_Brake() 
		{
			{
			Brake__parking_brake = "SET"
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Propeller__thrust_coefficient() 
		{
			{
			if(Aircraft__speed > Propeller__thrust_coefficient_speed_constant) {
							{
							Propeller__thrust_coefficient = Propeller__thrust_coefficient_slope * (Aircraft__speed - Propeller__thrust_coefficient_speed_constant) + Propeller__thrust_coefficient_constant
							;}
					;} else {
							{
							Propeller__thrust_coefficient = Propeller__thrust_coefficient_constant
							;}
						;};
			return Propeller__thrust_coefficient
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_Propeller() 
		{
			{
			Propeller__thrust = 0.0;
			Propeller__thrust_coefficient_slope = -0.002
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void update_Propeller() 
		{
			{
			Propeller__thrust_coefficient = Get_Propeller__thrust_coefficient();
			Propeller__thrust = Propeller__thrust_coefficient * agentlayer.Get_Weather__density()
			 * Mars.Components.Common.Math.Pow((Engine__RPM / 60), 2) * Mars.Components.Common.Math.Pow(Propeller__diameter, 4)
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_Engine__power_coefficient() 
		{
			{
			if(Aircraft__speed > Engine__power_coefficient_speed_constant) {
							{
							Engine__power_coefficient = Engine__power_coefficient_slope * (Aircraft__speed - Engine__power_coefficient_speed_constant) + Engine__power_coefficient_constant
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
		public void initialize_Engine() 
		{
			{
			Engine__oil = 3.1 + _Random.Next(3)
			 + (_Random.Next(10)
			 / 10.0);
			Engine__mixture_control = _Random.Next(101)
			 / 100.0;
			Engine__throttle = _Random.Next(10)
			 / 10.0;
			Engine__ignition_switch = "OFF";
			Engine__RPM = 0.0;
			Engine__power = 0.0;
			Engine__running = false;
			Engine__oil_pressure = 101325;
			Engine__oil_temperature = 15;
			Engine__power_coefficient_slope = -0.0009
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Set_Engine__not_running_values() 
		{
			{
			Engine__RPM = 0.0;
			Engine__oil_pressure = 101325;
			Engine__oil_temperature = 15
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void update_Engine() 
		{
			{
			if(Equals(Engine__running, false)) {
							{
							Set_Engine__not_running_values();
							if(Equals(Engine__ignition_switch, "START") && Equals(CIP__master_switch, "ON")) {
											{
											if(_Random.Next(100)
											 <= 40) {
															{
															System.Console.WriteLine("The engine started successfully.");;
															Engine__running = true
															;}
													;} 
											;}
									;} 
							;}
					;} ;
			if(Equals(Engine__running, true)) {
							{
							Engine__power = Engine__power_max * Engine__throttle;
							Engine__power_coefficient = Get_Engine__power_coefficient();
							Engine__RPM = Mars.Components.Common.Math.Pow((Engine__power / (Engine__power_coefficient * agentlayer.Get_Weather__density()
							 * Mars.Components.Common.Math.Pow(Propeller__diameter, 5))), 0.3333) * 60;
							int temp_Engine__oil_pressure_normal_half = (Engine__oil_pressure_normal_max + Engine__oil_pressure_normal_min) / 2;
							int temp_Engine__oil_temperature_normal_half = (Engine__oil_temperature_normal_max + Engine__oil_temperature_normal_min) / 2;
							Engine__oil_pressure = temp_Engine__oil_pressure_normal_half;
							Engine__oil_temperature = temp_Engine__oil_temperature_normal_half;
							if(Engine__oil < Engine__oil_normal) {
											{
											Engine__oil_pressure = Engine__oil_pressure - ((temp_Engine__oil_pressure_normal_half - Engine__oil_pressure_normal_min) * (Engine__oil_normal - Engine__oil));
											Engine__oil_temperature = Engine__oil_temperature + ((Engine__oil_temperature_normal_max - temp_Engine__oil_temperature_normal_half) * (Engine__oil_normal - Engine__oil))
											;}
									;} 
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_RightWingTank() 
		{
			{
			RWT__fuel_quantity = _Random.Next(RWT__total_capacity + 1);
			RWT__water_sediments = false
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_LeftWingTank() 
		{
			{
			LWT__fuel_quantity = _Random.Next(LWT__total_capacity + 1);
			LWT__water_sediments = false
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_Tire() 
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
		public void update_Tire() 
		{
			{
			if(Equals(Aircraft__flight_phase, "on-ground")) {
							{
							Tire__friction_force = Tire__number_of_wheels * Aircraft__weight * agentlayer.Get_gravity()
							 * Tire__roll_coefficient / Tire__wheel_radius
							;}
					;} else {
							{
							Tire__friction_force = 0
							;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_CIP() 
		{
			{
			CIP__master_switch = "OFF"
			;}
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
		public void CIP_Set_Engine__mixture_control(
		double input) {
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
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
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
			update_general_values();
			update_Engine();
			update_Propeller();
			update_Tire();
			update_AircraftPhysics()
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Aircraft other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
