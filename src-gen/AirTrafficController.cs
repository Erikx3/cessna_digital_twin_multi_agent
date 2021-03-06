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
	public class AirTrafficController : Mars.Interfaces.Agent.IMarsDslAgent {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(AirTrafficController));
		private readonly System.Random _Random = new System.Random();
		private string __identifier
			 = default(string);
		public string identifier { 
			get { return __identifier; }
			set{
				if(__identifier != value) __identifier = value;
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
		private string __message_type_received
			 = default(string);
		public string message_type_received { 
			get { return __message_type_received; }
			set{
				if(__message_type_received != value) __message_type_received = value;
			}
		}
		private string __callsign_received
			 = default(string);
		public string callsign_received { 
			get { return __callsign_received; }
			set{
				if(__callsign_received != value) __callsign_received = value;
			}
		}
		private double __runway_heading_calculated
			 = default(double);
		public double runway_heading_calculated { 
			get { return __runway_heading_calculated; }
			set{
				if(System.Math.Abs(__runway_heading_calculated - value) > 0.0000001) __runway_heading_calculated = value;
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
		private cessna_digital_twin.AirportStade __airportstade
			 = new cessna_digital_twin.AirportStade();
		internal cessna_digital_twin.AirportStade airportstade { 
			get { return __airportstade; }
			set{
				if(__airportstade != value) __airportstade = value;
			}
		}
		private Mars.Components.Common.MarsList<System.Tuple<double,double>> __taxipath
			 = default(Mars.Components.Common.MarsList<System.Tuple<double,double>>);
		internal Mars.Components.Common.MarsList<System.Tuple<double,double>> taxipath { 
			get { return __taxipath; }
			set{
				if(__taxipath != value) __taxipath = value;
			}
		}
		private bool __request_approval
			 = default(bool);
		internal bool request_approval { 
			get { return __request_approval; }
			set{
				if(__request_approval != value) __request_approval = value;
			}
		}
		private Mars.Components.Common.MarsList<double> __available_runway_heading
			 = default(Mars.Components.Common.MarsList<double>);
		internal Mars.Components.Common.MarsList<double> available_runway_heading { 
			get { return __available_runway_heading; }
			set{
				if(__available_runway_heading != value) __available_runway_heading = value;
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
		private cessna_digital_twin.Weather __weather
			 = default(cessna_digital_twin.Weather);
		internal cessna_digital_twin.Weather weather { 
			get { return __weather; }
			set{
				if(__weather != value) __weather = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_general_values() 
		{
			{
			identifier = "Tower";
			state = "Listen_on_frequency";
			callsign_received = "None";
			message_type_received = "None"
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void reset_general_values() 
		{
			{
			state = "Listen_on_frequency";
			callsign_received = "None";
			message_type_received = "None"
			;}
			return;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public Mars.Components.Environments.GeoHashEnvironment<Pilot> _PilotEnvironment { get; set; }
		public Mars.Components.Environments.GeoHashEnvironment<Weather> _WeatherEnvironment { get; set; }
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public AirTrafficController (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<AirTrafficController> _AirTrafficControllerEnvironment,
		double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			_AgentLayer._AirTrafficControllerEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			initialize_general_values();
			double x_spawn = 9.501334;
			double y_spawn = 53.559712;
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget2837_88873 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object2837_88873 = this;
				
				_AgentLayer._AirTrafficControllerEnvironment.PosAt(_object2837_88873, 
					_taget2837_88873.Item1, _taget2837_88873.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			request_approval = false;
			available_runway_heading = airportstade.Get_available_runway_heading_list()
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			weather = new Func<cessna_digital_twin.Weather>(() => {
				Func<cessna_digital_twin.Weather, bool> _predicate2844_89045 = null;
				Func<cessna_digital_twin.Weather, bool> _predicateMod2844_89045 = new Func<cessna_digital_twin.Weather, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate2844_89045 != null)
					{
						return _predicate2844_89045.Invoke(_it);
					} else return true;
				});
				
				const int _range2844_89045 = -1;
				var _source2844_89045 = this.Position;
				
				return _AgentLayer._WeatherEnvironment.Explore(_source2844_89045, _range2844_89045, 1, _predicateMod2844_89045)?.FirstOrDefault();
			}).Invoke();
			if(Equals(state, "Listen_on_frequency")) {
							{
							timehandler.create_action_duration(2,2,"None");
							if(timehandler.hold_action_time(timehandler.action_duration)
							) {
											{
											string temp_receiver = agentlayer.Listen_receiver_on_frequency();
											if(Equals(temp_receiver, identifier)) {
															{
															state = "Communicate_on_frequency";
															message_type_received = agentlayer.Listen_message_type_on_frequency();
															callsign_received = agentlayer.Listen_sender_identifier_on_frequency()
															;}
													;} 
											;}
									;} 
							;}
					;} else {
							if(Equals(state, "Communicate_on_frequency")) {
											{
											timehandler.create_action_duration(2,2,"None");
											if(timehandler.hold_action_time(timehandler.action_duration)
											) {
															{
															double wind_bearing = weather.Get_wind_bearing();
															runway_heading_calculated = formula.calculate_runway_heading(available_runway_heading,wind_bearing);
															if(Equals(message_type_received, "RequestTakeOffPreparationPoint")) {
																			{
																			taxipath = airportstade.Get_taxipath_to_TakeOffPreparationPoint(runway_heading_calculated);
																			agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerTakeOffPreparationPoint",taxipath,runway_heading_calculated,request_approval)
																			;}
																	;} else {
																			if(Equals(message_type_received, "RequestTakeOffHoldShortPoint")) {
																							{
																							taxipath = airportstade.Get_taxipath_to_RunwayHoldShortPoint(runway_heading_calculated);
																							agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerTakeOffHoldShortPoint",taxipath,runway_heading_calculated,request_approval)
																							;}
																					;} else {
																							if(Equals(message_type_received, "RequestTakeOff")) {
																											{
																											taxipath = airportstade.Get_taxipath_to_RunwayLineUpPoint(runway_heading_calculated);
																											cessna_digital_twin.Pilot[] pilot_array = new System.Func<cessna_digital_twin.Pilot[]>(() => {
																												
																												var _sourceMapped2884_90987 = this.Position;
																												var _source2884_90987 = _sourceMapped2884_90987;
																												var _range2884_90987 = -1;
																															
																												Func<cessna_digital_twin.Pilot, bool> _predicate2884_90987 = new Func<cessna_digital_twin.Pilot,bool>((cessna_digital_twin.Pilot x) => 
																												 {
																														{
																														return Equals(x.Get_state()
																														, "Landing") || Equals(x.Get_state()
																														, "TakeOff") || Equals(x.Get_state()
																														, "LandingRequest")
																														;}
																														;
																														return default(bool);;
																												});
																												Func<cessna_digital_twin.Pilot, bool> _predicateMod2884_90987 = new Func<cessna_digital_twin.Pilot, bool>(_it => 
																												{
																													if (_it?.ID == this.ID)
																													{
																														return false;
																													} else if (_predicate2884_90987 != null)
																													{
																														return _predicate2884_90987.Invoke(_it);
																													} else return true;
																												});
																												
																												return _AgentLayer._PilotEnvironment.Explore(_source2884_90987 , _range2884_90987, -1, _predicate2884_90987).ToArray();
																											}).Invoke();
																											if(pilot_array.Length >= 1) {
																															{
																															request_approval = false
																															;}
																													;} else {
																															{
																															request_approval = true
																															;}
																														;};
																											agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerTakeOff",taxipath,runway_heading_calculated,request_approval)
																											;}
																									;} else {
																											if(Equals(message_type_received, "RequestLanding")) {
																															{
																															taxipath = airportstade.Get_taxipath_to_ApronPoint(runway_heading_calculated);
																															cessna_digital_twin.Pilot[] pilot_array = new System.Func<cessna_digital_twin.Pilot[]>(() => {
																																
																																var _sourceMapped2898_91637 = this.Position;
																																var _source2898_91637 = _sourceMapped2898_91637;
																																var _range2898_91637 = -1;
																																			
																																Func<cessna_digital_twin.Pilot, bool> _predicate2898_91637 = new Func<cessna_digital_twin.Pilot,bool>((cessna_digital_twin.Pilot x) => 
																																 {
																																		{
																																		return Equals(x.Get_state()
																																		, "Landing") || Equals(x.Get_state()
																																		, "TakeOff")
																																		;}
																																		;
																																		return default(bool);;
																																});
																																Func<cessna_digital_twin.Pilot, bool> _predicateMod2898_91637 = new Func<cessna_digital_twin.Pilot, bool>(_it => 
																																{
																																	if (_it?.ID == this.ID)
																																	{
																																		return false;
																																	} else if (_predicate2898_91637 != null)
																																	{
																																		return _predicate2898_91637.Invoke(_it);
																																	} else return true;
																																});
																																
																																return _AgentLayer._PilotEnvironment.Explore(_source2898_91637 , _range2898_91637, -1, _predicate2898_91637).ToArray();
																															}).Invoke();
																															if(pilot_array.Length >= 1) {
																																			{
																																			request_approval = false
																																			;}
																																	;} else {
																																			{
																																			request_approval = true
																																			;}
																																		;};
																															agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerLanding",taxipath,runway_heading_calculated,request_approval)
																															;}
																													;} else {
																															if(Equals(message_type_received, "RequestLeavingAirpsace")) {
																																			{
																																			request_approval = true;
																																			agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerRequestAirspace",taxipath,runway_heading_calculated,request_approval)
																																			;}
																																	;} else {
																																			{
																																			agentlayer.Clear_frequency()
																																			;}
																																		;}
																														;}
																										;}
																						;}
																		;};
															reset_general_values()
															;}
													;} 
											;}
									;} 
						;}
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(AirTrafficController other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
