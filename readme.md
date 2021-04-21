# Loki - Valheim Character Editor

This program allows editing the character files for the game Valheim (.fch)

It is currently in a very early pre-release state and therefore use only at your own risk. The game is also in pre-release so the combination means it is highly likely that things will break.

## Features

- Detects game characters for easy selection
- Edit character name
  - Auto updates 'crafted by' on items in inventory when saving
- Edit beard style
- Edit hair colour
- Edit hair style
- Edit skin colour
- Make skin glow like a God (experimental)
- Edit skill values
- Reorder skills
- Edit player statistics, e.g. kills, deaths etc.
- Use 'non standard' hair/beard styles
- Simple Inventory editor (WIP)
  - Delete items
  - Add new items from palette
  - Edit stack size
  - Repair damaged items
  - Upgrade / Downgrade items quality
  - Set / Remove the 'crafted by' tag
- Backup System
  - Automatic backup created before changes are saved
  - Easy Backup Restore UI to fix mistakes

## Screenshots

![Screenshot of Loki editing character properties](Screenshots/loki-screenshot-1.png)
![Screenshot of a Deer Lord](Screenshots/loki-screenshot-4.png)
![Screenshot of inventory editor](Screenshots/loki-screenshot-inv.png)
![Screenshot of Loki editing character skills](Screenshots/loki-screenshot-2.png)
![Screenshot of Wuffles looking radioactive](Screenshots/loki-screenshot-3.png)

## Usage

> Note: Requires the .NET Core 3.1 runtime to be installed.
> Get it here if required: <https://dotnet.microsoft.com/download/dotnet/3.1/runtime>

No installer yet, so just simply unzip the application to any location you like & run the executable (Loki.exe).

## Backups

It's recommended to leave the backup option enabled.

Backups are created in `%LOCALAPPDATA%\TwoThreeSix\Loki\CharacterBackups`

## Coming Next

- World Data management (e.g. trim out bloat from old worlds)
- More tooltips & in app help
- Installer
- Detect game running and warn user (game could save over file at any point)
- Dark theme to protect sensitive gamer eyes
- New application icon
