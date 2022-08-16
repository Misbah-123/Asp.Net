create database fileuploading;
 create table upload
 (
 
 Id int identity(1,1) primary key not null,
 Name varchar(50),
 Contact varchar(20),
 Age varchar(10),
 CV nvarchar(500)
 
 
 
 );
 select *from upload