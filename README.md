# _Eau Claire's Salon_

#### By _**Oscar Gonzalez**_

#### _This is an app that lets you create a stylist list, view said stylist list, add clients to each stylist in the list, and see a list of clients for each stylist._

## Technologies Used

* _C#_
* _.NET6_
* _HTML_
* _CSS_
* _Razor Markup_
* _MySQLWorkbench_
* _SQL Database_
* _AspNetCore_
* _Linq_
* _EntityFrameworkCore_



## Description

_This is my tenth project for Epicodus that is meant to show off my understanding of basic web applications with a database whilst utilizing C#. Here is a [link](https://github.com/OLGON92/HairSalon.Solution) to the repository on GitHub._

## Setup/Installation Requirements
* _Follow the steps below_

#### Installing .NET & MySQL
* _First, you will need to install .NET 6 if it isn't already on your machine_
* _Here is a link where you can download for your Mac, Windows, or Linux based machince: [link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)_
* _Look in your downloads and open the file_
* _Follow the installation intructions_
* _To confirm the the installation was a success: on your command line in your terminal type "dotnet --version"_
* _Then you will need to install MySQL. Follow the instructions in here[link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to do so._

#### Configuring appsettings.json
* _Clone the repository using this link: [link](https://github.com/OLGON92/HairSalon.Solution)_
* _Navigate to the 'HairSalon.Solution' directory on your computer_
* _Open it with your favorite text editor (Visual Studio Code is one I highly reccomend)_
* _From here you will go to the "HairSalon" Directory_
* _Create a new file called "appsettings.json_
* _In the appsettings.json file you will add the following code below_
* _*Please note that your username and password is dependent on what you have set up in your MySQLWorkbench.*_
* _*Also, do not include the brackets []*_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=oscar_gonzalez;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

#### Importing The Database
* _Open MySQLWorkbench, and click on the "Local instance 3306" box_
* _From here you will click on the "Administration" tab on the left_
* _Click on the "Data Import/Restore" tab_
* _Click on the "Import from self-contained file" option, and click on the box with a dot on the inside that's located to the right of the "Import from self-contained file" bar_
* _Look for the "HairSalon.Solution" directory you downloaded earlier, and you should see and pick the "oscar_gonzalez.sql" file_
* _You will then click the "New..." box to the right of "Default Target Schema", enter the datbase name "oscar_gonzalez.sql," and click "ok"_
* _Finally, you will hit the "start import" button"
* _To see the database in MySQLWorkbench you can click the "Schemas" tab; if it does not appear then click the refresh button(the circling arrows) located to the right of the "Schemas" tab_


#### To start a development server and view the project in the browser follow the steps below:_
* _Navigate to 'HairSalon.Solution' in your command line_
* _From there navigate to 'HairSalon'_
* _Run the command "dotnet build"_
* _Then run the command "dotnet watch run"_
* _It should then open the development environment in your preferred web browser automatically_
* _If it does not open automatically, then open your preferred web browser, copy/paste this http://localhost:5000 into your web browser, and you should be able to use the app after that_


## Known Bugs

* _None to be found._


## License

_If you have any questions or concerns please contact me at ogon318@gmail.com
You are also welcome to make any contributions if you'd like_

* _MIT License

Copyright (c) 2022 Oscar Gonzalez

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE._