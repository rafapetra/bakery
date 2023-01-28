# Pierre's Bakery

### A program to catalog a bakery's treats and flavors. This project was created for a programming class.

## Authored by:
Rafael Petrachini<br>
January 2023
***
## Table of Contents
1. [Description](#description)
2. [Technologies Used](technologies-used)
3. [Setup Instructions](#setup-instructions)
4. [Known Bugs](#known-bugs)
5. [License Information](#license)

## Description
A program written and compiled in C# for a Bakery to store it's treats catalog, allowing the staff to combine many different pastries with different flavors. The Index displays every treat and flavor that has been added to catalog on as well as links to register and log in with an account. The user can can navigate to the Treats or Flavors pages in order to see that catalog, as well as create/edit/delete them as well. To perform CRUD actions the user must register an account and be logged in. 

## Technologies Used

- C#
- .NET
- Bootstrap
- Git
- Github
- Markdown
- MySQL Workbench
- Razor

***

## Setup Instructions

### Installation
1. Start by installing a version os .NET 6 that is compatible. A suitable version can be located [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
2. Proceed through the program's installation by following the prompts. Keep the default settings as they originally appear during the setup process.
3. In the command-line interface (such as Git Bash), install dotnet-script by executing the specified command 
```bash
$ dotnet tool install -g dotnet-script
```
4. Adjust your local environment to utilize this, further information can be located [here].(https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
5. Next, install MySQL, more detailed instructions on how to do so can be found [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql). 

### Repository Setup
1. Start by cloning this repository.
2. Open your command-line interface (such as Terminal or Git Bash) and go to the production directory for this project called "Bakery".
3. Inside the FactoryRepair folder, create a new file named appsettings.json
4. Open your text editor and locate the appsettings.json file
5. In the appsettings.json file, insert the following code:
```javascript
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurant_list;uid=[uid];pwd=[pwd];"
  }
}
```
6. Substitute [uid] and [pwd] with your SQL username and password respectively (not including the brackets)

### Importing the Database
1. Launch MySQL Workbench and locate the Navigator window (it should be on the left side when the screen is maximized).
2. Choose "Data Import/Restore", this will open the Data Import page.
3. Choose the option "Import from Self Contained File". Locate the top level of the directory of files you downloaded from this repository ("Bakery").
4. Inside "Bakery", pick the file named quin_asselin.sql.
5. Under "Default Schema to be Imported To", press the "New..." button, enter the database name (pierre.sql), and press "OK".
6. Press the "Start Import" button in the lower right corner of the Data Import Pane.
7. In the Navigator panel, select the "Schemas" tab. Click the "refresh" icon (two arrows arranged in a circle in the top right corner of the pane), and the database should appear."

### Execute the Program

1. Open the terminal and navigate to the production directory called Bakery.
2. Start the project in development mode with a watcher by running the command `dotnet watch run` in the command line.
Open the browser to https://localhost:5001. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: Redirecting to HTTPS and Issuing a Security Certificate."
3. Access the project by opening a browser to https://localhost:5001. If unable to access the website, it may be due to not having configured a .NET developer security certificate for HTTPS. For further information on how to do this, refer to the lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs
N/A - please contact if any bugs are found.

## License
MIT

Copyright (c) [2023] [Rafael Petrachini]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

