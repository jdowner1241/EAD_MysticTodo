--++++++++++++++++++++++++++++++++++++++++++++++++++
-- MysticToDo Application Database: Add Table data
--++++++++++++++++++++++++++++++++++++++++++++++++++
USE MysticToDo_DB

--++++++++++++++++++++++++++++++++++++++++++++++++++
-- dbo.Timeframe

INSERT INTO dbo.Timeframe(Timeframe_Name, TimeFrame_IntervalCode)
VALUES
('Daily','.AddDays(1)'),
('Weekly', '.AddWeeks(1)'),
('Montly', '.AddMonths(1)'),
('Yearly', '.AddYears(1)')