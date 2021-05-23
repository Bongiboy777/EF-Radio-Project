# EF-Radio-Project

## Contents

1.  [Project Description](# Project Description)
1.  [Preparation](# Preparation)
1.  [Approach](# Approach)
1.  [Sprints](# Sprints)
1.  [Final Product](# Final Product)
1.  [Installation Guide](# Installation Guide)



## Project Description

#### Task
This project assignment was given as part of the C# SDET programme from Sparta global as the mid-course project. 


At this point we had covered C# Core, OOP, Data, WPF and agile, and the task was to produce a three tier application using the principles learnt previously. The three tiers consist of 

1. A Database layer, holding all relevant tables and relationships, using SQL.
2.  An intermediate/business layer,  using C# and entity framework to communicate with and use the database, as well as any other behind the scenes functionality/architecture needed.
3.  A GUI layer, using WPF to build the frontend of the application.

The application ideas were independently determined, planned and executed by each member of the class, and using the SCRUM framework we divided the project into seven sprints starting on Tuesday 11/05/21 and ending on Tuesday 18/05/21 where we presented our final products in a general meeting in the Sparta Academy.


#### My implementation

<p>
    My goal was to expand on a smaller project started on the course, which was a simple radio/playlist project. The project functions as a playlist creator and music player and was chosen because of my passion for music and already having a good idea of what I wanted it to become. </p>

​    


1. Database layer.

	- Users.
	- Playlists.
	- Tracks.
2. Intermediate/business layer.

	- User manager.
	- Playlist manager.
	- Track manager.
3.  GUI layer.
	- Playback interface.
	- Authentication interface.
	- Playlist management interface.

## Preparation

Initial ERD:

![ERD](/ReadmeResources/ERD-BeforePresentation.png)

## Wireframe (Created in sprint 2):

Login page

![ERD](/ReadmeResources/Log in page Wireframe.png)

Playback page 

![ERD](/ReadmeResources/Logged in Wireframe.png)

Registration page

![ERD](/ReadmeResources/Create new account-Wireframe.png)

Settings navigation page

![ERD](/ReadmeResources/Settings-Wireframe.png)

Search directories page

![ERD](/ReadmeResources/SearchDirectories-Wireframe.png)

Manage channels page

![ERD](/ReadmeResources/ManageChannels-Wireframe.png)

Change details page

![ERD](/ReadmeResources/AccountInfo-Wireframe.png)

## Sprints

- ## Sprint 1 - 11/05/2021

- Start

- ![Start](/ReadmeResources/Sprint1Start.png)

- End

- ![Start](/ReadmeResources/Sprint1End.png)

  ### Review 

  #### User Stories

	- [x] 1.1A
  - [x] 1.2A
  - [x] 1.1C
  - [x] 3.1A
  - [x] 3.3A - From radio project
  - [x] 3.3B - From radio project
  - [x] 2.1A - From radio project
  - [x] 2.1C - From radio project
  
  #### Additional
  
  ###### Completed:
  
  1. Create ERD
  2. Scaffold database
  3. Cleaned up code from previous project
  4. Reorganized project
  
  ###### Not completed:
  
  1. Implement database
  
  ###### Next steps:
  
  1. Implement database
  
  ### RetroSpective
  
  <p>
  Sprint was somewhat productive, but was held back by minimal planning of database aspects and general foresight. Could have been managed better but made steady progress. Have clearer idea of upcoming problems and potential solutions regarding database. For next time, plan out the architecture and build a mental user story going through all processes.
  </p>
  


  - ## Sprint 2 - 12/05/2021

  - Start

  - ![Start](/ReadmeResources/Sprint2Start.png)

  - End

  - ![Start](/ReadmeResources/Sprint2End.png)

  ### Review 

 #### User Stories

  - [x] 1.1D
  - [x] 1.2C
  - [x] 1.1B

#### Additional

######  Completed:

    1. Wireframing the GUI.

###### Not Completed:

    1. Create settings page

###### Next steps:

    1. Create settings page.
    2.  Add more tests for user manager class.

  ### RetroSpective

Was a wise decision to wireframe before further GUI design execution. Completed all items on sprint backlog, was generally a more focussed session than last time.




- ## Sprint 3 - 13/05/2021

- Start

- ![Start](/ReadmeResources/Sprint3Start.png)

- End

- ![Start](/ReadmeResources/Sprint3End.png)

  ### Review 

   #### User Stories

    - [x] 1.2D
    - [x] 1.2B

  #### Additional

  ###### Completed:

  1. Adding settings page and completing navigation.
  4. Integrating tracks column with IWMP interface.

  ###### Not Completed:

  1. Testing playlist functions to add and remove.

  ###### Next steps:

  1. Find a way to add tracks to playlist.
  2. Test playlist functions.



  ### RetroSpective

In future, should decide to use libraries with good documentation, as IWMP caused a lot of problems this session. Accomplished all user stories, but did not get a desired result when using the music player. Should have done more research into WMP library.

- ## Sprint 4 - 14/05/2021

- Start

- ![Start](/ReadmeResources/Sprint4Start.png)

- End

- ![Start](/ReadmeResources/Sprint4End.png)

  ### Review 

  #### User Stories

  - [x] 1.3A
  - [x] 2.4A
  - [x] 2.3A
  - [x] 3.2A
  - [x] 2.1B - Finished in morning
  
  #### Additional 
  
  ###### Completed:
  
  1. Decoupled tracks class from IWMP interface
  2. Removed unnecessary tables from database
  3. Created Settings page
  
  ###### Not Completed:
  
  1. Testing playlist functions to add and remove
  2. Adding tracks to playlist functions
  3. Adding search directories
  
  ###### Next steps:
  
  1. Find a way to add tracks to playlist
  
  2. Test playlist functions
  
  3. Add search directory functionality.
  
     ### RetroSpective
  
     Sprint started slow, but found great progress in new strategy for using WMP library, cleaning up ERD/database also very helpful. Overall a good sprint and good recovery from yesterday. However the sprint would be better if I approached more methodically/TDD approach so I can fit tests in.
  
  <p>


  </p>

- ## Sprint 5 - 15/05/2021

- Start

- ![Start](/ReadmeResources/Sprint5Start.png)

- End

- ![Start](/ReadmeResources/Sprint5End.png)

  ### Review 

  #### User Stories

  - [x] 2.2B
  - [x] 1.1E
  - [ ] 2.2A
  - [ ] 1.4A

#### Additional

###### Completed:

1. Adding more return buttons for more navigation.
2. Create tests for 2.2B



#### RetroSpective

Created methods to change details and passed tests, however have not finished account info page. To improve sprint, next time I should allocate a set period during weekend to focus on sprint.

  </p>

- ## Sprint 6 - 16/05/2021

- Start

- ![Start](/ReadmeResources/Sprint6Start.png)

- End

- ![Start](/ReadmeResources/Sprint6End.png)

  ### Review 

  1. #### User Stories

     - [x] 2.5A
     - [x] 3.2C
     - [x] 3.2B
     - [x] 3.1B
     - [ ] 2.2A
     - [ ] 1.4A
#### Additional

###### Completed:

1. Fixed playback bugs.
######  Not Completed:

1. Visual update
   
2. Logo
   
3. Return buttons.


###### Next steps:

1. Update visuals
2. Fix new bugs

#### RetroSpective

A very productive sprint, a lot of problems however with folder explorer, which took most time. Better time allocation than last sprint. Again however a methodical approach would be better.

  <p>


  </p>

  - ## Sprint 7 - 17/05/2021

  - Start

- ![Start](/ReadmeResources/Sprint7Start.png)

- End

- ![Start](/ReadmeResources/Sprint7End.png)

  ### Review 

  #### User Stories

  - [x] 2.2A - Testing finally done.
  - [ ] 2.2B
  - [ ] 1.4A
  
  #### Additional
  
  ###### Completed:
  
  1. Changed some lists designs by adding card background to each one from material designer.
  
  2. Added logo
  
  3. Fixed playback bugs
  
  4. Added return button to registration page
  
  5. Changed playback button display to typical icons
  
     
  
  ###### Not Completed:
  
    1. Finishing readme
  
  ###### Next steps:
  
  1. This readme.
  2. Presentation.



  ### RetroSpective

Final sprint very productive, big difference in changing the appearance last. Was not a well designed sprint, as objective was to get product ready, however I am happy with the progress made and result so far.



### Final product

Final ERD:

![ERD](/ReadmeResources/ERD-AfterPresentation.png)

Final login page:

![ERD](/ReadmeResources/LoginPage.png)

Final registration page:

![ERD](/ReadmeResources/RegistrationPage.png)

Final playback page:

![ERD](/ReadmeResources/PlaybackPage.png)

Final playlist management page:

![ERD](/ReadmeResources/ManageChannelsPage.png)

Final search directory page:

![ERD](/ReadmeResources/SearchDirectoriesPage.png)

Final settings navigation page:

![ERD](/ReadmeResources/SettingsPage.png)

Final account info page:

![ERD](/ReadmeResources/AccountInfoPage.png)



## Setup

1. Install and upgrade VS2019 (Visual studio 2019) version must be community or better.
2. If you don't already have these tools, install using modify installation in visual studio installer.
   1. Data storage and processing
   2. .Net desktop development.
3. Open MyJukebox.sln in VS2019 and if not prompted, use right click on solution in solution explorer, navigate to manage Nuget packages for solution, and install
   1. Entity Framework Core
   2. Entity Framework Core.Tools
   3. Entity Framework Core.SqlServer
4. On top bar navigate to Tools > Nuget Package Manager  and select the PCM (package manager console).
5. At the bottom of window, select new PCM window and change the default project to radio database.
6. In the PCM console type Add-Migration Initial Create and run (Enter).
7. In the PCM console type Update-Database and run.
8. Run the programme using Debug/Run button at top of window.





