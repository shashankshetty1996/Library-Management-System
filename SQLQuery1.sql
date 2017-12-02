create Database library;
use library;

drop table books;

create table books(
bnum int,
bname varchar(25),
authorName varchar(25),
numberOfCopies int,
primary key(bnum));

insert into books values(1,'OPERATING SYSTEM','JOHANNES CLARKE',12);
insert into books values(2,'DATABASE MANAGEMENT','JEFFERY ULLMAN',9);
insert into books values(3,'ADVANCED UNIX','KENNETH ALYA',6);
select * from books;

create table login
(uname varchar(25),
pwd varchar(32),
post varchar(15),
permission varchar(15),
primary key(uname));

insert into login values('admin','adminuser','librarian','admin');
insert into login values('Divakara Bhat','nittelibaray','librarian','admin');
insert into login values('shashank','12345','librarian','admin');
select * from login;

create table studentliblogin(
stduserid varchar(25),
stdname varchar(25),
stdpassword varchar(25),
borrow int Default(0),
primary key(stduserid)
);

insert into studentliblogin values('4NM14CS147','SHASHANK','4NM14CS147',0);
insert into studentliblogin values('4NM14CS101','NIGEL','4NM14CS101',0);
insert into studentliblogin values('ADMIN','ADMIN','ADMIN',0);
select * from studentliblogin;

create table leactureliblogin(
luserid varchar(25),
lname varchar(25),
lpassword varchar(25),
borrow int Default(0),
primary key(luserid)
);
insert into leactureliblogin values('12CSE05','PAWAN','rdbms',0);
insert into leactureliblogin values('16CSE05','RAJASHREE','rdbms',0);

select * from leactureliblogin;

create table borrowbook(
userid varchar(25),
username varchar(25),
bid int,
bname varchar(25),
aname varchar(25)
);

drop table borrowbook
insert into borrowbook values('ADMIN','ADMIN',1,'OPERATING SYSTEM','JOHANNES CLARKE');
select * from borrowbook;

select stdname from studentliblogin where borrow > 5;

delete from borrowbook where username='ADMIN' 