2023-10-23 
1527 
Created a new ASP.Net MVC app using .Net5 SDK with Individual User Accound authorization 
Added a README.txt file  
Now creating a github repo 
Created successfully and then added the README.md file and gave it a bit discription. 
Tested the application to make sure if it works and it works fine as commented out the //"sslPort": 44304 from launchSettings.json 
Then heading onto Startup.cs and commented out line 35 options //options => options.SignIn.RequireConfirmedAccount = true 
In next step, opened the wwroot and then replaced and renamed the existing bootstap.css with the new one which I downloaded from bootswatch.com 
Then replaced the site.css(wwwroot folder) with the code provided on the boackboard 
After this go to Views-Shared-_Layout.cshtml and removed the .min from the line and changed the navbar-light to dark and bg-white to primary  
Now remove text-dark from the code and then added additional properties to footer 
In LoginPartial.cshtml removed the text-dark references  
Tested the application and it worked fine and made the changes 
Now adding the codes for stylesheets and scripts from the code provided on boackboad and added in the Layout.cshtml 
Then adding the dropdown menu in Views-Shared-Layout.cshtml from the website and then renamed the DropDown as Content Management  
Tested the application and viewed the changes and it has now the Content Management Dropdown 
In next step, 
Created 3 new projects named as: 
VanshBooks.DataAccess 
VanshBooks.Models 
VanshBooks.Utility 
Now Moved the whole Data folder to VanshBooks.DataAccess 
Now installed both the framework and packages version 5.0.17 
Then deleted the Migrations folder 
Now Installed the Identity Framework same version 
Then changed the namespace VanshBookStore.DataAccessor.Data , then deleted the C1 class from all of the projects made 
Now moved the Models folder into the VanshBooks.Models then modified the Views-Shared-Error.cshtml 
Now added the references of DataAccessor and Models to the Main solution which is VanshBookStore 
Then renamed Models folder to ViewModels nd made changes into ErrorViewModel 
Built the project and succeeded  
Now morified the Startup.cs and made some quick changes and removed some lines from the top which were not necessary into the code so as it can work fine  
Tested the application and Working just fine…. 
Now in the VanshBooks.Utility created a class named as SD.cs and modified its properties  
Then added the project references of 3 to main projecct . 
Further in DataAccess added the references of Models and Utility 
Then added Customer area to Areas and then made changes in Startup.cs  
Moved the HomeController.cs to Area folder into the controller nd then deleted the Models and Data folder 
Edited the HomeController.cs to define that Controller is in Customers Areas, then moved Views>Home nd then modified the HomeController namespace for it to work. 
Tested the application and working perfect till now… 
In next step copied the ViewImport and ViewStart to Area , then modified the ViewStart.cshtml to reflect its new path 
Tested the application and works fine 
Now added the new Admin Area in the Area , added the proper view filed and delted the Data and Models folder from that.  
Deleted the controllers folder  
Tested the application and works fine. 
Done Assignment 2-(I) 

Now started The project again as it was not showing all 4 projects as I made a mistake in starting that I checked the PLACE THE SOLUTION IN THE SAME FOLDER 
repeating all the steps and just changed the css as it was so bright and was not looking good as a theme.

Starting Part 2 2023-11-06
1502
Made sure by testing and building the application that there are no errors and file is working perfectly.
Commented out in appsettings.json
20231106201020_AddDefaultIdentityMigration.cs Created the new migration file using the Nuget Console
Reviewed the SQL Server Object Explorer and made sure each file is created and made sure there are no errors, then tested the application
Added new class named category.cs to VanshBooks.Models and made changes into it
Added the migration using the PM console and updated the files 
deleted the AddCategoryToDb so as to resolve the duplication error and updated the database 
