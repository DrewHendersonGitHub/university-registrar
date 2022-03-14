# _README Template_

#### By Ryan Ashby, Drew Henderson Zachary Green

#### _Brief Discription. This project was possible under the guidance of Epicodus https://www.epicodus.com/_

## Technologies Used

* `C#`
* `ASP.NET Core MVC`
* `Microsoft Entity Framework`
* `Bootstrap`
* `CSS`

## Description

_Deeper description_

## Setup/Installation Requirements

* Visit https://github.com/
* Clone this repository to your desktop.
* Navigate to the top level directory in your terminal.
* Run "$ `touch appsettings.json`"
* Run "$ `code .`" to open the project in VS Code. If you do not have VS Code please visit their website: https://code.visualstudio.com/
* Add in this code:
  `{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }`
* Change the password to be the same password as your mySQL Server Password. If you do not have mySQL server please visit their website: https://www.mysql.com/
* Run "$ `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`"
* Run "$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`"
* Run "$ `dotnet restore`" to restore the bin and obj folders.
* Run "$ `dotnet build`" to build the project.
* Run "$ `dotnet run`" or "$ `dotnet watch run`" to launch a LocalHost. Click on LocalHost:5000. You may have to hold Ctrl or Command when clicking it to get it to open in your internet broswer.

* Developer Note -- <em>You do not need to type in $ into the terminal, the terminal starts with $ on GitBash and % on Bash.</em>

## Known Bugs

* No known bugs at this time.

## License

MIT

Copyright © 2022 Drew Henderson, Ryan Ashby, Zachary Green