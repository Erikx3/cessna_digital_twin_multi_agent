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
	public class Weather : Mars.Interfaces.Agent.IMarsDslAgent {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(Weather));
		private readonly System.Random _Random = new System.Random();
		private double __wind_bearing
			 = 107.0;
		internal double wind_bearing { 
			get { return __wind_bearing; }
			set{
				if(System.Math.Abs(__wind_bearing - value) > 0.0000001) __wind_bearing = value;
			}
		}
		private double __wind_speed
			 = 5.0;
		internal double wind_speed { 
			get { return __wind_speed; }
			set{
				if(System.Math.Abs(__wind_speed - value) > 0.0000001) __wind_speed = value;
			}
		}
		private double __density_zero
			 = 1.225;
		internal double density_zero { 
			get { return __density_zero; }
			set{
				if(System.Math.Abs(__density_zero - value) > 0.0000001) __density_zero = value;
			}
		}
		private double __temperature
			 = 15.0;
		internal double temperature { 
			get { return __temperature; }
			set{
				if(System.Math.Abs(__temperature - value) > 0.0000001) __temperature = value;
			}
		}
		private double __temperature_zero
			 = 288.15;
		internal double temperature_zero { 
			get { return __temperature_zero; }
			set{
				if(System.Math.Abs(__temperature_zero - value) > 0.0000001) __temperature_zero = value;
			}
		}
		private double __pressure_zero
			 = 101325.0;
		internal double pressure_zero { 
			get { return __pressure_zero; }
			set{
				if(System.Math.Abs(__pressure_zero - value) > 0.0000001) __pressure_zero = value;
			}
		}
		private double __pressure_QNH
			 = 101325.0;
		internal double pressure_QNH { 
			get { return __pressure_QNH; }
			set{
				if(System.Math.Abs(__pressure_QNH - value) > 0.0000001) __pressure_QNH = value;
			}
		}
		private double __L_constant
			 = 0.0065;
		internal double L_constant { 
			get { return __L_constant; }
			set{
				if(System.Math.Abs(__L_constant - value) > 0.0000001) __L_constant = value;
			}
		}
		private double __C_K_constant
			 = 273.15;
		internal double C_K_constant { 
			get { return __C_K_constant; }
			set{
				if(System.Math.Abs(__C_K_constant - value) > 0.0000001) __C_K_constant = value;
			}
		}
		private double __gas_constant
			 = 287.3;
		internal double gas_constant { 
			get { return __gas_constant; }
			set{
				if(System.Math.Abs(__gas_constant - value) > 0.0000001) __gas_constant = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_wind_bearing() {
			{
			return wind_bearing
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_wind_speed() {
			{
			return wind_speed
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_density(
		double height) {
			{
			double pressure_height = default(double);;
			pressure_height = (temperature_zero / L_constant) * (1 - Mars.Components.Common.Math.Pow((pressure_QNH / pressure_zero), (1 / 5.2561)));
			double pressure_height_temperature = default(double);;
			pressure_height_temperature = temperature_zero - L_constant * pressure_height;
			double temperature_isa_delta = default(double);;
			temperature_isa_delta = (temperature + C_K_constant) - pressure_height_temperature;
			double temperature_non_isa = default(double);;
			temperature_non_isa = temperature_zero - L_constant * height + temperature_isa_delta;
			double pressure_non_isa = default(double);;
			pressure_non_isa = pressure_zero * Mars.Components.Common.Math.Pow((1 - height * L_constant / temperature_zero), 5.2561);
			double Weather__density = default(double);;
			Weather__density = pressure_non_isa / (gas_constant * temperature_non_isa);
			return Weather__density
			;}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double Get_temperature() {
			{
			return temperature
					;
			}
			
			return default(double);;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Weather (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<Weather> _WeatherEnvironment,
		double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			_AgentLayer._WeatherEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Weather other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
