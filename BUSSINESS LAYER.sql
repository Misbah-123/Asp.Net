Create database Company_

Use Company_;

create table info
(
Id int identity(1,1) primary key not null,
Name nvarchar(50),
Des varchar (10),
Salary int
);

insert into info values ('Umaima' , 'Faculty' , 30000);
insert into info values ('Irha' , 'CEO' , 50000);
insert into info values ('Ramsha' , 'CLO' , 340000);
insert into info values ('Sobia' , 'CMO' , 35000);
insert into info values ('Maryam' , 'CFO' , 78000);
insert into info values ('Fatima' , 'Faculty' ,780000);
insert into info values ('Aqsa' , 'Faculty' , 30000);
insert into info values ('Arbish' , 'CEO' , 90000);
insert into info values ('Anabia' , 'Faculty' , 30000);
insert into info values ('Ayeza' , 'CLO' , 100000);

select * from info;