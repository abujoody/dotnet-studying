--UPDATE Classes Set [RoomNumber] = 150 WHERE [Name] = '11-À'

--UPDATE Classes Set [RoomNumber] = 200 WHERE [RoomNumber] = 150

UPDATE Classes Set [RoomNumber] = 0 WHERE [Name] LIKE '1-%'