create database Management
use Management

create table Users
(
	username varchar(10) primary key,
	password varchar(255),
	type varchar(255) check(type in ('Accountant','Customer'))
)

create table Customer
(
	cid varchar(10) primary key,
	name nvarchar(255),
	phone varchar(255),
	address nvarchar(255),
	username varchar(10) Null,
	constraint FK_Customer_User foreign key (username) references Users (username)
)

create table Accountant
(
	aid varchar(10) primary key,
	name nvarchar(255),
	username varchar(10),
	constraint FK_Accountant_User foreign key (username) references Users (username)
)

create table Receipt
(
	rid varchar(10) primary key,
	cid varchar(10),
	total int,
	date Date,
	type varchar(255),
	constraint FK_Receipt_Customer foreign key (cid) references Customer (cid)
)

create table Product
(
	pid varchar(10) primary key,
	name nvarchar(255),
	stock int check(stock >=0),
	imported int,
	Image varchar(255),
	price int,
	category nvarchar(255),
	description nvarchar(255),
	slug varchar(255)
)

alter table Product
add constraint checkStock check(stock>=0)

create table Detail
(
	pid varchar(10),
	rid varchar(10),
	quantity int,
	primary key (pid,rid),
	constraint FK_Detail_Product foreign key (pid) references Product (pid),
	constraint FK_Detail_Receipt foreign key (rid) references Receipt (rid),
)


insert into Users values ('admin','123','Accountant')
insert into Users values ('TP333','321','Customer')

insert into Customer values ('C01','Tan Phat','0283946524','20 Ham Nghi District 1','TP333')
insert into Customer values ('C02','Quy','0283112414','20 Ham Nghi District 1',Null)

insert into Accountant values ('A01',N'Nguyễn Gia Khiêm','admin')

insert into Receipt values ('R01','C01',250000000,GETDATE(),'Import')
insert into Receipt values ('R02','C02',2500000,GETDATE(),'Export')

insert into Detail values ('P01','R01',20)
insert into Detail values ('P02','R02',0)
insert into Detail values ('P03','R01',30)
insert into Detail values ('P04','R02',40)
insert into Detail values ('P01','R02',10)
ProductDetail
select * from Detail

select * from Product where name =N'Bào tử nấm linh chi'

create proc receiptDetail
as 
select * 
from Receipt R
where R.rid in
(
	select Detail.rid 
	from Detail
	where Detail.quantity > 0
)

exec receiptDetail
create proc Import
as
select * from Product
where Product.pid in
(
	select Detail.pid
	from Detail
	where Detail.rid in 
	(
		select Receipt.rid
		from Receipt
		where Receipt.type = 'Import'
	)
)

exec Import


create proc Export
as
select * from Product
where Product.pid in
(
	select Detail.pid
	from Detail
	where Detail.rid in 
	(
		select Receipt.rid
		from Receipt
		where Receipt.type = 'Export'
	)
)

exec Export



insert into Product values (
	'P01',
	N'Bào tử nấm linh chi',
	20,
	100,
	'',
	690000,
	N'Linh Chi',
	N'Bào tử nấm linh chi là lớp phấn phủ trên bề mặt của tai nấm. Đây là thành phần quan trọng của nấm linh chi do có chứa hàm lượng chất dinh dưỡng cao. So cùng trọng lượng, bào tử nấm linh chi có thành phần dược chất cao hơn gấp vài chục lần so với tai nấm ',
	'bao-tu-nam-linh-chi'
)
insert into Product values (
	'P02',
	N'Nấm Lim Xanh Nông Lâm',
	50,
	150,
	'',
	3900000,
	N'Lim Xanh',
	N'Nấm Lim Xanh Nông Lâm là một loại nấm thuộc họ linh chi. Lúc ban đầu loại nấm này mọc trên thân cây lim xanh',
	'nam-lim-xanh-nong-lam-cao-cap'
)

insert into Product values (
	'P03',
	N'Nấm thượng hoàng',
	10,
	20,
	'',
	6100000,
	N'Thượng hoàng',
	N'Nấm thượng hoàng (nấm hoàng chi) hay còn có tên gọi là nấm Hoàng Sơn (Sang Hwang), tên khoa học Phellinus Linteus có nguồn gốc từ Hàn Quốc.',
	'nam-thuong-hoang-thuong-hang'
)

insert into Product values (
	'P04',
	N'Đông trùng hạ thảo Nông Lâm',
	100,
	200,
	'',
	5700000,
	N'Đông trùng hạ thảo',
	N'Đông trùng hạ thảo Nông Lâm được cấy giống và nuôi trồng bởi các chuyên gia của đại học Nông Lâm. Giống như đông trùng hạ thảo Tây Tạng, đông trùng hạ thảo nông lâm là một loại nấm ký sinh được mọc lên từ ấu trùng sâu.',
	'dong-trung-ha-thao-nong-lam'
)

insert into Product values (
	'P05', 
	N'Tổ yến sào Nông Lâm',
	100,
	300,
	'',
	4300000,
	N'Tổ yến sào',
	N'Yến là một món ăn sang trọng, mang lại những giá trị vô giá cho sức khỏe. Không cần thêm bất kỳ gia vị nào khi sử dụng với yến ,vì bản thân món yến đã được tôn vinh lên hàng cao lương mỹ vị. Tổ yến sào Nông Lâm được thu hoạch từ yến nuôi tự nhiên.',
	'to-yen-sao-nong-lam'
)


Update Product 
	Set category = N'Tổ yến sào Nông Lâm' where pid = 'P05'

Update Product 
	Set stock = stock + 10 where pid = 'P01'

delete Product
	where pid = 'P023'

delete Detail
	where rid = 'R01' and pid = 'P055'
	

select * from Product
select * from Detail

