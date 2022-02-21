
![This is an image](/ImagesForMarkdown/owlopic.png) 

# Introductions
Welcome to our github repository, here you will find our source code, some simple instructions and brief description of each of the team members features.
OWLO is an ambitious project that is put together by, Azfar, Danish, Gabriel, Jing Kai and Nuzul. You may find more elaboration on the project through our slides, project report or even the demo markdown for each of our parts.

# Getting Started
In order to succesfully run our application, please do the following. 

### Step 0: Delete existing migrations & database
Please delete the existing migrations and/or model snapshot
***IF** it exists, delete OwloDB and OwleeDB in server object explorer
### Step 1: Manage Packages

#### Note:
>The below packages are required to build and run our code. 
Continuing without ensuring the mentioned packages are installed, the following steps will not work.

To run Identity, using Microsoft.AspNetCore (All version 3.1.21):
```
Identity.EntityFrameworkCore 
Identity.UI
Session
```

To run Application, using Microsoft.EntityFrameworkCore (All version 3.1.21, Microsoft.EntityFrameworkCore included):
```
Sqlite
Sqlite.Core
SqlServer
Tools
```

To run additional APIs and features:
```
CsvHelper (27.2.1)
Google.Apis.Dialogflow.v3beta1 (1.55.0.2556)
Google.Cloud.Dialogflow.V2 (3.8.0)
Google.Cloud.Language.V1 (2.3.0)
Google.Cloud.Vision.V1 (2.4.0)
IronOcr (2021.12.0)
```


### Step 2: Run migrations  
```sh
dotnet ef migrations add authdb --context authdbcontext
dotnet ef database update --context authdbcontext

dotnet ef migrations add owlodb --context owlodbcontext
dotnet ef database update --context owlodbcontext
```
### Step 3: Copy sql scripts to update and populate databases
Download the SQL scripts located in the [other resources](#other-resources) section below.

# Features
Since OWLO is a big application with many features it is unwise to fit all of them in 1 single readme. Hence, we have split our instructions into seperate readme so that you can run the demo with ease.

**Owlo Plan - Nuzul](OwloPlan.md)**

**Owlo Library - Danish](OwlOLibraryReadme.md**

**Owlo Workshop - Danish](OwlOLibraryReadme.md**


# Other Resources

| Resource | Link |
| --- | ----------- |
| Project Report | [link](https://docs.google.com/document/d/10XgJhgCkWqU_6sObHvtWeG16Jk_LCDH-JvEjIPYs0r8/edit?usp=sharing) |
| Presentation Slides | [link](https://docs.google.com/presentation/d/110JlaGVKrxqfZmyVvUeThdp4HaXcDSFu_lNzs2SYXNg/edit?usp=sharing) |
| SQL Scripts| [link](/ImagesForMarkdown/Run_This_After_Migrations.sql) |

