![Screenshot - 19_01_2025 , 00_22_44](https://github.com/user-attachments/assets/e5499f68-3444-4013-a127-614580bf5e1d)

### Purpose

Utility for editing save database of Aurora 4X game helping promote unassigned naval and ground forces commanders. Because current [game rules](http://aurora2.pentarch.org/index.php?topic=8495.msg104038#msg104038) allow avoid early retirement for high ranking officers, it is beneficial to keep all officers at high ranks periodically mass promoting them.

### Usage

Save and exit from Aurora, copy AuroraComPromoter.exe to game directory and start it. Program will try open Aurora DB and select playable race in last game. Choose ranks for naval and/or ground commanders (by default it is second highest rank), press Promote button, close program and start the game.

### Prerequisites

Same as for Aurora 4X v2.5.1: .NET Framework 4.0 and System.Data.SQLite 1.0.103.

### Database modifications

Utility updates only three fields for affected commanders in FCT_Commander table (RankID, GameTimePromoted and Seniority) and adds rows into FCT_CommanderHistory table. To avoid spam, utility doesn't add new messages into events log.
