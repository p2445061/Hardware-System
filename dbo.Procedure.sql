CREATE PROCEDURE sproc_tblStock_Insert
	@PartDescription varchar(MAX),
	@DateAdded date,
	@Quantity int,
	@Price decimal,
	@Available bit
AS
	INSERT INTO tblStock(PartDescription, DateAdded,Quantity,Price,Available)
	values (@PartDescription, @DateAdded, @Quantity, @Price, @Available)

	return @@Identity
