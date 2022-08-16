create database roles
use roles

create table student(
Id int identity(1,1) primary key not null,
Name varchar(50),
Class varchar(10)

);

create table usert(
Id int identity(1,1) primary key not null,
Name varchar(50),
Pass varchar(10)

);

create table rolet(
Id int primary key identity(1,1) not null,
UserId int foreign key references usert(Id) ,
role varchar(50)

);

select * from student;
select * from usert;
select * from rolet;