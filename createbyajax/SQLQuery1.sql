create database Search
use Search

create table info
(
Id int identity(1,1) primary key not null,
Name nvarchar(50),
Class varchar(10),
Age varchar(10),
Contact varchar(50)


);

insert into info values('Umaima','2','7','0302');
insert into info values('Irha','3','8','0311');
insert into info values('Ramsha','4','9','0333');
insert into info values('Anaya','6','10','0344');
insert into info values('Zoha','5','9','0323');
insert into info values('Minhal','4','8','0345');
