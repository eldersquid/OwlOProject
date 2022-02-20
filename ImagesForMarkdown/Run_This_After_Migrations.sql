CREATE TABLE [dbo].[Causes] (
    [Causes_ID]  NVARCHAR (50) NOT NULL,
    [Cause]      NVARCHAR (50) NULL,
    [Project_ID] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Causes_ID] ASC)
);
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'1ca97ad1-829d-4495-9d60-03beb1e28df5', N'children', N'5')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'28b85979-fe59-4e0f-8209-7cc6d9b8a3fd', N'special needs', N'7')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'2ee958bc-270b-4928-a5a5-885625137fe8', N'animal', N'4')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'312312-12312321', N'elderly', N'8')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'38c01093-25d6-4b37-984c-cb8f3b193b3c', N'children', N'3')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'3f6c21e1-4f94-4866-919c-231a6f8cc0d8', N'animal', N'1')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'4970524c-2fe3-4974-ba9b-9222e62fca1c', N'elderly', N'6')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'4ebbb1a4-ee5c-4606-9d75-68631acebd20', N'special needs', N'2')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'6cf7b651-a917-4ea0-ac6d-b5019180826d', N'mental health', N'2')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'8d904022-1594-452f-a486-665b41b4f14b', N'homelessness', N'10')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'9685a098-4754-406a-8a72-68df3570f358', N'homelessness', N'11')
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'a1f81c6e-dcb8-46c9-b33a-b37b287ae7e1', N'mental health', NULL)
INSERT INTO [dbo].[Causes] ([Causes_ID], [Cause], [Project_ID]) VALUES (N'e3889909-9f4a-4b53-94be-6edcf0c5e7ce', N'elderly', N'1')

CREATE TABLE [dbo].[CommunityPartners] (
    [CommunityPartners_ID] NVARCHAR (50) NOT NULL,
    [CommunityPartner]     NVARCHAR (50) NULL,
    [Project_ID]           NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CommunityPartners_ID] ASC)
);
CREATE TABLE [dbo].[JoinRequests] (
    [JoinRequest_ID] NVARCHAR (50)  NOT NULL,
    [user]           NVARCHAR (MAX) NULL,
    [Introduction]   TEXT           NULL,
    [Reason]         TEXT           NULL,
    [Feedback]       TEXT           NULL,
    [Project_ID]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([JoinRequest_ID] ASC)
);
CREATE TABLE [dbo].[Meetings] (
    [Meeting_ID]     NVARCHAR (50) NOT NULL,
    [Project_ID]     NVARCHAR (50) NULL,
    [Meeting_Caller] NVARCHAR (50) NULL,
    [Title]          TEXT          NULL,
    [Description]    TEXT          NULL,
    [Priority]       INT           NULL,
    [Platform_link]  TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Meeting_ID] ASC)
);

INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'296ccf5d-f0eb-40b8-8e71-ea4f59218dbb', N'1', N'Nuzul Firdaly', N'Power Rangers', N'eokkdfd', 0, N'http//www.youtube.com')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'2f545229-5994-4f94-86c6-7ed2fffc86cd', N'1', N'Nuzul Firdaly', N'Power Rangers', N'description', 0, N'link')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'398c2f9e-a259-4122-ac03-f30599561e8f', N'1', N'Nuzul Firdaly', N'testing ', NULL, 0, N'asdasdads')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'65ac52f3-c31f-488d-b7c9-fca235a95363', N'1', N'Nuzul Firdaly', N'Power Rangers', N'wweqd', 0, N'dwads')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'6bdeaa2f-eddf-4d3b-a1bd-987bc6ab1565', N'1', N'Nuzul Firdaly', N'Discuss about Power Rangers', N'I love Power Rangers SPD', 0, N'http://www.youtube.com')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'7c003457-5ca4-4f8c-8810-d89d87533caf', N'1', N'Nuzul Firdaly', N'testing', NULL, 0, N'http//www.youtube.com')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'a33ff2b6-efcf-4cd2-bbfd-64d39ab4a86f', N'1', N'Nuzul Firdaly', N'testing ', N'decription', 0, N'http//www.youtube.com')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'ba4e77eb-201e-4a4c-ae59-0f2f60c3b1da', N'1', N'Nuzul Firdaly', N'Power Rangers', N'discuss about power rangers', 0, N'http//www.youtube.com')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'd3fff411-01d3-429e-b768-849f98249c2f', N'1', N'Nuzul Firdaly', N'To finish edp', N'to integrate', 0, N'https://www.youtube.com/')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'dcbf8896-60e9-45d7-8133-27c1cea98012', N'1', N'Nuzul Firdaly', N'Discuss about Power Rangers', N'Mighty Morphin!', 0, N'https://www.youtube.com')
INSERT INTO [dbo].[Meetings] ([Meeting_ID], [Project_ID], [Meeting_Caller], [Title], [Description], [Priority], [Platform_link]) VALUES (N'e009fcbb-4482-417d-9799-5f6e35e215d6', N'1', N'Nuzul Firdaly', N'testing ', N'dsadsa', 0, N'https://www.youtube.com')
CREATE TABLE [dbo].[Owlers] (
    [Email]    NVARCHAR (50) NOT NULL,
    [username] TEXT          NULL,
    [bio]      TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Email] ASC)
);

INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'firdaly321@gmail.com', N'Adam Khoo', N'Looking to make in impact in the world!')
INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'harris@mail.com', N'Harris George', N'I am a curious and creative individual who has a great time volunteering for organizations with diverse missions and projects around town.')
INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'kyle@mail.com', N'Kyle Ted', N'I''m the kind of person who seeks out new experiences until I know how to make them my own. Residing in the country not far from Nashville, I love volunteering.')
INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'luke@mail.com', N'Luke Junior', N'As a young volunteer, I am willing to offer my time and skills in order to learn more about myself anI get involved.')
INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'maddy@mail.com', N'Maddy Knox', N'I am interested in whatever projects entail. Constantly looking for functional projects that are both productive and enjoyable.')
INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'nuzul5567@gmail.com', N'Nuzul', N'A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.')
INSERT INTO [dbo].[Owlers] ([Email], [username], [bio]) VALUES (N'randy@mail.com', N'Rayden ', N'I am happy in life because I know I am doing what is in my heart. When you volunteer you give back in so many ways.')
CREATE TABLE [dbo].[Projects] (
    [Project_ID]  NVARCHAR (50) NOT NULL,
    [Title]       NVARCHAR (50) NULL,
    [Description] TEXT          NULL,
    [Members]     TEXT          NULL,
    [Image]       NVARCHAR (50) NULL,
    [Owner]       NVARCHAR (50) NULL,
    [Published]   BIT           NULL,
    PRIMARY KEY CLUSTERED ([Project_ID] ASC)
);
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'1', N'Save our Street Dogs (SOSD)', N'True to its name, Save our Street Dogs (SOSD) aims to do just that through education, rehoming and sterilisation. You can help out by joining their kennel team and bringing the dogs on walks and to outreach events, feed and bathe them, and clean their kennels.', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'10', N'MacPherson Community Engagement:', N'This project is a collaboration between Majulah Community and other community organisations to learn about the demographics and needs of Pipit Road and Circuit Road residents by conducting house-to-house interviews. Our ultimate goal is for these community organisations to provide the services that can best serve and support the MacPherson community.

We are looking for 50 Community Survey Scouts to help us accomplish this mission that will begin in January next year! Join us to start the year on a heart-warming note by contributing to the betterment of fellow residents'' lives. ', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'11', N'Survey Household Interview ', N'WISE is running an online survey on physical distancing and hygiene behaviours. We are looking for volunteers like you to gather perspectives on what behaviours people find difficult to practice and why. Our insights will be shared publicly online so that policy makers and ground-up movements alike can use the information to create effective initiatives in preventing the spread of COVID-19. ', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'2', N'Arts & Disabilities Forum ', N'Jointly organised by ART:DIS and National Arts Council, with venue support from Nanyang Academy of Fine Arts & National Gallery Singapore, learn how to work with and mentor artists with disabilities, and pave the way for greater diversity in Singapore. ', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'3', N'KIDS TUTORING', N'We hold kids tutoring sessions for ad hoc volunteers to attend. You will be able to partner with a kid to tutor certain subjects. Low Commitment Level.

Members would get to choose what we could do for the community and have fun together amongst Volunteers

People from all locations are welcome, It is all about your will to help ', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'4', N'Causes for Animals Singapore (CAS)', N'Causes for Animals Singapore (CAS) strives for a stray-free Singapore, and has successfully rehomed a whopping 98% of their dog rescues. Besides supporting their fund-raising and campaign efforts, another way you can help out is through becoming an event helper, where you’ll handle the dogs, and promote and sell merchandise at adoption drives.', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'5', N'THE WISHMAKERS PROJECT', N'Our objective is to provide a viable platform for donors to directly impact and see their impact to the beneficiary. This project is always ongoing and anyone can join. The project involves willing donors sponsoring moneys that will be pooled together every month and we will purchase premium food for underprivileged kids and elderly to enjoy.

On occasions, we will buy presents for the beneficiary so they may enjoy. ', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'6', N'Give to the elderly', N'"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'7', N'Sign Language - Interpretation Services', N'These services are for families receiving help from Family Service Centres and usually they are financially tight. Hence, they cannot afford to hire a personal interpreter. If you are able to interpret sign language, please apply with us to help these individuals.

To conduct Interpretation for client during sessions with Social Worker.

Activity is ad-hoc and would last for 1-2 hours', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'8', N'Medical Escort', N'Accompany senior for their medical appointment, to and fro between their home and Sengkang General Hospital (SKH). More details will be shared upon confirmation. ', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
INSERT INTO [dbo].[Projects] ([Project_ID], [Title], [Description], [Members], [Image], [Owner], [Published]) VALUES (N'9', N'Weekly Befriending Call to the Elderly', N'Loneliness and social isolation are key risk factors associated with poor physical and mental health. Please join us in making a weekly befriending call to our elderly who have been suffering from social isolation and loneliness due to the unprecedented global pandemic of Covid 19. We will pair you up to 2 to 3 elderly and arrange you to call them on a weekly basis, to chat and show concern to their overall well being.', N'nuzul5567@gmail.com', N'Screenshot 2021-12-20 152643.jpg', N'nuzul5567@gmail.com', 1)
CREATE TABLE [dbo].[ProjectTasks] (
    [ProjectTasks_ID] NVARCHAR (50) NOT NULL,
    [task]            NVARCHAR (50) NULL,
    [Project_ID]      NVARCHAR (50) NULL,
    [owner]           NVARCHAR (50) NULL,
    [timestamp]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([ProjectTasks_ID] ASC)
);

INSERT INTO [dbo].[ProjectTasks] ([ProjectTasks_ID], [task], [Project_ID], [owner], [timestamp]) VALUES (N'41a26bbe-9cc3-4ec4-a5a2-be880a37df8f', N'blah', N'1', N'Nuzul Firdaly', N'2022-01-19 11:37:37')
INSERT INTO [dbo].[ProjectTasks] ([ProjectTasks_ID], [task], [Project_ID], [owner], [timestamp]) VALUES (N'6f07547b-ca23-47c7-88ed-7b43a768a28e', N'testing', N'1', N'Nuzul Firdaly', N'2022-01-19 12:35:48')
INSERT INTO [dbo].[ProjectTasks] ([ProjectTasks_ID], [task], [Project_ID], [owner], [timestamp]) VALUES (N'cd708054-cb35-4d36-82ad-f69b48484e61', N'finish edp 2', N'1', N'Nuzul Firdaly', N'2022-01-19 14:52:50')
INSERT INTO [dbo].[ProjectTasks] ([ProjectTasks_ID], [task], [Project_ID], [owner], [timestamp]) VALUES (N'd3da3a79-ce16-4eee-b2f2-2e6099d8f2e1', N'fasdasdf', N'1', N'Nuzul Firdaly', N'2022-02-13 23:43:43')
INSERT INTO [dbo].[ProjectTasks] ([ProjectTasks_ID], [task], [Project_ID], [owner], [timestamp]) VALUES (N'd555fff1-77bc-4432-b939-b0736d310833', N'finish edp 2', N'1', N'Nuzul Firdaly', N'2022-01-19 14:04:11')

CREATE TABLE [dbo].[Resources] (
    [Resource_id] NVARCHAR (50) NOT NULL,
    [title]       NVARCHAR (50) NULL,
    [link]        TEXT NULL,
    [project_id]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Resource_id] ASC)
);

CREATE TABLE [dbo].[SkillsNeeded] (
    [SkillsNeeded_ID] NVARCHAR (50) NOT NULL,
    [Skill]           NVARCHAR (50) NULL,
    [Project_ID]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([SkillsNeeded_ID] ASC)
);

INSERT INTO [dbo].[SkillsNeeded] ([SkillsNeeded_ID], [Skill], [Project_ID]) VALUES (N'9836174a-d73c-4dbd-9685-aa4485a96577', N'Marketing', N'1')
INSERT INTO [dbo].[SkillsNeeded] ([SkillsNeeded_ID], [Skill], [Project_ID]) VALUES (N'ca0d91a9-ab60-48dd-adac-c4ac07b5df72', N'Web Development', N'1')
CREATE TABLE [dbo].[TeamMembers] (
    [TeamMember_ID] NVARCHAR (50) NOT NULL,
    [role]          NVARCHAR (50) NULL,
    [Project_ID]    NVARCHAR (50) NULL,
    [UserName]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([TeamMember_ID] ASC)
);
INSERT INTO [dbo].[TeamMembers] ([TeamMember_ID], [role], [Project_ID], [UserName]) VALUES (N'ae807b0f-e391-4517-89d6-e2e0fc2b52f8', N'Volunteer', N'2', N'Nuzul')
INSERT INTO [dbo].[TeamMembers] ([TeamMember_ID], [role], [Project_ID], [UserName]) VALUES (N'd432a68d-d54b-4588-8b1a-6e1f5c9482f5', N'Volunteer', N'1', N'Adam Khoo')
CREATE TABLE [dbo].[userInterests] (
    [userInterest_ID] NVARCHAR (50) NOT NULL,
    [interest]        NVARCHAR (50) NULL,
    [Project_ID]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([userInterest_ID] ASC)

);

INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'1', N'elderly', N'firdaly321@gmail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'2', N'elderly', N'nuzul5567@gmail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'3', N'children', N'harris@mail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'4', N'animal', N'luke@mail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'5', N'special needs', N'maddy@mail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'6', N'homelessness', N'randy@mail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'7', N'elderly', N'kyle@mail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'8', N'mental health', N'nuzul5567@gmail.com')
INSERT INTO [dbo].[userInterests] ([userInterest_ID], [interest], [Project_ID]) VALUES (N'9', NULL, NULL)
CREATE TABLE [dbo].[userSkills] (
    [userSkills_ID] NVARCHAR (50) NOT NULL,
    [userSkill]     NVARCHAR (50) NULL,
    [Project_ID]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([userSkills_ID] ASC)
);

INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'1', N'Front-end', N'firdaly321@gmail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'10', N'Work ethic', N'maddy@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'11', N'Attention to Detail', N'randy@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'2', N'Web Development', N'nuzul5567@gmail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'3', N'Time Management', N'nuzul5567@gmail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'4', N'Communication', N'harris@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'5', N'Adaptability', N'harris@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'6', N'Problem-Solving', N'luke@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'7', N'Teamwork', N'maddy@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'8', N'Creativity', N'randy@mail.com')
INSERT INTO [dbo].[userSkills] ([userSkills_ID], [userSkill], [Project_ID]) VALUES (N'9', N'leadership', N'kyle@mail.com')






