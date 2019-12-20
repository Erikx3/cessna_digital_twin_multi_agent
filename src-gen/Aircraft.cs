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
		private double __Engine__oil
			 = default(double);
		public double Engine__oil { 
			get { return __Engine__oil; }
			set{
				if(System.Math.Abs(__Engine__oil - value) > 0.0000001) __Engine__oil = value;
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
		public void initialize_Engine() 
		{
			{
			Engine__oil = _Random.Next(4)
			 + 3
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
						;}
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
			double x_spawn = agentlayer.get_spawn_x_coord();
			double y_spawn = agentlayer.get_spawn_y_coord();
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget38_632 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object38_632 = this;
				
				_AgentLayer._AircraftEnvironment.PosAt(_object38_632, 
					_taget38_632.Item1, _taget38_632.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			update_general_values();
			initialize_RightWingTank();
			initialize_LeftWingTank();
			initialize_Tire();
			initialize_Engine()
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			update_general_values()
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Aircraft other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
