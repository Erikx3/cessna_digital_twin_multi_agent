# Running Simulations Guide

In this appendix a guide on how to setup, run and analyze the simulation
results is presented.

## Setup

First of all it’s recommended to download the “MARS Handbook” (see )
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
defined here. Please refer to
[\[AppendixA\_Variable\_Overview\]](#AppendixA_Variable_Overview) for
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
value for the key “count” in listing
[\[listing\_configjson\_aircraft\_pilot\]](#listing_configjson_aircraft_pilot)
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
important variable descriptions can be found in section
[\[AppendixA\_Variable\_Overview\]](#AppendixA_Variable_Overview).
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
figure [\[figure\_kepler\_visualization\]](#figure_kepler_visualization)
follow these steps:
