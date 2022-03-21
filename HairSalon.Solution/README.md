# _Hair Salon Employee/Client tracker_

#### By _**Eric Crudup**_

#### _An application for managing a hair salon_

## Technologies Used

* _C#_
* _.NET_
* _ASP .NET MVC_
* _MSTest_
* _Markdown_
* _Razor_
* _Entity Framework Core (EF Core)_
* _MySQL_   
* _MySQL Workbench_
* _LINQ_

## Description

This is a program that will allow a hair salon owner to keep track of their employee stylists, as well as their customers. It assumes each customer belongs to a particular stylist. It allows the owner to add new stylists and customers and input data about each, such as stylist experience, or customer hair length. This was the 3rd C# weekly project in my programming bootcamp, and is intended to display the skills we learned this week with connecting our C# code to MySQL databases with EF Core, using CRUD to manage databases, an resume our use of ASP .NET MVC routing and LINQ querying. 


## Setup/Installation Requirements

* _clone git repository to a local machine using command_ ```$ git clone [repository-URL].git```
* _navigate to root folder of the project using terminal_

#### _Intalling Entity Framework Core (EF Core)_
* _navigate to program folder of the repo, the one that holds the your Program.cs file (named HairSalon in this repo) using the terminal_
* _Use these commands in your terminal inside the program folder directory:_  
``` 
  $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0   
  $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2   
```

#### _Installing and setting up your database_
* _Follow instructions [HERE](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to install MySQL, & MySQL Workbench_   
* _Open MySQL Workbench on your machine and access Local instance 3306 under MySQL Connections_
* _Look for a "MySQL Connections" box, click on the one that says "localhost: 3306"_
* _On the left-hand side there should be a window called "Navigator", at the bottom of Navigator click on the "Administration Tab"_
* _Choose "Data Import/Restore", which we'll use for importing a database_
* _Choose "Import from Self-Contained File" and find the sql file named "eric\_crudup.sql" located at the root level of my repo that you cloned_
* _Choose "Start Import" on the bottom right of the Data Import window that you're in_ 
* (If you don't see the "Start Import" button, try making MySQL Workbench full screen)
  

#### _Creating an appsettings.json file:_

  The appsettings.json file will contain personal credentials for your MySQL server, as such, you cannot use my appsettings.json file, and will have to create your own. I'm very sorry, but I will give you instructions to help you on your path:

* _Navigate to program folder of the repo, the one that holds the your Program.cs file (named HairSalon in this repo) using the command line_
* _Create the appsettings file using the command:_ 
```
$ touch appsettings.json 
```  
* _(you may also be able to create the same file using the GUI file explorer in your OS or within your code editor)_
* _add the following code to the appsettings.json file:_ 
```  
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=[USER ID];pwd=[PASSWORD];"
    }
  }
```
* _replace "[PASSWORD]" and "[USER ID]" with the password and user id you chose during the MySQL installation process_


#### _To Run Program_
* _navigate to program folder of the repo, the one that holds the your Program.cs file (named HairSalon in this repo) using the terminal_
* _type in ```$ dotnet build``` command_
* _type in ```$ dotnet run``` command_
* _type in http://localhost:5000 into browser's address bar to use the app_
* _get awesome_

## Known Bugs and issues

* _No known bugs_

## License

[MIT](https://opensource.org/licenses/MIT)    
If you have any issues or questions, contact me at Cruduper@users.noreply.github.com  

Copyright (c) _2022_  _Eric Crudup_