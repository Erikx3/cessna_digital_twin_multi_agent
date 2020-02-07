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
		private double __action_run_time
			 = 0;
		internal double action_run_time { 
			get { return __action_run_time; }
			set{
				if(System.Math.Abs(__action_run_time - value) > 0.0000001) __action_run_time = value;
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
		private double __action_duration
			 = default(double);
		internal double action_duration { 
			get { return __action_duration; }
			set{
				if(System.Math.Abs(__action_duration - value) > 0.0000001) __action_duration = value;
			}
		}
		private double __pilot_age
			 = default(double);
		internal double pilot_age { 
			get { return __pilot_age; }
			set{
				if(System.Math.Abs(__pilot_age - value) > 0.0000001) __pilot_age = value;
			}
		}
		private double __pilot_flight_experience
			 = default(double);
		internal double pilot_flight_experience { 
			get { return __pilot_flight_experience; }
			set{
				if(System.Math.Abs(__pilot_flight_experience - value) > 0.0000001) __pilot_flight_experience = value;
			}
		}
		private double __pilot_flight_experience_max
			 = default(double);
		internal double pilot_flight_experience_max { 
			get { return __pilot_flight_experience_max; }
			set{
				if(System.Math.Abs(__pilot_flight_experience_max - value) > 0.0000001) __pilot_flight_experience_max = value;
			}
		}
		private double __pilot_age_max
			 = default(double);
		internal double pilot_age_max { 
			get { return __pilot_age_max; }
			set{
				if(System.Math.Abs(__pilot_age_max - value) > 0.0000001) __pilot_age_max = value;
			}
		}
		private double __pilot_age_min
			 = default(double);
		internal double pilot_age_min { 
			get { return __pilot_age_min; }
			set{
				if(System.Math.Abs(__pilot_age_min - value) > 0.0000001) __pilot_age_min = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void initialize_variables(double p_age, double p_exp, double p_exp_max, double p_age_max, double p_age_min) 
		{
			{
			pilot_age = p_age;
			pilot_flight_experience = p_exp;
			pilot_flight_experience_max = p_exp_max;
			pilot_age_max = p_age_max;
			pilot_age_min = p_age_min
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool hold_action_time(double time_needed) 
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
		public virtual void reset_action_timer() 
		{
			{
			action_run_time = 0
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void set_action_duration_time_bool(bool bo) 
		{
			{
			action_duration_time_set = bo
					;
			}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void create_action_duration(double action_duration_base, double action_duration_extra, string mode) 
		{
			{
			if(Equals(action_duration_time_set, false)) {
							{
							action_duration_time_set = true;
							if(Equals(mode, "pilot_age_and_experience")) {
											{
											double action_duration_extra_calc = action_duration_extra * (1 + (pilot_age / pilot_age_max) - (pilot_flight_experience / pilot_flight_experience_max));
											action_duration = action_duration_base + Mars.Mathematics.Statistics.RandomHelper.NextDouble(_Random, 0, action_duration_extra_calc)
											;}
									;} else {
											{
											action_duration = action_duration_base + Mars.Mathematics.Statistics.RandomHelper.NextDouble(_Random, 0, action_duration_extra)
											;}
										;}
							;}
					;} 
			;}
			return;
		}
	}
}
