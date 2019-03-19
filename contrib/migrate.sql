CREATE DATABASE PatientSystem;
GO
USE PatientSystem;

CREATE TABLE [dbo].[users] (
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL
);
GO
CREATE TABLE [dbo].[patients]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(50) NOT NULL, 
    [sex] NVARCHAR(50) NULL, 
    [birthday] NVARCHAR(50) NULL, 
    [age] INT NULL, 
    [weight] FLOAT NULL, 
    [height] FLOAT NULL, 
    [mdate] NVARCHAR(50) NULL 
)
GO

CREATE TABLE [dbo].[checkups]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [patient_id] INT NULL, 
    [mdate] NVARCHAR(50) NULL
)
GO

CREATE TABLE [dbo].[history]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [patient_id] INT NULL, 
    [checkup_id] INT NULL,
    [disease] NVARCHAR(50) NULL,
    [treatment] NVARCHAR(50) NULL
)
GO

INSERT INTO [users] ([username], [password]) VALUES ('admin', 'secret')
INSERT INTO [patients] ([name], [sex], [birthday], [age], [weight], [height], [mdate]) 
	VALUES ('John Doe', 'Male', '1/3/1976', 45, 40, 245, '3/19/2019')