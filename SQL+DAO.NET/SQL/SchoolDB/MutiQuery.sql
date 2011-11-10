-- Just table product
--SELECT [Classes].[Name], [Head].[Name] FROM [Classes], [Head];

--Null Classes.HeadID lost
--SELECT [Classes].[Name], [Head].[Name] FROM [Classes], [Head] WHERE [Classes].[HeadID] = [Head].[ID];

--Null Classes.HeadID still lost
--SELECT [Classes].[Name], [Head].[Name] FROM
--([Classes] JOIN [Head] ON Classes.HeadID = Head.ID) -- () - for clear understandnig
-- WHERE can be followed then
--WHERE Classes.RoomNumber < 200;

--Similar results from handmade request
--SELECT Classes.[Name] FROM Classes Where Classes.HeadID =
--(SELECT Head.ID From Head Where Head.[Name] Like '%ирон%'); -- Get ID from Another Table by Name

-- !!! NULL values included
--SELECT [Classes].[Name], [Head].[Name] FROM
--([Classes] LEFT JOIN [Head] ON Classes.HeadID = Head.ID);

--SELECT [Classes].[Name], [Head].[Name] FROM
--([Classes] LEFT JOIN [Head] ON Classes.HeadID = Head.ID) WHERE Classes.HeadID IS NOT NULL;

--SELECT [Classes].[Name], [Head].[Name] FROM
--([Classes] LEFT JOIN [Head] ON Classes.HeadID = Head.ID) WHERE Head.ID IS NULL;

-- The ssme bu mor clear
--SELECT [Classes].[Name], [Head].[Name] FROM
--([Classes] LEFT JOIN [Head] ON Classes.HeadID = Head.ID) WHERE Classes.HeadID IS NULL;

--SELECT Classes.ID, Classes.[Name] FROM Classes
--UNION
--SELECT Head.ID, Head.[Name] FROM Head;

--SELECT Count(*) AS TotalClassesOnFirstSecond From Classes Where RoomNumber < 300;

SELECT * FROM Classes Where (HeadID IN (SELECT ID From Head) OR HeadID is NULL);