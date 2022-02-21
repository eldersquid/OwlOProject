![This is an image](/ImagesForMarkdown/Webp.net-resizeimage.png)
![This is an image](/ImagesForMarkdown/owloplan.png)


## Author: Nuzul Firdaly

> “Wherever you turn, you can find someone who needs you. Even if it is a little thing, do something for which there is no pay but the privilege of doing it. Remember, you don’t live in the world all of your own.”
~Albert Schweitzer

# Table of Contents
---

#### 1. Description
#### 2. Features & CRUDs
#### 3. Step-by-Step Guide on Remote Demo




# 1. Description
---
OWLO plan is a subsidiary feature of OWLO itself. It intends to lure in not just the elderly(Workshop) nor young audience(Library) but also season volunteers. OWLO Plan or PLAN for short, provides the means and capabilities that eases the volunteering experience thus encourage even the inexperience to enjoy volunteering. 

The basic flows and features of PLAN can be broken down into 4 parts:
*A.  Project Management*
*B.  Publish Project*
*C. Explore Projects*
*D. Invite Volunteers*

# 2. Features
---
### A. Project Management
At the **My Projects** page and as an organizer. You are encouraged to create a project if you dont have any. After creating a unique project, the organizer can start to either manage or publish the project

+CRUD Project

Once a project is created, the user is presented with the option to manage the project. When clicked the user is brought to the **Manage Project** Page. In this page, the user is able to see different sections with different functionalities to support project planning. Such functionalities are:

+CRUD Tasks
+CRUD Meetings
+CRUD Resources

There is also the team members and application section but we will cover it in the Invite Volunteers and Explore project section respectively

### B.  Publish Project
When the project team requires new and skillful people, they can get them through publishing their project. Doing so will put their project in the explore project page according to their causes they have listed. 

+CRD Skills Needed
+CRD Causes
+CRD Community Partners
### C. Explore Projects
The developers here at OWLO understands that not all volunteers have the energy to manage a project let alone a team. Most often than not, people may find it to be more comfortable to have other more talented people to lead the project. Hence, OWLO is dedicated to also providing a seamless experience in joining a project. To do so, a user will need to first find a project that matches their interests. Then, go on the explore projects page and select a cause they would like to browse through. After, the user can browse through the projects that is listed in that specific cause. 

When a project listing manage to attract the users attention, the user may either quickly join a project or view the project details. 
When in the join project page the user is encouraged to input a simple introduction, reasons to join and feedback if there are any. After, the project members will see a new entry in the application section of the project management page. The members can decide to whether accept or deny the request to join. 

+CRD Join Request/Application

### D. Invite Volunteers
An existing project member may find that they have friends or family that is suitable for the project and hence can directly invite them to join the project. To do so, the member will need to search for the user in the Explore volunteer section. After that the member can invite the user in a project that he/her isn't already inside.

+CRD Invitation




# 3. Step-by-Step Guide on Remote-Demo


## 1. Getting Started 
---
In order to access OWLO Plan, a user will need to be logged in from OWLO Library. After successful login, the user will be prompted to choose a platform they would like to navigate to. If the user is unable to access the change platform link in the owlo library navigation bar, the user can logout and login again and be prompted the choose a platform again and this time be able to select OWLO Plan.

### Step 0: Register an account in OWLO library
Register and Login to your account

![This is an image](/ImagesForMarkdown/images/registerandlogin.jpg)



### Step 1: Create an entry in the OWLERS Table
Because the login system were implemented late during the development stage, some of the logic and process had to be hard coded. Hence, when a user registers an account in the owlo library it doesnt add an entry directly into OWLER, hence the admin will need to verify the user before they can access the OWLO Plan platform. To replicate this process, Just add an email, username and bio that you used to register an account in owlo library into the Owlers table inside the OwloDB

![This is an image](/ImagesForMarkdown/images/loginsameemail.jpg)

![This is an image](/ImagesForMarkdown/images/addowlerentry.jpg)

### Step 2: Change to OWLO Plan
After logging in, choose OWLO Plan in the ChoosePath page
If entry is correct, you will be able to access OWLO Plan with the same email you login and entry without having any errors
![This is an image](/ImagesForMarkdown/images/choosepath.jpg)


### Step 3: My Project
In **My Projects** Page, create a project, add a title and short description. You can ignore the team members section. Add an image (if it does not work, you can edit the image later on). When succesful, the user will be directed back to the my project page where they can find their newly created project.

![This is an image](/ImagesForMarkdown/images/createnewproject.jpg)

![This is an image](/ImagesForMarkdown/images/Create a project.jpg)
![This is an image](/ImagesForMarkdown/images/After creation.jpg)

## 2. Project Management
---
### Step 0: Manage a Project
In the My Project Page, click on the manage button

![This is an image](/ImagesForMarkdown/images/Project management.jpg)


### Step 1: Add a Task

![This is an image](/ImagesForMarkdown/images/addtask.jpg)


### Step 2: Add a Meeting
![This is an image](/ImagesForMarkdown/images/add meeting.jpg)

### Step 3: Add a Resource
![This is an image](/ImagesForMarkdown/images/addresource.jpg)



## 3. Publish Project
---
### Step 0: Publish a project
If you are in the my project page, click on Publish. If you are the manage project, navigate to publish.

### Step 1: Edit Project Image
![This is an image](/ImagesForMarkdown/images/edit project image.jpg)

### Step 2: Edit Description
![This is an image](/ImagesForMarkdown/images/editdescription.jpg)

### Step 3: Add Skills Needed
![This is an image](/ImagesForMarkdown/images/Add Skill.jpg)

### Step 4: Add Causes

**please make sure it is all lowercase so that it will appear in the explore project in the category of the same name**
![This is an image](/ImagesForMarkdown/images/addcause.jpg)

### Step 5: Community Partner
![This is an image](/ImagesForMarkdown/images/Add Community Partner.jpg)

## 4. Explore Projects
---
### Step 0: Go to Explore Projects
### Step 1: Select a cause
### Step 2: Browse and select a project
### Step 3: Join a project

## **As an organizer**
You can go back to view the project you just join and accept the request to join


## 5. Invite Volunteers
---
### Step 0: Go to Explore Volunteers
### Step 1: Browse and select a volunteer
### Step 2: Invite and select a project




