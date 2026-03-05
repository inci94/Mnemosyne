# Mnemosyne - Art History Database Project

My first SQL database creation project. It is a database management and connection application that lists the paintings in a fictional art gallery using a C# Console Application. 

## 🚀 Features
**C# & ADO.NET:** I used secure connection methods for database connection. **SQL Server:** Artworks, artists, and periods are stored relationally on SQL.
**Error Handling:** I managed database connection errors with `try-catch` blocks.

## 📂 Folder Structure
*`src/`: Contains the project's C# source code.
*`database/`: Contains the `.sql` script needed to set up the database on your own computer.

## 🛠️ Installation and Execution
1. Create the database by running the `.sql` file in the `database/` folder using SQL Server Management Studio (SSMS).
2. Open the `.sln` file in the `src/` folder with Visual Studio.
3. Update the `connectionString` section in `Program.cs` according to your SQL Server name.
4. Run the project.

## 🖼️ Display
When the program runs, it lists the work title, artist, and period information in the following format:
`Work Title - Artist (Period)`

See you in more comprehensive projects 🙋🏻‍♀️