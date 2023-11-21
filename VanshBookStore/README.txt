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
Made changes into css as first one was so bright , unable to find the words in it So used cosmo as a theme.

Starting Part 2 2023-11-06
1502
Made sure by testing and building the application that there are no errors and file is working perfectly.
Commented out in appsettings.json
20231106201020_AddDefaultIdentityMigration.cs Created the new migration file using the Nuget Console
Reviewed the SQL Server Object Explorer and made sure each file is created and made sure there are no errors, then tested the application
Added new class named category.cs to VanshBooks.Models and made changes into it
Added the migration using the PM console and updated the files 
deleted the AddCategoryToDb so as to resolve the duplication error and updated the database 
Created a new folder Repository  and in the same folder created IRepository for different interafces
Then added IRepository.cs into the Irepository folder and made changes into it
Then in main Repository folder created Repository.cs and made some quick fixes into it and modified the code using the codeprovided on blackboard
Created Categoryrepository.cs and ICategoryReposity.cs and made changes into the CategoryRepository
Made some changes at the top by using statements in ICategoryRepository.cs and then fixed the error in Category.cs by quick fixes available
Completed the remaining modifications in CategoryRepository.cs
Created ISP_Call.cs and made changes into the code  into IRepository folder
Added a new class SP_Call.cs in the Repository Folder and made changes into the code by quick fixes and added using statements at the top
Made the final changes in SP_Call.cs and now gonna add new interface IUnitOfWork to IRepository
Created the UnitOfWork and IunitOfWork interafce in the folder and made changes into the code 
Then to Make file accessible we need to register it in Startup.cs in the ConfigureServices method 
Finally completed the IUnitOfWork and UnitOfWork after some errors as I was missing letter I before UnitOfWork
Now added the MVC Controller- Empty inside Areas/Admin and named it as CategoryController.cs
Modified the code by using statements to use IUnitOfWork
Now added new folder in Areas/Views with the same name as Controllers, then add new Index view to the folder and modified using code from blackboard
Saved and tested the application
in _Layout.cshtml moved the Category link to Content Management Dropdown and made some changes into the code
Modified the Index.cshtml and added the icons of delete and update and then commented out those as it was not needed, it was just to review
Added the Javascript from blackboard into the wwwroot/js folder , also added @section call to category.js in Index.cshtml
Added the IAction result to the controller and added a View in CategoryController.ccs by clicking on Upsert and added
Created a partial view in Views>Shared folder named _CreateAndBackToListButton and added the asp-action into it, also created _EditAndBackToListButton
Modified the Upsert.cshtml using the @model statement and added the asp-action to Index.cshtml 
Added @section call to Scripts to validate input
Now created Upsert POST action method in the CategoryController.cs , added the void Save method to IUnitOfWork and removed and modified the code
Added the API call for DELETE in CategoryController.cs , implemented Delete method in category.js to add functionality and to call
Added the DELETE FUNCTION CODE from slides 
Code working perfect and pushed to github 

Errors I got 
getting error  Microsoft.Data.SqlClient.SqlException: 'Cannot open database "VanshBookStore" requested by the login. The login failed.
Login failed for user 'ACAD\W0827163'.'
fixed the error as i needed to update the database
NOW DELETE button doesn't work.
found and fixed the error :)
2049 done part 2-II

Starting Part 2 2023-11-20  1800
Created CoverType.cs in Model's folder same way created for Category.cs and made changes into the code for it to work.
Added ICoverTypeRepository interface in IRepository and CoverTypeRepository in Repository folder in VanshBooks.DataAccess 
after this used the DataAccess folder to add-migration and then updated the database 
first was getting the errors, forgot to implement the using statements 
Working fine now with zero errors 
Opened the _Layout.cshtml in Views/Shared directory and added the link for nav-bar
Created CoverTypeController.cs in the VanshBookStore/Areas/Customers/Controllers folder and modified the code as done previously.
Was getting errors as it was throwing exception and then finally found the error as I didnt modify the code in UnitOfWork and then modified and working fine 
Added new class Product in the .Models project 
Made changes into the Product.cs and added some using statements for it to work
added reference to the new products piece to the databasse in the ApplicationDbContext.cs
Ran the add-migration and update command and below is the timestamp.....
20231121012150_addProductToDb.cs

Now added ProductRepository to Repository and made the changes into the code
then added IProductrepository interface and modified the code 
Added the Product to UnitOfWork and IUnitOfWork as initially was getting errors, made some changes and modified ... working fine now .
Done Part III- Section 1  2047

Starting Section-2 2050
Created ProductController.cs and modified the code and added some using statements in the code 
Created a ProductVM in the Models project and mofied the code 
Installed Microsoft.AspNetCore.Mvc.ViewFeatures packages for the errors and now working fine 
