----- Date Started -----
2022-10-25 @ 10:30am
------------------------

- Created Project JustinsBookStore
- Commented out the "Identity" line in StartUp.cs
- Commented out SSL Port for school testing
- Created gitHub repo
- uploaded to the hub

----- Date Modified -----
2022-10-27 @ 10:30am
-------------------------

- chose bootswatch theme: Vapor
- added JavaScript files and other stylesheets (3rd party packages)
- addded drop down menu
- added 3 projects : - JustinsBooks.DataAccess
					 - JustinsBooks.Models
					 - JustinsBooks.Utility
----- Date Modified -----
2022-11-1 @ 10:30am
-------------------------
- Created Project References amongst these projects
- Ran into 2 errors without feedback
- Could not find the root of my error so I started the project over

----- Date Modified -----
2022-11-1 @ 10:30pm
-------------------------

- After getting to the same spot after closely following the tutorial I am still getting these errors
- I tried playing around with using statements in my Startup.cs file
	- Now My only error is in the ErrorViewModel
	- added this line to the top of Error.cshtml and now project builds without errors: @using JustinsBookStore.Models.ViewModels 
- Time to make a new gitHub repo

----- Date Modified -----
2022-11-2 @ 10:30am
-------------------------

- added class StaticDetails (SD.cs) to JustinsBooks.Utility project

----- Date Modified -----
2022-11-3 @ 7:02PM
------------------------- 

- updated the StaticDetails class to be both public and static
- I created a Customer area
--> ran into ERROR with the view
	--> The error was a routing error, I forgot to move the Home folder into Customer/Views folder
	--> After moving Home folder my project loaded properly

***********30 Minute Delay*************************
Reason: Had to break up fight between my cats
***************************************************

----- Time Modified -----
2022-11-3 @ 7:35PM
-------------------------

- created Admin area
---> I learned from my mistake last time so I made sure to move the _ViewImport.cshtml and _ViewStart.cshtml files into the Admin/Views folder


- Time for a build

---->SUCCESS!!

--> Upload to the hub

----- Time Modified -----
2022-11-7 @ 7:35PM
-------------------------

- build app to check for errors .... NO ERRORS LFG!!!

- started part 2 of assignment

- migration name: addCategoryToDb

- changed the name of the database to JustinsBookStore

- added a new field to DB (Category) by creating Category.cs in JustinsBooks.Models

- migrated the new field to DB and Updated Datase... NO ERRORS LFG!!!

----- Time Modified -----
2022-11-8 @ 9:25AM
-------------------------

- created Repository/IRepository/IRepository.cs in the JustinsBooks.DataAccess project
- made changes to my IRpository interface 
		-> added CRUD functionality
- added Repository.cs class to JustinsBooks.DataAccess/Repository
- added Category Repository and Category Interface Repositories
- pushed to HUB

----- Time Modified -----
2022-11-11 @ 10:25AM
-------------------------
- creating ISP_Call interface in IRepository
- creating SP_Call class in Repository
- creating IUnitOfWork interface in IRepository
- creating UnitOfWork class in Repository
- All Working Without bugs

----- Time Modified -----
2022-11-12 @ 10:25AM
-------------------------
- create Update Category Controller
- pushed to HUB


----- Time Modified -----
2022-11-13 @ 10:25AM
-------------------------
- Finished Slides ----->> database collects data, table doesnt show. DATA EXISTS BUT HOW TO ACCESS?? NO ERROR MESSAGE...run time error

----- Time Modified -----
2022-11-14 @ 7:45PM
-------------------------
Same problem WTF?!?!?!


----- Time Modified -----
2022-11-15 @ 4:45AM
-------------------------
FOUND ERROR LFG -----> category.js Line 14: "name" used to read as "Name"

Why doesnt delete work??
----> category.js Line 16: "id" was formerlly "Id"
- pushed to HUB									
- made buttons highlight when user hovers

----- Time Modified -----
2022-11-21 @ 3:15PM
-------------------------

-----------------------------
  Started Working on Part 3
-----------------------------

- added CoverType.cs to JustinsBooks.Models
- added CoverTypeRepository.cs to JustinsBooks.DataAccess/Repository
- added ICoverTypeRepository.cs to JustinsBooks.DataAccess/Repository/IRepository
- added CoverTypeRepository to UnitOfWork
- added ICoverTypeRepository to IUnitOfWork


- ADDED MIGRATION to JustinsBooks.DataAccess  -------------------------------------------------------> 20221121201738_addCoverTypeToDb
- updated database (JustinsBooks.DataAccess)


----- Time Modified -----
2022-11-21 @ 3:55PM
-------------------------
- created cover.js for the Covers table
- created CoverTypeController.cs in JustinsBookStore/Areas/Admin/Controllers directory
- added Index.cshtml and Upsert.cshtml to JustinsBookStore/Areas/Admin/Views/CoverType



----- Time Modified -----
2022-11-21 @ 4:30PM
-------------------------

- ADDED MIGRATION to JustinsBooks.DataAccess --------------------------------------------------------> 20221121212925_addProductToDb
- updated database
- added validation to Product class (Product.cs)
- ADDED MIGRATION to JustinsBooks.DataAccess --------------------------------------------------------> 20221121214319_addValidationToProduct
- updated database
- added Product to Repository (ProductRepository.cs)
- added IProductRepository interface (IProductRepository.cs)
- added ProductRepository to UnitOfWork
- added IProductRepository to IUnitOfWork
- build to test
- success
- upload to hub


----- Time Modified -----
2022-11-21 @ 5:10PM
-------------------------	

- create Product Controller (ProductController.cs)
- create Product View Model in JustinsBooks.Models/ViewModels  (ProductVM.cs)

----- Time Modified -----
2022-11-22 @ 5:10
-------------------------

- getting an error when trying to add product to Db
- exception on UnitOfWork.cs

- PROBLEM: Products Table only had one foreign key
- SOLUTION: addProductToDb Lines 34 & 35 changed CategoryId to CoverTypeId

- problem solved
- upload to git



----- Time Modified -----
2022-11-29 @ 8:30P.M.

STARTING PART 4

-------------------------
- took off zebra style on product table
- changed to table dark on product table
- changed route to upsert
- added product table to landing screen
- changed link to upsert page so it will work on the main page


----- Time Modified -----
2022-11-30 @ 2:00P.M.
-------------------------
- uploading to gitHub because i forgot to last night


----- Time Modified -----
2022-11-30 @ 11:31P.M.
-------------------------
- updated ProductRepository
- updated ProductController
- updated product model
- updated static details class
- updated HomeController
- added migration addNewValidationToDb --------------------------------------------------------> 20221201044223_addNewValidationToProduct
- change the way products display on HomePage
- table now displays on its own page, cards display on landing/home screen



----- Time Modified -----
2022-12-08 @ 2:45PM
-------------------------
- renamed the website 
- make product image sizes the same
- cleaned up tab titles

----- Time Modified -----
2022-12-09 @ 11:10AM
-------------------------
- cleaned drop down
- changed header on landing screen fro Home -> Your Next Chapter















									  /;    ;\
                                  __  \\____//
                                 /{_\_/   `'\____
                                 \___   (o)  (o  }
      _____________________________/          :--'
  ,-,'`@@@@@@@@       @@@@@@         \_    `__\
 ;:(  @@@@@@@@@        @@@             \___(o'o)
 :: )  @@@@          @@@@@@        ,'@@(  `===='
 :: : @@@@@:          @@@@         `@@@:
 :: \  @@@@@:       @@@@@@@)    (  '@@@'
 ;; /\      /`,    @@@@@@@@@\   :@@@@@)
 ::/  )    {_----------------:  :~`,~~;
;;'`; :   )                  :  / `; ;
;;;; : :   ;                  :  ;  ; :
`'`' / :  :                   :  :  : :
   )_ \__;      ";"          :_ ;  \_\       `,','
   :__\  \    * `,'*         \  \  :  \   *  8`;'*
       `^'     \ :/           `^'  `-^-'   \v/ :