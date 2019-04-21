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
--ALTER TABLE PERMISSION_DETAIL ADD FOREIGN KEY(id_Permission) REFERENCES PERMISSION(id_Permission)

ALTER TABLE BILL_INFO ADD FOREIGN KEY(id_Bill) REFERENCES BILL(id_Bill)
ALTER TABLE BILL_INFO ADD FOREIGN KEY(Id_nenu) REFERENCES MENU(Id_nenu)

ALTER TABLE MENU ADD FOREIGN KEY(id_Kind) REFERENCES KIND(id_Kind)
ALTER TABLE BILL ADD FOREIGN KEY(id_User) REFERENCES USER_ACCOUNT(id_User)
ALTER TABLE BILL ADD FOREIGN KEY(id_Room) REFERENCES ROOM(id_Room)

--INSERT DATABASE

--Insert to FOOD and Drink

insert into KIND values (1,N'Khô');
insert into KIND values (2,N'Trái Cây');
insert into KIND values (3,N'Các Loại SNACK');
insert into KIND values (4,N'Các Loại Bia');
insert into KIND values (5,N'Rựu');
insert into KIND values (6,N'Nước Ngọt');
insert into KIND values (7,N'Nước Suối');
insert into KIND values (8,N'Thuốc Lá');
insert into KIND values (9,N'Shisha');
insert into KIND values (10,N'Khác');


/* OPTION, you can insert them below or not :) 
--BIA
select * from MENU
insert into MENU values (N'Bia 333', 4, 12500, 100);
insert into MENU values (N'Bia Lager', 4, 10000, 100);
insert into MENU values (N'Bia Sư Tử Trắng', 4, 8000, 100);
insert into MENU values (N'Bia Tiger Nâu', 4, 14000, 100);
insert into MENU values (N'Bia Tiger Bạc', 4, 15000, 100);

--NUOC NGOT
insert into MENU values (N'Coca Cola', 6, 10000, 100);
insert into MENU values (N'Pepsi', 6, 10000, 100);
insert into MENU values (N'7 UP', 6, 12000, 100);
insert into MENU values (N'Warior', 6, 9000, 100);
insert into MENU values (N'Sting', 6, 10000, 100);

--NUOC SUOI
insert into MENU values (N'Aquafina', 7, 10000, 100);
insert into MENU values (N'Lavie', 7, 10000, 100);

--RUOU
insert into MENU values (N'Chivas', 5, 1000000, 100);
insert into MENU values (N'Red Wine', 5, 200000, 100);
insert into MENU values (N'Whiskey', 5, 2000000, 100);
insert into MENU values (N'Vodka', 5, 250000, 100);
insert into MENU values (N'Gin', 5, 1500000, 100);

--FOOD
insert into MENU values (N'Khô bò', 1, 50000, 100)
insert into MENU values (N'Khô mực', 1, 75000, 100)
insert into MENU values (N'Khô gà', 1, 30000, 100)

insert into MENU values (N'Táo', 2, 30000, 100)
insert into MENU values (N'Nho', 2, 50000, 100)
insert into MENU values (N'Xoài', 2, 50000, 100)

insert into MENU values (N'Snack Rong Biển', 3, 20000, 100)
insert into MENU values (N'Snack Khoai Tây', 3, 30000, 100)
insert into MENU values (N'Snack Tôm Rang', 3, 25000, 100)

*/
--PERMISSION
insert into PERMISSION values (1,'ADMIN')
insert into PERMISSION values (2,'STAFF')

--PERMISSION_DETAIL khong can xai`

--USER_ACCOUNT
insert into USER_ACCOUNT values ('quy', 'quy', 'Thanh Quy Vo', 1);
insert into USER_ACCOUNT values ( 'nv1', 'nv1', 'Nhan Vien 1', 2);

/*
----TIME TO TRY

select * from BILL where id_Room = 1 and sta = 0

select * from room where id_Room = 5 and status = 1



select m.name, k.name, bi.count_menu, m.unit_Price, m.unit_Price * bi.count_menu As ToMoney 
from BILL as b, BILL_INFO as bi, MENU as m, ROOM as r, KIND as k 
where bi.id_Bill = b.id_Bill and m.id_Kind = k.id_Kind and bi.Id_nenu = m.Id_nenu and r.id_Room = b.id_Room and r.status = 1 and r.id_Room = 1


select m.name, bi.count_menu, m.unit_Price, m.unit_Price * bi.count_menu As ThanhTien from BILL as b, BILL_INFO as bi, MENU as m, ROOM as r where bi.id_Bill = b.id_Bill and bi.Id_nenu = m.Id_nenu and r.id_Room = b.id_Room and r.status = 1 and r.id_Room = 1



select * from dbo.BILL where id_Room = 1 and payment_Status = 0 ;




select * from BILL

*/

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


/*
select *, DATEDIFF(MINUTE, time_In, GETDATE()) as timeUse from dbo.BILL where id_Room = 1

-----
select * from BILL
 */

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

/*
update BILL set time_Out = getdate(), payment_Status = 1 where id_Bill = 3

select * from bill

select * from BILL_INFO

select * from BILL where id_Room = 1 and payment_Status = 0  

select m.name, bi.count_menu, m.unit_Price, m.unit_Price * bi.count_menu As ToMoney 
from BILL as b, BILL_INFO as bi, MENU as m, ROOM as r 
where bi.id_Bill = b.id_Bill and bi.Id_nenu = m.Id_nenu and r.id_Room = b.id_Room and r.status = 1 and b.payment_Status = 0 and r.id_Room = 1


select *, DATEDIFF(MINUTE, time_In, GETDATE()) as timeUse from dbo.BILL where id_Room = 14 and payment_Status = 0



select * from PERMISSION


SELECT * FROM USER_ACCOUNT WHERE username = 'nv1' and password= 'nv1'

select * from MENU where Id_nenu = 18



insert into MENU values (N'Kho Dog', 1, 1000, 0);
update menu set amout = amout + 1 where Id_nenu = 31


delete from BILL_INFO
delete from bill

update BILL set time_Out = getdate(), payment_Status = 1, discount = 5 where id_Bill = 2




select * as time_Use from bill 

select * from BILL

select b.id_Bill,r.name, b.time_In, b.time_Out,DATEDIFF(MINUTE, b.time_In, b.time_Out) as time_Use, DATEDIFF(MINUTE, b.time_In, b.time_Out) / 60.0 * r.price as room_Fee, b.discount
from bill as b, ROOM as r
where payment_Status = 1 and b.id_Room = r.id_Room

--thoi truy van kho qua khong lam nua :)))



--(and time_In between '2019-04-02' and '2019-04-02 23:59:59') --chuan roi
select b.id_Bill,r.name, b.time_In, b.time_Out,DATEDIFF(MINUTE, b.time_In, b.time_Out) as time_Use, room_Fee,service_Fee, b.discount, (room_Fee + service_Fee) + (((room_Fee + service_Fee) * 0.1) - (((room_Fee + service_Fee) + ((room_Fee + service_Fee) * 0.1)) * discount) / 100.0)  as total_money from bill as b, ROOM as r where payment_Status = 1 and b.id_Room = r.id_Room and time_In between '2019/4/07' and '2019/4/07 23:59:59'

select * from menu
select *, unit_Price * amout as total
from MENU
group by Id_nenu, name, id_Kind, unit_Price, amout




--lay ra phong gan nhat duoc thanh toan gan day:
select m.name, bi.count_menu, m.unit_Price, m.unit_Price * bi.count_menu As ToMoney 
from BILL as b, BILL_INFO as bi, MENU as m, ROOM as r 
where bi.id_Bill = b.id_Bill and bi.Id_nenu = m.Id_nenu and r.id_Room = b.id_Room and b.payment_Status = 1 and b.id_Bill = (select max(id_Bill) from BILL where payment_Status =1)
and r.id_Room = 1

select * from room




select * from bill_info
select * from MENU where Id_nenu = 1

*/

/*

select m.name, bi.count_menu, m.sale_price, m.sale_price * bi.count_menu As ToMoney 
from BILL as b, BILL_INFO as bi, MENU as m, ROOM as r 
where bi.id_Bill = b.id_Bill and bi.Id_nenu = m.Id_nenu and r.id_Room = b.id_Room and r.status = 1 and b.payment_Status = 0 and r.id_Room = 1
 


 select b.id_Bill,r.name, b.time_In, b.time_Out,DATEDIFF(MINUTE, b.time_In, b.time_Out) as time_Use, room_Fee,service_Fee, b.discount, (room_Fee + service_Fee) + (((room_Fee + service_Fee) * 0.1) - (((room_Fee + service_Fee) + ((room_Fee + service_Fee) * 0.1)) * discount) / 100.0)  as total_money 
 from bill as b, ROOM as r 
 where payment_Status = 1 and b.id_Room = r.id_Room and time_In between '04/19/2019' and '04/19/2019 23:59:59'

 


select r.name, m.name, bi.count_menu, (m.original_Price *  bi.count_menu) as total_original_Price, (m.sale_Price *  bi.count_menu) as total_sale_Price, ((m.sale_Price *  bi.count_menu) - (m.original_Price *  bi.count_menu)) as revenue 
from BILL_INFO as bi, BILL as b, MENU as m, ROOM as r 
where b.id_Bill = bi.id_Bill and r.id_Room = b.id_Room and bi.Id_nenu = m.Id_nenu and b.payment_Status = 1 and time_In between '04/24/2019' and '04/19/2019 23:59:59'



select u.id_User, u.username, u.password, u.nameUser, p.name_Permission from USER_ACCOUNT AS u, PERMISSION as p where u.id_Permission = p.id_Permission


update USER_ACCOUNT
set password = 'de5a455a650a3c610ee7db2b3527ecd9'
where username = 'quy'

select * from USER_ACCOUNT

*