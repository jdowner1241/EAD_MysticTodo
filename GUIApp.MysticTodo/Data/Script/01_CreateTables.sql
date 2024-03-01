--++++++++++++++++++++++++++++++++++++++++++++++++++
-- MysticToDo Application Database: Create Tables
--++++++++++++++++++++++++++++++++++++++++++++++++++

--DROP DATABASE MysticToDo_DB
CREATE DATABASE MysticToDo_DB
USE MysticToDo_DB

--++++++++++++++++++++++++++++++++++++++++++++++++++
--DROP TABLE dbo.Boolean
/*CREATE TABLE dbo.Boolean
(
	Boolean_Key INT PRIMARY KEY INDENTITY(1,1),
	Boolean_Name NVARCHAR(5) UNIQUE
)*/

--++++++++++++++++++++++++++++++++++++++++++++++++++
--DROP TABLE dbo.Timeframe
CREATE TABLE dbo.Timeframe
(
	Timeframe_Key INT PRIMARY KEY IDENTITY(1,1),
	Timeframe_Name NVARCHAR(10) UNIQUE,
	TimeFrame_IntervalCode NVARCHAR(50)
)

--++++++++++++++++++++++++++++++++++++++++++++++++++
--DROP TABLE dbo.ClassObjects
/*CREATE TABLE dbo.ClassObjects
(
	ClassObjects_Key INT PRIMARY KEY INDENTITY(1,1),
	ClassObjects_Name NVARCHAR(50),
	ReminderObject_Id INT FOREIGN KEY REFERENCES Reminder(Reminder_Id),
)*/


--++++++++++++++++++++++++++++++++++++++++++++++++++
--DROP TABLE dbo.Reminder
CREATE TABLE dbo.Reminder
(
	Reminder_Id INT PRIMARY KEY IDENTITY(1,1),
	Reminder_Name NVARCHAR(100) NOT NULL,
	Reminder_Description NVARCHAR(500),
	Reminder_IsComplete BIT,
	Reminder_HadAlarm BIT,
	Reminder_ReminderActive BIT,
	Reminder_DateTime DATETIME,
	Reminder_IsPeriodic BIT,
	Reminder_PeriodicActive BIT,
	Reminder_PeriodicIntervalLabel INT FOREIGN KEY REFERENCES Timeframe(Timeframe_Key),
	Reminder_NextPeriodicDateTime DATETIME,
)



