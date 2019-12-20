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
	public class TimeHandler {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(TimeHandler));
		private readonly System.Random _Random = new System.Random();
		private int __action_run_time
			 = 0;
		internal int action_run_time { 
			get { return __action_run_time; }
			set{
				if(__action_run_time != value) __action_run_time = value;
			}
		}
		private bool __action_duration_time_set
			 = false;
		internal bool action_duration_time_set { 
			get { return __action_duration_time_set; }
			set{
				if(__action_duration_time_set != value) __action_duration_time_set = value;
			}
		}
		private int __action_duration
			 = default(int);
		internal int action_duration { 
			get { return __action_duration; }
			set{
				if(__action_duration != value) __action_duration = value;
			}
		}
		private int __pilot_age
			 = default(int);
		internal int pilot_age { 
			get { return __pilot_age; }
			set{
				if(__pilot_age != value) __pilot_age = value;
			}
		}
		private int __pilot_flight_experience
			 = default(int);
		internal int pilot_flight_experience { 
			get { return __pilot_flight_experience; }
			set{
				if(__pilot_flight_experience != value) __pilot_flight_experience = value;
			}
		}
		private int __pilot_age_max
			 = default(int);
		internal int pilot_age_max { 
			get { return __pilot_age_max; }
			set{
				if(__pilot_age_max != value) __pilot_age_max = value;
			}
		}
		private int __pilot_age_min
			 = default(int);
		internal int pilot_age_min { 
			get { return __pilot_age_min; }
			set{
				if(__pilot_age_min != value) __pilot_age_min = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void initialize_variables(int p_age, int p_exp, int p_age_max, int p_age_min) 
		{
			{
			pilot_age = p_age;
			pilot_flight_experience = p_exp;
			pilot_age_max = p_age_max;
			pilot_age_min = p_age_min
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool hold_action_time(int time_needed) 
		{
			{
			action_run_time = action_run_time + 1;
			if(action_run_time >= time_needed) {
							{
							reset_action_timer();
							action_duration_time_set = false;
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
		public void reset_action_timer() 
		{
			{
			action_run_time = 0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void create_action_duration(int action_duration_base, int action_duration_extra, string mode) 
		{
			{
			if(Equals(action_duration_time_set, false)) {
							{
							action_duration_time_set = true;
							if(Equals(mode, "age_and_experience")) {
											{
											int action_duration_extra_calc = action_duration_extra * (1 + (pilot_age / pilot_age_max) - pilot_flight_experience / (pilot_age_max - pilot_age_min));
											action_duration = action_duration_base + _Random.Next(action_duration_extra_calc)
											;}
									;} else {
											{
											action_duration = action_duration_base + _Random.Next(action_duration_extra)
											;}
										;}
							;}
					;} 
			;}
			return;
		}
	}
}
