create database stud;
use stud;
create table studinfo1(
ID int identity(1,1) not null primary key,
Name varchar(40),
Email varchar(50),
Mobile int
)
insert into studinfo1  values('Laiba','laiba@gmail.com',0302)
insert into studinfo1  values('Laiba','laiba@gmail.com',0302)
insert into studinfo1  values('Laiba','laiba@gmail.com',0302)

select * from studinfo1
