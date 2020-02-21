# Running Simulations Guide

This is a guide on how to setup, run and analyze the simulation
results.

## Setup

First of all it’s recommended to download the “MARS Handbook”
from <https://mars-group.org/modeling-handbook/> for a full setup and
further reference. In this appendix it’s only described what is needed
to run the simulation program of this thesis without working on it.

1.  For running the simulation install Dotnet Core - SDK (Version
    2.2.402) from
    <https://dotnet.microsoft.com/download/dotnet-core/2.2>.

2.  For accessing this thesis simulation online go to
    <https://github.com/Erikx3/cessna_digital_twin_multi_agent> or
    <https://gitlab.informatik.haw-hamburg.de/mars/model-cessna-digital-twin>
    (access permission necessary) and clone / download the files to your
    local device.

3.  Optional: For visualizing the results with the provided jupyter
    notebook it’s recommended to install the anaconda distribution with
    Python 3.x from <https://www.anaconda.com/distribution/>. All
    necessary packages are included within the Anaconda distribution.

## Simulation Settings and Parameters

The option is provided to customize the simulation via external variable
input. Please read this section carefully when changing any parameters.

In the *src-gen* folder are the following three files:

  - *config.json* : Main config for global parameters, but also for
    weather and observer variables

  - *Aircraft<span>\_</span>variables.csv* : Config file for aircraft
    agents

  - *Pilot<span>\_</span>variables.csv* : Config file for pilot agents

The existing files are set up for a simulation and analysis with jupyter
notebook afterwards. For an analysis with kepler use the provided input
files in the folder
*config<span>\_</span>kepler<span>\_</span>simulation<span>\_</span>example*
and copy them into the *src-gen* folder.

Please note:

  - For input values and output results the decimal point is always in
    use

  - During this work were an existing small bug in the output format of
    the position results which lead to the workaround of changing
    delimiter between a comma (for kepler) and semicolon (for jupyter
    notebook)

### config.json

In the config.json following global parameters within the key “globals”
can be changed:

``` html
"globals": {
        "startTime": "2020-01-01T18:00:00.000Z",
        "endTime": "2020-01-01T18:15:00.000Z",
        "options": {
            "delimiter": ";"
        }
    }
```

With “startTime” and “endTime” it’s possible to vary the internal time
of the simulation. With the delimiter the output csv file format can be
adapted. Choose between a comma for kepler or a semicolon for jupyter notebook analysis later on.

Also the input variables for the weather and observer agent can be
defined here. Please refer to the tables at the end for
the variables definitions.

``` html
{
    "name":"Weather",
    "count":1,
    "mapping": [
        {
            "parameter" : "wind_bearing",
            "value" : 107.0
        },
        {
            "parameter" : "wind_speed",
            "value" : 5.0
        },
        (...)
    ]
},
```

For the following sections it’s already important to mention, that the
value for the key “count” in listing below
for the agent pilot and aircraft in the *config.json* should align with
the number of defined agents in the
*Aircraft<span>\_</span>variables.csv* and
*Pilot<span>\_</span>variables.csv* later.

``` html
"agents": [
    {
        "name":"Pilot",
        "count":2,
        "file" : "Pilot_variables.csv"
    },
    {
        "name":"Aircraft",
        "count":2,
        "file" : "Aircraft_variables.csv"
    },
    (...)
]    
```

## Pilot<span>\_</span>variables.csv and Aircraft<span>\_</span>variables.csv

Here you can change the input values for the pilot and the aircraft. All
important variable descriptions can be found in section in the tables later.
Nevertheless, here are some helpful comments:

  - Each row after the column row represents ONE agent

  - Make sure that the “callsign<span>\_</span>number” in each csv has a
    matching partner

  - Choose a reasonable high delta for
    “time<span>\_</span>initialization” between landing aircrafts

  - The number of agents defined in the csv files should match with the
    number defined in the *config.json* as mentioned earlier

  - Watch out for whitespaces and remove them

# Run and Analyze the Simulation

Now simply run the simulation with the *run.sh* shell script from the
*src-gen* folder. The output will be a *Aircraft.csv* and *Pilot.csv*
file. There are two ways to visualize the results.

## Kepler

FIGURE HERE

Visit <https://kepler.gl/> and upload for instance the *Aircraft.csv*.
To get a nice visualization over the internal simulation time as in
figure above
follow these steps:

1.  Go to the options for your “Points”, then open the options for “Fill
    Color” and select for “Color Based On” the column name
    “Aircraft<span>\_\_</span>callsign”

2.  Optional: Reduce Radius of each point and add a label

3.  Go to next tab and choose as a filter the column name “DateTime”,
    which is already in a format that kepler will provide you a time
    slider

4.  Optional: Upload the *AiportStade.geojson* file from the *src-gen*
    folder for visualizing the airport paths

Kepler offers even more possibilities for exploring the data, thus only
the basics are explained here.

## Jupyter Notebook

With the jupyter notebook script *Data Visualization.ipynb* each signal
for each aircraft will be plotted. Simply run the script with your
jupyter notebook environment. It’s recommended to have a maximum of two
to three agents for a good overview of each signal. This script allows a
in depth analysis of each action and offers a lot of help during
development.

# Variable Overview

The following four tables represent all variables that are able to be
customized within each agent. Please note that sometimes the defined
column “Value Range” are only reasonable values, which partially are
further discussed in this thesis. Also note that some variable names are
self explanatory.

| **Variable Name**          | **Type** | **Unit**    | **Value Range**                             | **Description**                                      |
| :------------------------- | :------- | :---------- | :------------------------------------------ | :--------------------------------------------------- |
| gravity                    | real     | m/s\(^{2}\) | <span>\[</span>9.81<span>\]</span>          | Gravitational constant                               |
| pressure<span>\_</span>QNH | real     | Pa          | <span>\[</span>95000; 105000<span>\]</span> | QNH, airport ambient pressure since elevation is 0 m |
| temperature                | real     | C\(^\circ\) | <span>\[</span>-10; 50<span>\]</span>       | Outside air temperature at airport                   |
| wind\_bearing              | real     | \(^\circ\)  | <span>\[</span>0; 360<span>\]</span>        | Bearing the wind is coming from.                     |
| wind\_speed                | real     | m/s         | <span>\[</span>0; 15<span>\]</span>         | \-                                                   |
|                            |          |             |                                             |                                                      |

Weather Agent external variables


| **Variable Name**             | **Type** | **Unit** | **Value Range**                        | **Description**                                                                                          |
| :---------------------------- | :------- | :------- | :------------------------------------- | :------------------------------------------------------------------------------------------------------- |
|                               |          |          |                                        |                                                                                                          |
| spawning<span>\_</span>points | integer  | \-       | <span>\[</span>1; 8<span>\]</span>     | Number of spawning points on the apron                                                                   |
| print<span>\_</span>interval  | integer  | s        | <span>\[</span>100, inf<span>\]</span> | Interval at which the observer prints an overview of the states of all pilots in the command line window |
|                               |          |          |                                        |                                                                                                          |

Observer Agent external variables


| Variable   Name                                    | Type    | Unit  | Value Range    | Description                                                                                                                                                           |
|----------------------------------------------------|---------|-------|----------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Aircraft__lift_coefficient_slope                   | real    | -     | [4.9]          | -                                                                                                                                                                     |
| Aircraft__mass                                     | real    | kg    | [550; 725]     | -                                                                                                                                                                     |
| Aircraft__oswald_factor                            | real    | -     | [0.7]          | -                                                                                                                                                                     |
| Aircraft__stall_angle                              | real    | °     | [11]           | -                                                                                                                                                                     |
| Aircraft__total_stall_angle                        | real    | °     | [15]           | Defines   the angle when complete flow separation occurs and no lift will be produced                                                                                 |
| Aircraft__wing_area                                | real    | m^2   | [15]           | -                                                                                                                                                                     |
| Aircraft__wing_span                                | real    | m     | [10.1]         | -                                                                                                                                                                     |
| Aircraft__zero_lift_angle                          | real    | °     | [-1.0]         | -                                                                                                                                                                     |
| Aircraft__zero_lift_drag_coefficient               | real    | -     | [0.04]         | Typical   value for small single engine aircraft, fixed gear                                                                                                          |
| Brake__deceleration_force_max                      | real    | N     | [2500;   3000] | Simplified   maximum brake force                                                                                                                                      |
| callsign_number                                    | integer | -     | [1;   inf]     | Callsign   number, that has to match a callsign number of the pilot variables table                                                                                   |
| Engine__failure_probability_add_oil_critical_min   | real    | -     | [0;   1]       | Probability   of an engine failure (per each tick!) due to engine oil below critical   minimum                                                                        |
| Engine__failure_probability_add_oil_min            | real    | -     | [0;   1]       | Probability   of an engine failure (per each tick!) due to enigne oil below minimum                                                                                   |
| Engine__failure_probability_add_oil_pump_condition | real    | -     | [0;   1]       | Probability   of an engine failure (per each tick!) due to faulty engine pump condition                                                                               |
| Engine__failure_probability_add_water_sediments    | real    | -     | [0;   1]       | Probability   of an engine failure (per each tick!) due to water sediments                                                                                            |
| Engine__fuel_consumption_max                       | real    | l/s   | [0.0079]       | Fuel   consumption for 100% throttle (corresponds to 7.5 gallon per hour)                                                                                             |
| Engine__oil_leakage_probability                    | real    | -     | [0;   1]       | Probability   of an engine oil leakage during initialization                                                                                                          |
| Engine__oil_pump_condition_probability             | real    | -     | [0;   1]       | Probability   of oil pump condition to be healthy during initialization                                                                                               |
| Engine__power_coefficient_constant                 | real    | -     | [0.05]         | -                                                                                                                                                                     |
| Engine__power_coefficient_slope                    | real    | -     | [-0.0009]      | -                                                                                                                                                                     |
| Engine__power_coefficient_speed_constant           | real    | m/s   | [30.0]         | Up   to which speed the "Engine__power_coefficient_constant" is constant                                                                                              |
| Engine__power_max                                  | integer | W     | [75000]        | -                                                                                                                                                                     |
| Engine__RPM_max                                    | integer | RPM   | [2750]         | Maximum   mechanical revolution per minute                                                                                                                            |
| LWT__total_capacity                                | integer | liter | [49]           | Light   wing fuel tank capacity                                                                                                                                       |
| LWT__water_sediments_probability                   | real    | -     | [0; 1]         | Probability   of existing water sediments in the left wing tank during initialization                                                                                 |
| n_cycle                                            | integer | -     | [1;   100]     | Defines   the number of calculation cycles between each tick for the numerical   calculation of the aircraft physics (low numbers might lead to unstable   behaviour) |
| Propeller__diameter                                | real    | m     | [1.75]         | -                                                                                                                                                                     |
| Propeller__thrust_coefficient_constant             | real    | -     | [0.1]          | -                                                                                                                                                                     |
| Propeller__thrust_coefficient_slope                | real    | -     | [-0.002]       | -                                                                                                                                                                     |
| Propeller__thrust_coefficient_speed_constant       | real    | m/s   | [25]           | Up   to which speed the "Propeller__thrust_coefficient_constant" is   constant                                                                                        |
| RWT__total_capacity                                | integer | liter | [49]           | Right   wing fuel tank capacity                                                                                                                                       |
| RWT__water_sediments_probability                   | real    | -     | [0; 1]         | Probability   of existing water sediments in the right wing tank during initialization                                                                                |
| Tire__roll_coefficient                             | real    | m     | [0.002]        | For   the calculation of the friction                                                                                                                                 |
| Tire__wheel_radius                                 | real    | m     | [0.075]        | Wheel   diameter with neglecting non equal size of nose and main wheels                                                                                               |

Aircraft Agent Variable Overview

| Variable   Name                                           | Type    | Unit | Value Range          | Description                                                                                                                                                                                              |
|-----------------------------------------------------------|---------|------|----------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| callsign_number                                           | integer | -    | [1; inf]             | Callsign   number, that has to match a callsign number of the aircraft variables table                                                                                                                   |
| Check_Engine__oil_skip_probability                        | real    | -    | [0;   1]             | -                                                                                                                                                                                                        |
| Check_Instrument_Engine__oil_pressure_skip_probability    | real    | -    | [0;   1]             | -                                                                                                                                                                                                        |
| Check_Instrument_Engine__oil_temperature_skip_probability | real    | -    | [0; 1]               | -                                                                                                                                                                                                        |
| Check_LWT__water_sediments_skip_probability               | real    | -    | [0;   1]             | -                                                                                                                                                                                                        |
| Check_RWT__water_sediments_skip_probability               | real    | -    | [0;   1]             | -                                                                                                                                                                                                        |
| Climb__pitch_magnitude                                    | real    | °    | [0,1;   1,5]         | Pitch   magnitude changes applied during climb state                                                                                                                                                     |
| Climb__rate_of_climb_lower_limit                          | real    | m/s  | [0;   3]             | Rate   of climb control during climb state                                                                                                                                                               |
| Climb__rate_of_climb_upper_limit                          | real    | m/s  | [1;   4]             | Rate   of climb control during climb state                                                                                                                                                               |
| Set_Engine__mixture_control_skip_probability              | real    | -    | [0;   1]             | -                                                                                                                                                                                                        |
| TakeOff__rotate_pitch                                     | integer | °    | [8;   14]            | Aircraft   pitch applied after rotating                                                                                                                                                                  |
| TakeOff__V_rotate                                         | real    | m/s  | [25;   35]           | Aircraft   TAS where pilot rotates aircraft during takeoff                                                                                                                                               |
| Taxiing__angle_of_vision                                  | real    | °    | [30;   90]           | Angle   of vision during taxi. Note: too high or too low values might lead to issues.                                                                                                                    |
| Taxiing__collision_crash_distance                         | real    | m    | [1;   3]             | Distance   threshold for crash detecion                                                                                                                                                                  |
| Taxiing__final_point_distance                             | integer | m    | [0;   20]            | Distance   to final point, when pilot applies brake                                                                                                                                                      |
| Taxiing__next_point_distance                              | integer | m    | [0;   20]            | Distance   threshold to next point on path, when switiching to next point after that one                                                                                                                 |
| Taxiing__spacing_to_next_aircraft                         | real    | m    | [20;   50]           | Distance   kept to next aircraft while taxiing.                                                                                                                                                          |
| Taxiing__speed                                            | real    | m/s  | [4;   8]             | Speed   during taxi. Note: too high speeds might lead to collisions and overshooting   points                                                                                                            |
| time_base_next_communication_attempt                      | integer | s    | [10;   inf]          | Base   time for waiting to make another attempt to communicate to tower after   getting no answer                                                                                                        |
| time_extra_next_communication_attempt                     | integer | s    | [10;   inf]          | Variabel   extra time for waiting to make another attempt to communicate to tower after   getting no answer                                                                                              |
| time_initialization                                       | integer | s    | [2;   inf]           | Defines   the starting time of the pilot AND its aircraft. Please do NOT use the same   time twice, since spawning might be unstable. Please choose a reasonable high   delta between landing aircrafts. |
| type_initialization                                       | string  | -    | [Landing,   Takeoff] | Defines   whether this pilot is going to be landing or starting from ground                                                                                                                              |

Pilot Agent Variable Overview
