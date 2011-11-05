/*Reset next Record ID in Classes table to zero */ 
DBCC CHECKIDENT (Classes, RESEED, -1)