//=================================================================
// Solution: BlazorUI
//=================================================================
// Programmer: Maurice Antonio Kelly
// Description: .NET Portfolio
// ASP.NET Core 5.0
// Date: 2021-06-25
// Stop: 12:00
//=================================================================

// BlazorUI BlazorShared | BlazorUI BlazorShared
// BUI

// Add UI components and classes from Lib_Blazor.
// Revert C# based side navigation that hase CSS transition for good UX. The JS version has similar functionality but I prefer C#.
// Update Admin pages to use CSS Grid
// Start using new theme and CSS Grid.

// Using NuGet package Lib_Core Version 0.0.0.8 | Temporary use of Lib_Blazor library; I will switch back to using Lib_Blazor from NuGet when I have completed the update.
// Todo: Remember to inject required services and Update...

// Using NuGet packages the shared libraries.




// Must Do: Set DeployedState.IsDeployed = true; Do this before deployment to ensure deployment settings.
// Done: JS & CSS Menu in Blazor (Blazor only Menu may cause server delays in the menu).

//==========================================================================
// App-Wide Methods & Properties S (2021-11-23)
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//
// public const bool IsDeployed = true;
// UrlHelper.GetImagePath()
//
//public const string Api_Image_Path = "https://localhost:5551/Images/UploadFiles";
//public const string Api_Image_Path_Deployed = "https://localhost:5551/Images/UploadFiles"; // Todo:
////https://achieveexcellentenglish.com/
////UrlApiImageParameter
//protected string UrlApiImage => AppState.IsDeployed ? UrlData.Api_Image_Path_Deployed : UrlData.Api_Image_Path;
//public string GetImagePath() => AppState.IsDeployed ? UrlData.Api_Image_Path_Deployed : UrlData.Api_Image_Path;
//
//
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// App-Wide Methods & Properties E
//==========================================================================

//==========================================================================
// Migrations S (2021-06-15)
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//
// DotNet CLI
// dotnet ef migrations add InitialMigration
// dotnet ef database update
//
// VS PMC
// ApplicationDbContext (Current App)
// Add-Migration ApplicationDbContext_Initial -Context ApplicationDbContext
// Update-Database -Context ApplicationDbContext
//
// ApplicationDbContext (Web_Api & Blazor_Server)
// Add-Migration ApplicationDbContext_Initial -Context ApplicationDbContext -OutputDir Database/Migrations/ApplicationDbContextMigrations
// Update-Database -Context ApplicationDbContext
//
//==========================================================================
//
// AeeDbContext (Web_Api & Blazor_Server)
// Add-Migration AeeDbContext_Initial -Context AeeDbContext -OutputDir AeeDomain/Migrations
// Update-Database -Context AeeDbContext
//
// ItemDbContext (Web_Api & Blazor_Server)
// Add-Migration ItemDbContext_Initial -Context ItemDbContext -OutputDir ItemDomain/Migrations
// Update-Database -Context ItemDbContext
//
// AppApiAuthorizationDbContext (Blazor_Wasm)
// Add-Migration AppApiAuthorizationDbContext_Initial -Context AppApiAuthorizationDbContext -OutputDir Database/Migrations/AppApiAuthorizationDbContextMigrations
// Update-Database -Context AppApiAuthorizationDbContext
//
// AuthDbContext (IS_AspNet_Identity)
// Add-Migration AuthDbContext_Initial -Context AuthDbContext -OutputDir Database/Migrations/AuthDbContextMigrations
// Update-Database -Context AuthDbContext
//
// Blazor_Server
// AppAuthDbContext
// AppAuthDbContext (Web_Api & Blazor_Server)
// Add-Migration AppAuthDbContext_Initial -Context AppAuthDbContext -OutputDir Database/Migrations
// Update-Database -Context AppAuthDbContext
//
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Migrations E
//==========================================================================


/*




//*/

