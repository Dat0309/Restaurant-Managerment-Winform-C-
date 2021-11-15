CREATE PROCEDURE InsertFood
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000),
@Picture nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes, Picture)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes, @Picture)

	SELECT @ID = SCOPE_IDENTITY()

go

drop PROCEDURE InsertFood

CREATE PROCEDURE [aUpdateFood]
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
as
UPDATE [Food] set 
[Name] = @Name,[Unit] = @Unit, [FoodCategoryID] = @FoodCategoryID,[Price]=@Price,[Notes]=@Notes
where ID = @ID

if @@ERROR <> 0
return 0
else
return 1

create procedure Category_Insert
(
	@ID int output,
	@Name nvarchar(1000),
	@Type int
)
as
begin
	if (not exists (select Name from Category where Name = @Name))
		insert into Category (Name, Type) values (@Name, @Type)
		SELECT @ID = SCOPE_IDENTITY()
end
go

--drop procedure Bills_GetByDate
create procedure Bills_GetByDate
@date smalldatetime
as 
begin
	select * from Bills
	where CheckoutDate = @date
end
go

create procedure BillDetail_GetById
@ID int
as 
begin
	select bd.ID,f.Name, bd.Quantity 
	from BillDetails bd, Food f
	where bd.InvoiceID = @ID and f.ID = bd.FoodID
end
go


create procedure Account_Insert
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
as
begin
	if (not exists (select AccountName from Account where AccountName = @AccountName))
		insert into Account(AccountName,Password, FullName, Email, Tell, DateCreated) values (@AccountName, @Pass, @FullName, @Email, @Tell, @DateCreated)
end
go

create procedure Account_Update
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200),
	@FullName nvarchar(1000),
	@Email nvarchar(1000),
	@Tell nvarchar(200),
	@DateCreated smalldatetime
)
as
begin
	update Account
	set AccountName = @AccountName, Password = @Pass, FullName = @FullName, Email = @Email, Tell = @Tell, DateCreated = @DateCreated
	where AccountName = @AccountName
end
go

create procedure Role_GetByName
@name nvarchar(100)
as 
begin
	select r.RoleName
	from Role r,RoleAccount ra, Account a
	where a.AccountName = ra.AccountName and r.ID = ra.RoleID and a.AccountName = @name
end
go

drop proc TableStatus_Update

create proc TableStatus_Update
@ID int,
@Status int
as
begin
	if(exists(select Name from [Table] where ID = @ID))
		update [Table]
		set Status = @Status
		where ID = @ID
end
go

drop procedure BillDetail_Insert
create procedure BillDetail_Insert
@id int output,
@InvoiceID int,
@FoodID int,
@Quantity int
as
begin
	insert into BillDetails(InvoiceID, FoodID, Quantity) values (@InvoiceID, @FoodID, @Quantity)
	SELECT @id = SCOPE_IDENTITY()
end
go

drop procedure Bills_Insert

create procedure Bills_Insert
@id int output,
@Name nvarchar(1000),
@TableID int,
@Amount int,
@Discount float,
@Tax float,
@Status bit,
@CheckoutDate smalldatetime,
@Account nvarchar(100)
as
begin
	insert into Bills(Name, TableID, Amount, Discount, Tax, Status, CheckoutDate, Account) values (@Name, @TableID, @Amount, @Discount, @Tax, @Status,@CheckoutDate, @Account)
	SELECT @id = SCOPE_IDENTITY()
end

drop procedure BillDetail_Update

create procedure BillDetail_Update
@ID int,
@BillId int,
@Quantity int
as
begin
	update BillDetails
	set Quantity = @Quantity
	where ID = @ID and InvoiceID = @BillId
end
go

drop procedure Amount_Update
create procedure Amount_Update
@ID int
as
begin
	UPDATE dbo.Bills 
	SET Amount = (	SELECT SUM(Food.Price*BillDetails.Quantity) 
					FROM dbo.BillDetails, dbo.Food 
					WHERE BillDetails.InvoiceID=Bills.ID and Food.ID = BillDetails.FoodID)
	where Bills.ID = @ID
end
go

create proc BillsStatus_Update
@ID int,
@Status bit
as
begin
	if(exists(select Name from [Bills] where ID = @ID))
		update [Bills]
		set Status = @Status
		where ID = @ID
end
go

SELECT AccountName,HashBytes('MD5', Password) as Password,FullName,Email,Tell,DateCreated
from Account

create procedure Password_Update
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200)
)
as
begin
	update Account
	set Password = @Pass
	where AccountName = @AccountName
end
go