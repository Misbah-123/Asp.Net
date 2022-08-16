create database image
use image

create table img_table(
id int identity(1,1) not null primary key ,
name nvarchar(50),
city nvarchar(50),
img nvarchar(500)


);
select * from img_table
