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
	public class AgentLayer : Mars.Components.Layers.AbstractLayer {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(AgentLayer));
		private readonly System.Random _Random = new System.Random();
		public Mars.Interfaces.Layer.UnregisterAgent _Unregister { get; set; }
		public Mars.Interfaces.Layer.RegisterAgent _Register { get; set; }
		public Mars.Mathematics.SpaceDistanceMetric _DistanceMetric { get; set; } = Mars.Mathematics.SpaceDistanceMetric.Euclidean;
		private double _minLon;
		private double _minLat;
		private double _maxLon;
		private double _maxLat;
		private bool _isDefault;
		private int? _cellSizeMeters;
		private Mars.Interfaces.Environment.Position _lowerLeft;
		private Mars.Interfaces.Environment.Position _upperRight;
		private Mars.Interfaces.Environment.Position _lowerRight;
		private Mars.Interfaces.Environment.Position _upperLeft;
		public double MinLon() => _minLon;
		public double MinLat() => _minLat;
		public double MaxLon() => _maxLon;
		public double MaxLat() => _maxLat;
		
		public Mars.Components.Environments.GeoHashEnvironment<AirTrafficController> _AirTrafficControllerEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Observer> _ObserverEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment { get; set; }
		public AirportStadeLayer _AirportStadeLayer { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, AirTrafficController> _AirTrafficControllerAgents { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, Aircraft> _AircraftAgents { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, Observer> _ObserverAgents { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, Pilot> _PilotAgents { get; set; }
		
		public AgentLayer _AgentLayer => this;
		public AgentLayer agentlayer => this;
		private double __Weather__wind_bearing
			 = 107;
		internal double Weather__wind_bearing { 
			get { return __Weather__wind_bearing; }
			set{
				if(System.Math.Abs(__Weather__wind_bearing - value) > 0.0000001) __Weather__wind_bearing = value;
			}
		}
		private double __Weather__wind_speed
			 = 5;
		internal double Weather__wind_speed { 
			get { return __Weather__wind_speed; }
			set{
				if(System.Math.Abs(__Weather__wind_speed - value) > 0.0000001) __Weather__wind_speed = value;
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
		private double __temperature_zero
			 = 288.15;
		internal double temperature_zero { 
			get { return __temperature_zero; }
			set{
				if(System.Math.Abs(__temperature_zero - value) > 0.0000001) __temperature_zero = value;
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
		private double __gravity
			 = 9.81;
		internal double gravity { 
			get { return __gravity; }
			set{
				if(System.Math.Abs(__gravity - value) > 0.0000001) __gravity = value;
			}
		}
		private double __spawn_xcor
			 = 9.4987928;
		internal double spawn_xcor { 
			get { return __spawn_xcor; }
			set{
				if(System.Math.Abs(__spawn_xcor - value) > 0.0000001) __spawn_xcor = value;
			}
		}
		private double __spawn_ycor
			 = 53.560392;
		internal double spawn_ycor { 
			get { return __spawn_ycor; }
			set{
				if(System.Math.Abs(__spawn_ycor - value) > 0.0000001) __spawn_ycor = value;
			}
		}
		private int __callsign_number
			 = 0;
		internal int callsign_number { 
			get { return __callsign_number; }
			set{
				if(__callsign_number != value) __callsign_number = value;
			}
		}
		private bool __frequency_blocked
			 = false;
		internal bool frequency_blocked { 
			get { return __frequency_blocked; }
			set{
				if(__frequency_blocked != value) __frequency_blocked = value;
			}
		}
		private string __sender_identifier
			 = "";
		internal string sender_identifier { 
			get { return __sender_identifier; }
			set{
				if(__sender_identifier != value) __sender_identifier = value;
			}
		}
		private string __receiver
			 = "";
		internal string receiver { 
			get { return __receiver; }
			set{
				if(__receiver != value) __receiver = value;
			}
		}
		private string __message_type
			 = "";
		internal string message_type { 
			get { return __message_type; }
			set{
				if(__message_type != value) __message_type = value;
			}
		}
		private Mars.Components.Common.MarsList<System.Tuple<double,double>> __message_information_path
			 = default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);
		internal Mars.Components.Common.MarsList<System.Tuple<double,double>> message_information_path { 
			get { return __message_information_path; }
			set{
				if(__message_information_path != value) __message_information_path = value;
			}
		}
		private int __message_information_heading
			 = default(int);
		internal int message_information_heading { 
			get { return __message_information_heading; }
			set{
				if(__message_information_heading != value) __message_information_heading = value;
			}
		}
		private bool __message_information_bool
			 = default(bool);
		internal bool message_information_bool { 
			get { return __message_information_bool; }
			set{
				if(__message_information_bool != value) __message_information_bool = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Weather__wind_bearing() 
		{
			{
			return Weather__wind_bearing
					;
			}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Weather__wind_speed() 
		{
			{
			return Weather__wind_speed
					;
			}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_Weather__density(double height) 
		{
			{
			double Weather__density = default(double);;
			Weather__density = density_zero * Mars.Components.Common.Math.Pow((1 - (L_constant * height / temperature_zero)), 4.2561);
			return Weather__density
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_gravity() 
		{
			{
			return gravity
					;
			}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual int Get_callsign_number() 
		{
			{
			callsign_number = callsign_number + 1;
			return callsign_number
			;}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Update_spawn_coord() 
		{
			{
			spawn_xcor = spawn_xcor + _Random.Next(5)
			 - 4;
			spawn_ycor = spawn_ycor + _Random.Next(5)
			 - 4
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_spawn_x_coord() 
		{
			{
			return spawn_xcor
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Get_spawn_y_coord() 
		{
			{
			return spawn_ycor
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual string Listen_receiver_on_frequency() 
		{
			{
			return receiver
					;
			}
			return default(string);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual string Listen_sender_identifier_on_frequency() 
		{
			{
			return sender_identifier
					;
			}
			return default(string);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual string Listen_message_type_on_frequency() 
		{
			{
			return message_type
					;
			}
			return default(string);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual Mars.Components.Common.MarsList<System.Tuple<double,double>> Listen_message_information_path_on_frequency() 
		{
			{
			return message_information_path
					;
			}
			return default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual int Listen_message_information_heading() 
		{
			{
			return message_information_heading
					;
			}
			return default(int);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Listen_message_information_bool() 
		{
			{
			return message_information_bool
					;
			}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Communicate_answer_on_frequency(string _sender_identifier, string _receiver, string _message_type, Mars.Components.Common.MarsList<System.Tuple<double,double>> _message_information_path, int _message_information_heading, bool _message_information_bool) 
		{
			{
			if(Equals(frequency_blocked, false) || Equals(_sender_identifier, "Tower")) {
							{
							sender_identifier = _sender_identifier;
							receiver = _receiver;
							message_type = _message_type;
							message_information_path = _message_information_path;
							message_information_heading = _message_information_heading;
							message_information_bool = _message_information_bool;
							frequency_blocked = true
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Communicate_request_on_frequency(string _sender_identifier, string _receiver, string _message_type) 
		{
			{
			if(Equals(frequency_blocked, false)) {
							{
							sender_identifier = _sender_identifier;
							receiver = _receiver;
							message_type = _message_type;
							frequency_blocked = true
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Clear_frequency() 
		{
			{
			frequency_blocked = false;
			sender_identifier = "";
			receiver = "";
			message_type = "";
			message_information_path = (new Mars.Components.Common.MarsList<System.Tuple<double,double>>() { new System.Tuple<double,double>(0.0,0.0) })
			;}
			return;
		}
		public AgentLayer (
		AirportStadeLayer _airportstadelayer, 
		double? minLon = null, double? minLat = null,
		double? maxLon = null, double? maxLat = null,
		int? cellSizeMeters = null
		) {
			this._AirportStadeLayer = _airportstadelayer;
			_minLon = minLon ?? 0;
			_minLat = minLat ?? 0;
			_maxLon = maxLon ?? 1;
			_maxLat = maxLat ?? 1;
			_cellSizeMeters = cellSizeMeters;
			_isDefault = (minLon == null && minLat == null && maxLon == null && maxLat == null);
			_lowerLeft = Mars.Interfaces.Environment.Position.CreateGeoPosition(_minLon, _minLat);
			_upperRight = Mars.Interfaces.Environment.Position.CreateGeoPosition(_maxLon, _maxLat);
			_upperLeft = Mars.Interfaces.Environment.Position.CreateGeoPosition(_minLon, _maxLat);
			_lowerRight = Mars.Interfaces.Environment.Position.CreateGeoPosition(_maxLon, _minLat);
		}
		
		public override bool InitLayer(
			Mars.Interfaces.Layer.Initialization.TInitData initData, 
			Mars.Interfaces.Layer.RegisterAgent regHandle, 
			Mars.Interfaces.Layer.UnregisterAgent unregHandle)
		{
			base.InitLayer(initData, regHandle, unregHandle);
			this._Register = regHandle;
			this._Unregister = unregHandle;
			
			_DistanceMetric = Mars.Mathematics.SpaceDistanceMetric.Chebyshev;
			var _gisLayerExist = true;
			if (!_isDefault && _lowerLeft != null && _upperRight != null) {
				this._AirTrafficControllerEnvironment = Mars.Components.Environments.GeoHashEnvironment<AirTrafficController>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._AircraftEnvironment = Mars.Components.Environments.GeoHashEnvironment<Aircraft>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._ObserverEnvironment = Mars.Components.Environments.GeoHashEnvironment<Observer>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._PilotEnvironment = Mars.Components.Environments.GeoHashEnvironment<Pilot>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
			} else if (_gisLayerExist)
			{
				var geometries = new List<GeoAPI.Geometries.IGeometry>();
				var _factory = new NetTopologySuite.Utilities.GeometricShapeFactory();
				geometries.AddRange(this._AirportStadeLayer.GeometryCollection.Geometries);
				var _feature = new NetTopologySuite.Geometries.GeometryCollection(geometries.ToArray()).EnvelopeInternal;
				_minLon = _feature.MinX;
				_minLat = _feature.MinY;
				_maxLon = _feature.MaxX;
				_maxLat = _feature.MaxY;
				
				this._AirTrafficControllerEnvironment = Mars.Components.Environments.GeoHashEnvironment<AirTrafficController>
					.BuildByBBox(_feature.MinX, _feature.MinY, _feature.MaxX, _feature.MaxY);
				this._AircraftEnvironment = Mars.Components.Environments.GeoHashEnvironment<Aircraft>
					.BuildByBBox(_feature.MinX, _feature.MinY, _feature.MaxX, _feature.MaxY);
				this._ObserverEnvironment = Mars.Components.Environments.GeoHashEnvironment<Observer>
					.BuildByBBox(_feature.MinX, _feature.MinY, _feature.MaxX, _feature.MaxY);
				this._PilotEnvironment = Mars.Components.Environments.GeoHashEnvironment<Pilot>
					.BuildByBBox(_feature.MinX, _feature.MinY, _feature.MaxX, _feature.MaxY);
			} 
			else if (_lowerLeft != null && _upperRight != null) {
				this._AirTrafficControllerEnvironment = Mars.Components.Environments.GeoHashEnvironment<AirTrafficController>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._AircraftEnvironment = Mars.Components.Environments.GeoHashEnvironment<Aircraft>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._ObserverEnvironment = Mars.Components.Environments.GeoHashEnvironment<Observer>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._PilotEnvironment = Mars.Components.Environments.GeoHashEnvironment<Pilot>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
			} else {
				throw new ArgumentException("No environment boundary was used for agent layer 'TestLayer'");
			}
			
			_AirTrafficControllerAgents = Mars.Components.Services.AgentManager.SpawnAgents<AirTrafficController>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(AirTrafficController)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this, this._AirportStadeLayer });
			_AircraftAgents = Mars.Components.Services.AgentManager.SpawnAgents<Aircraft>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(Aircraft)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this, this._AirportStadeLayer });
			_ObserverAgents = Mars.Components.Services.AgentManager.SpawnAgents<Observer>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(Observer)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this, this._AirportStadeLayer });
			_PilotAgents = Mars.Components.Services.AgentManager.SpawnAgents<Pilot>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(Pilot)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this, this._AirportStadeLayer });
			
			return true;
		}
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public cessna_digital_twin.AirTrafficController _SpawnAirTrafficController(double xcor = 0, double ycor = 0, int freq = 1) {
			var id = System.Guid.NewGuid();
			var agent = new cessna_digital_twin.AirTrafficController(id, this, _Register, _Unregister,
			_AirTrafficControllerEnvironment,
			_AirportStadeLayer
		, 	xcor, ycor, freq);
			_AirTrafficControllerAgents.Add(id, agent);
			return agent;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public cessna_digital_twin.Aircraft _SpawnAircraft(double xcor = 0, double ycor = 0, int freq = 1) {
			var id = System.Guid.NewGuid();
			var agent = new cessna_digital_twin.Aircraft(id, this, _Register, _Unregister,
			_AircraftEnvironment,
			_AirportStadeLayer
		, 	xcor, ycor, freq);
			_AircraftAgents.Add(id, agent);
			return agent;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public cessna_digital_twin.Observer _SpawnObserver(double xcor = 0, double ycor = 0, int freq = 1) {
			var id = System.Guid.NewGuid();
			var agent = new cessna_digital_twin.Observer(id, this, _Register, _Unregister,
			_ObserverEnvironment,
			_AirportStadeLayer
		, 	xcor, ycor, freq);
			_ObserverAgents.Add(id, agent);
			return agent;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public cessna_digital_twin.Pilot _SpawnPilot(double xcor = 0, double ycor = 0, int freq = 1) {
			var id = System.Guid.NewGuid();
			var agent = new cessna_digital_twin.Pilot(id, this, _Register, _Unregister,
			_PilotEnvironment,
			_AirportStadeLayer
		, 	xcor, ycor, freq);
			_PilotAgents.Add(id, agent);
			return agent;
		}
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void _KillAirTrafficController(cessna_digital_twin.AirTrafficController target, int executionFrequency = 1)
		{
			target._isAlive = false;
			_AirTrafficControllerEnvironment.Remove(target);
			_Unregister(this, target, target._executionFrequency);
			_AirTrafficControllerAgents.Remove(target.ID);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void _KillAircraft(cessna_digital_twin.Aircraft target, int executionFrequency = 1)
		{
			target._isAlive = false;
			_AircraftEnvironment.Remove(target);
			_Unregister(this, target, target._executionFrequency);
			_AircraftAgents.Remove(target.ID);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void _KillObserver(cessna_digital_twin.Observer target, int executionFrequency = 1)
		{
			target._isAlive = false;
			_ObserverEnvironment.Remove(target);
			_Unregister(this, target, target._executionFrequency);
			_ObserverAgents.Remove(target.ID);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void _KillPilot(cessna_digital_twin.Pilot target, int executionFrequency = 1)
		{
			target._isAlive = false;
			_PilotEnvironment.Remove(target);
			_Unregister(this, target, target._executionFrequency);
			_PilotAgents.Remove(target.ID);
		}
	}
}
