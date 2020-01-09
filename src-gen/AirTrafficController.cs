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
		private int __runway_heading_calculated
			 = default(int);
		public int runway_heading_calculated { 
			get { return __runway_heading_calculated; }
			set{
				if(__runway_heading_calculated != value) __runway_heading_calculated = value;
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
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_general_values() 
		{
			{
			identifier = "Tower";
			state = "Listen_on_frequency"
			;}
			return;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public cessna_digital_twin.AgentLayer _Layer_ => _AgentLayer;
		public cessna_digital_twin.AgentLayer _AgentLayer { get; set; }
		public cessna_digital_twin.AgentLayer agentlayer => _AgentLayer;
		public cessna_digital_twin.AirportStadeLayer _AirportStadeLayer { get; set; }
		public cessna_digital_twin.AirportStadeLayer airportstadelayer => _AirportStadeLayer;
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public AirTrafficController (
		System.Guid _id,
		cessna_digital_twin.AgentLayer _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.GeoHashEnvironment<AirTrafficController> _AirTrafficControllerEnvironment,
		cessna_digital_twin.AirportStadeLayer _AirportStadeLayer
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_AgentLayer = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this._AirportStadeLayer = _AirportStadeLayer;
			_AgentLayer._AirTrafficControllerEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			initialize_general_values();
			double x_spawn = agentlayer.Get_spawn_x_coord();
			double y_spawn = agentlayer.Get_spawn_y_coord();
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget1694_49846 = new System.Tuple<double,double>(x_spawn,y_spawn);
				
				var _object1694_49846 = this;
				
				_AgentLayer._AirTrafficControllerEnvironment.PosAt(_object1694_49846, 
					_taget1694_49846.Item1, _taget1694_49846.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke()
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
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
															agentlayer.Clear_frequency();
															runway_heading_calculated = 107;
															if(Equals(message_type_received, "RequestTakeOffPreparationPoint")) {
																			{
																			taxipath = airportstade.Get_taxipath_to_TakeOffPreparationPoint(runway_heading_calculated);
																			agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerTakeOffPreparationPoint",taxipath,runway_heading_calculated);
																			state = "Listen_on_frequency"
																			;}
																	;} else {
																			if(Equals(message_type_received, "RequestTakeOffHoldShortPoint")) {
																							{
																							taxipath = airportstade.Get_taxipath_to_RunwayHoldShortPoint(runway_heading_calculated);
																							agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerTakeOffHoldShortPoint",taxipath,runway_heading_calculated);
																							state = "Listen_on_frequency"
																							;}
																					;} else {
																							if(Equals(message_type_received, "RequestTakeOff")) {
																											{
																											taxipath = airportstade.Get_taxipath_to_RunwayLineUpPoint(runway_heading_calculated);
																											agentlayer.Communicate_answer_on_frequency(identifier,callsign_received,"AnswerTakeOff",taxipath,runway_heading_calculated);
																											state = "Listen_on_frequency"
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
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(AirTrafficController other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
