#### Bizz Whizz

#### By _**:neckbeard:Seth Medeiros**_

## Technologies Used

- _C#_
- _.NET 5_
- _Swagger_
- _MySQL_
- _Entity Framework Core_
- _Git_
- _VsCode_
- _Thunder Client Extension_

## Description:memo:

_An Application Programming Interface that gives the user to create a database of business types, names, and locations. Users can see a list of businesses in the database. Users also have update and delete functionality_

<details>
  <summary>Setup/installation Requirements:open_file_folder:</summary>
  
## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.
- [Download and install MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

### Installation

1. Clone the repository: `$ git clone https://github.com/Medeirosseth/BizzwhizzApi.Solution`
2. Navigate to the `BizzwhizzApi.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. To run the app:
   - Navigate to `MyProject.Solution/MyProject` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
   - Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet watch run` to run the project!
   - Note: `dotnet watch run` also restores and builds the project, so you can use this single command to start the server
5. **Appsettings:**
   - create a new file in the https://github.com/Medeirosseth/BizzwhizzApi.Solution directory named appsettings.json
   - add the following code to appsettings.json file:
     {
     "Logging": {
     "LogLevel": {
     "Default": "Warning"
     }
     },
     "AllowedHosts": "\*",
     "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Port=3306;database=NAMEOFDATABASEHERE;uid=root;pwd=PASSWORDHERE;"
     }
     }
   - Change NAMEOFDATABASEHERE to your desired name of database. Replace PASSWORDHERE with relevent MySQL password (set at installation of MySQL)
6. **Database**

   - Navigate to `https://github.com/Medeirosseth/BizzwhizzApi.Solution`
     using the MacOS Terminal or Windows Powershell (e.g. cd Dhttps://github.com/Medeirosseth/BizzwhizzApi.Solution)
   - Run the Command `dotnet ef database add migrations Initial` followed by `dotnet database update` to genereate the database through Entity FrameWork Core

7. **Launching the API**
_ Navigate to `https://github.com/Medeirosseth/BizzwhizzApi.Solution`
using the MacOS Terminal or Windows Powershell (e.g. cd Dhttps://github.com/Medeirosseth/BizzwhizzApi.Solution)
_ Run the command `dotnet watch run` to ch access in browser, thunder client, or postman
</details>
<details>
  <summary>**API Documentation** :open_file_folder:</summary>

Explore BizzWhizz API endpoints in Vscodes extension Thunder Client or browser.

## Using Swagger Documentation

to explore the BizzWhizz API with NSwag, launch the project using `dotnet watch run` with Terminal or PowerShell. The first page to appear will be: http://localhost:5000/swagger

**Endpoints**
GET - /api​/Businesses
POST - ​/api​/Businesses
GET - ​/api​/Businesses​/{id}
DELETE - /api​/Businesses​/{id}
PUT - /api​/Businesses​/id

**Sample JSON Response**
{
"businessId": 0,
"businessType": "string",
"businessName": "string",
"businessLocation": "string",
"rating": 0
}

</details>

## Known Bugs :no_entry_sign: :bug:

- _None known_

## License

<details>
  <summary>MIT</summary>
Copyright <2021> <Seth Medeiros>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
