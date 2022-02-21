
![This is an image](/ImagesForMarkdown/owlopic.png) 

# Introductions
---
Welcome to our github repository, here you will find our source code, some simple instructions and brief description of each of the team members features.
OWLO is an ambitious project that is put together by, Azfar, Danish, Gabriel, Jing Kai and Nuzul. You may find more elaboration on the project through our slides, project report or even the demo markdown for each of our parts.

# Getting Started
---
In order to succesfully run our application, please do the following. 

### Step 0: Delete existing migrations
Please delete the existing migrations and/or model snapshot
### Step 1: Run migrations  
```sh
dotnet ef migrations authdb --context authdbcontext
dotnet ef database update --context authdbcontext

dotnet ef migrations owlodb --context owlodbcontext
dotnet ef database update --context owlodbcontext
```
### Step 2: Copy sql scripts to update and populate databases
Download the SQL scripts located in the other resources section below.

# Features
---
Since OWLO is a big application with many application it is unwise to fit all of them in 1 single readme. Hence, we have split our the instructions into seperate readme so that you can run the demo with ease.

### [OWLO PLAN - Nuzul](OwloPlan.md)


# Other Resources

| Resource | Link |
| --- | ----------- |
| Project Report | [link](https://docs.google.com/document/d/10XgJhgCkWqU_6sObHvtWeG16Jk_LCDH-JvEjIPYs0r8/edit?usp=sharing) |
| Presentation Slides | [link](https://docs.google.com/presentation/d/110JlaGVKrxqfZmyVvUeThdp4HaXcDSFu_lNzs2SYXNg/edit?usp=sharing) |
| SQL Scripts| [link](/ImagesForMarkdown/Run_This_After_Migrations.sql) |

