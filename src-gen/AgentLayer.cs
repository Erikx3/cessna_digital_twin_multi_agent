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
		
		public Mars.Components.Environments.GeoHashEnvironment<Aircraft> _AircraftEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment { get; set; }
		public AirportStadeLayer _AirportStadeLayer { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, Aircraft> _AircraftAgents { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, Pilot> _PilotAgents { get; set; }
		
		public AgentLayer _AgentLayer => this;
		public AgentLayer agentlayer => this;
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
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void update_spawn_coord() 
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
		public double get_spawn_x_coord() 
		{
			{
			return spawn_xcor
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double get_spawn_y_coord() 
		{
			{
			return spawn_ycor
			;}
			return default(double);;
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
				this._AircraftEnvironment = Mars.Components.Environments.GeoHashEnvironment<Aircraft>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
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
				
				this._AircraftEnvironment = Mars.Components.Environments.GeoHashEnvironment<Aircraft>
					.BuildByBBox(_feature.MinX, _feature.MinY, _feature.MaxX, _feature.MaxY);
				this._PilotEnvironment = Mars.Components.Environments.GeoHashEnvironment<Pilot>
					.BuildByBBox(_feature.MinX, _feature.MinY, _feature.MaxX, _feature.MaxY);
			} 
			else if (_lowerLeft != null && _upperRight != null) {
				this._AircraftEnvironment = Mars.Components.Environments.GeoHashEnvironment<Aircraft>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
				this._PilotEnvironment = Mars.Components.Environments.GeoHashEnvironment<Pilot>.BuildByBBox(_lowerLeft.Longitude, _lowerLeft.Latitude, _upperRight.Longitude, _upperRight.Latitude);
			} else {
				throw new ArgumentException("No environment boundary was used for agent layer 'TestLayer'");
			}
			
			_AircraftAgents = Mars.Components.Services.AgentManager.SpawnAgents<Aircraft>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(Aircraft)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this, this._AirportStadeLayer });
			_PilotAgents = Mars.Components.Services.AgentManager.SpawnAgents<Pilot>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(Pilot)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this, this._AirportStadeLayer });
			
			return true;
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
		public void _KillAircraft(cessna_digital_twin.Aircraft target, int executionFrequency = 1)
		{
			target._isAlive = false;
			_AircraftEnvironment.Remove(target);
			_Unregister(this, target, target._executionFrequency);
			_AircraftAgents.Remove(target.ID);
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
