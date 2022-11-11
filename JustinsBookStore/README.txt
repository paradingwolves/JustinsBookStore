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


----- Time Modified -----
2022-11-11 @ 10:25AM
-------------------------
- creating ISP_Call interface in IRepository
- creating SP_Call class in Repository

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