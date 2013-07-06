--SELECT [Name], [RoomNumber] FROM Classes WHERE [Name] Like '4-%';

--SELECT [Name], [RoomNumber] FROM Classes WHERE [Name] Like '4-%';

--SELECT * FROM Classes;

--SELECT [Name], [RoomNumber] FROM Classes ORDER BY [Name] Asc; -- Asc is not needed (default)

--SELECT [Name], [RoomNumber] FROM Classes ORDER BY [Name] Desc;

--All except first floor
--SELECT [Name], [RoomNumber] FROM Classes WHERE [RoomNumber] >= 200 ORDER BY [Name] Desc;

--SELECT [Name], [RoomNumber] FROM Classes WHERE [RoomNumber] >= 200 OR [Name] Like '%Á';

--SELECT [Name], [RoomNumber] FROM Classes WHERE [RoomNumber] >= 200 AND [Name] Like '%Á';

--SELECT [Name], [RoomNumber] FROM Classes WHERE Not ([RoomNumber] >= 200 AND [Name] Like '%Á');

--SELECT [Name], [RoomNumber] FROM Classes WHERE [Name] IN ('1-À', '1-Á', '1-Â') ORDER BY [Name];

--SELECT DISTINCT [RoomNumber] FROM Classes;

--SELECT MAX (ID) FROM Classes;

--SELECT MIN (ID) FROM Classes;

--SELECT SUM (ID) FROM Classes;

--SELECT COUNT (*) FROM Classes;

SELECT AVG(ID) FROM Classes;