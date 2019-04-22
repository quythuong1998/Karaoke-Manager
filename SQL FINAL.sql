CREATE DATABASE KARAOKE_MANAGER
GO
USE KARAOKE_MANAGER;


CREATE TABLE USER_ACCOUNT
(
	id_User int identity(1,1) PRIMARY KEY,
	username nvarchar(50) not null,
	password nvarchar(50),
	nameUser nvarchar(100),
	id_Permission int
)

CREATE TABLE PERMISSION
(
	id_Permission int PRIMARY KEY,
	name_Permission nvarchar(10)
)


CREATE TABLE ROOM
(
	id_Room int identity(1,1) PRIMARY KEY,
	name nvarchar(10),
	status int,
	kind_Of_Room int, -- 0: nornal  1:vip
	price float
)

CREATE TABLE BILL
(
	id_Bill int identity(1,1) PRIMARY KEY,
	time_In datetime not null default getdate(),
	time_Out datetime,
	payment_Status int DEFAULT 0,
	discount int DEFAULT 0,
	service_Fee float,
	room_Fee float,
	id_Room int,
	id_User int
)

CREATE TABLE BILL_INFO
(
	id_Bill_Info int identity(1,1) PRIMARY KEY,
	id_Bill int,
	Id_nenu int,
	count_menu int
)

CREATE TABLE MENU
(
	Id_nenu int identity(1,1) PRIMARY KEY,
	name nvarchar(50),
	id_Kind int,
	original_Price float,
	sale_Price float,
	amout int
)


CREATE TABLE KIND
(
	id_Kind int PRIMARY KEY,
	name nvarchar(50)
)	

-- Insert Primary key: 

ALTER TABLE USER_ACCOUNT ADD FOREIGN KEY(id_Permission) REFERENCES PERMISSION(id_Permission)
ALTER TABLE BILL_INFO ADD FOREIGN KEY(id_Bill) REFERENCES BILL(id_Bill)
ALTER TABLE BILL_INFO ADD FOREIGN KEY(Id_nenu) REFERENCES MENU(Id_nenu)
ALTER TABLE MENU ADD FOREIGN KEY(id_Kind) REFERENCES KIND(id_Kind)
ALTER TABLE BILL ADD FOREIGN KEY(id_User) REFERENCES USER_ACCOUNT(id_User)
ALTER TABLE BILL ADD FOREIGN KEY(id_Room) REFERENCES ROOM(id_Room)

--INSERT DATABASE

--Insert to FOOD and Drink

insert into KIND values (1,N'Khô');
insert into KIND values (2,N'Trái Cây');
insert into KIND values (3,N'SNACK');
insert into KIND values (4,N'Bia');
insert into KIND values (5,N'Rựu');
insert into KIND values (6,N'Nước Ngọt');
insert into KIND values (7,N'Nước Suối');
insert into KIND values (8,N'Thuốc Lá');
insert into KIND values (9,N'Shisha');
insert into KIND values (10,N'Khác');

--PERMISSION
insert into PERMISSION values (1,'ADMIN')
insert into PERMISSION values (2,'STAFF')

--USER_ACCOUNT
insert into USER_ACCOUNT values ('admin', '21232f297a57a5a743894a0e4a801fc3', 'Administrator', 1);

GO
create PROCEDURE Proc_addBill
(@idRoom int)
as
begin
		insert dbo.BILL(time_In, time_Out, id_Room, payment_Status, discount, room_Fee, service_Fee) values (getdate(), null, @idRoom, 0, 0, null, null)
end
		

--Procedure them du lieu vao BILL_INFO
GO
create proc Proc_addBillInfo
@idBill int , @idMenu int, @count int
as
begin
		declare @checkExistOfBillInfo int
		declare @_count int = 1
		
		--3line nay them vao cai co san~
		select @checkExistOfBillInfo = id_Bill_Info, @_count = bi.count_menu 
		from dbo.BILL_INFO as bi
		where id_Bill = @idBill and Id_nenu  = @idMenu
		

		if(@checkExistOfBillInfo > 0)
		begin 
			declare @newCount int = @_count + @count
			if(@newCount > 0)
				update dbo.BILL_INFO set count_menu =  @_count + @count where Id_nenu = @idMenu
				 --tru vao so luong hien tai
			else
				delete dbo.BILL_INFO where id_Bill = @idBill and Id_nenu = @idMenu
				update dbo.MENU set amout = amout - @count where Id_nenu = @idMenu -- cong vao trong kho neu nhu bot lai thuc an cua room (- (-) -> +)
		end
		else
			begin
				insert dbo.BILL_INFO(id_Bill, Id_nenu, count_menu) values (@idBill, @idMenu, @count)
				update dbo.MENU set amout = amout - @count where Id_nenu = @idMenu --tru di so luong trong kho
			end
end
go 


--Trigger update tinh trang phong khi Add BILL_INFO
go
create trigger Trig_TriggerUpdateBillInFo 
on dbo.BILL_INFO for insert, update
as
begin
	declare @idBill int 
	select @idBill = id_Bill from inserted

	declare @idRoom int
	select @idRoom = id_Room from dbo.BILL where id_Bill = @idBill and payment_Status = 0

	update dbo.ROOM set status = 1 where id_Room = @idRoom 
end


GO
create trigger Trigger_updateBill --trigger xay ra khi update mot hoa don
on BILL for update
as
begin
	declare @idBill int
	select @idBill = id_Bill from inserted

	--declare @soluong int

	declare @idRoom int
	select @idRoom = id_Room from dbo.BILL where id_Bill = @idBill

	declare @count int = 0
	select @count = count(*) from dbo.BILL where id_Room = @idRoom and payment_Status = 0
	
	if(@count = 0)
		update dbo.ROOM set status = 0 where id_Room = @idRoom
end

