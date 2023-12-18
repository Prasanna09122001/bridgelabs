Create Database Example;

Use Example;

Create table Sample(
Id int not null,
Name varchar(30) not null,
Email varchar(30) null,
Phonenumber varchar(10) null
);

Insert into Sample(Id,Name,Email,Phonenumber) values(1,'Prasanna','pras@gmail.com','6369988552');
Insert into Sample values(2,'Shrey','shrey@gmail.com','6369988552');
Insert into Sample(Id,Name,Email,Phonenumber) values(3,'Nithin','nithin@gmail.com','6369988552');
Insert into Sample(Id,Name,Email,Phonenumber) values(4,'Naren','naren@gmail.com','6369988552');
Insert into Sample(Id,Name,Email,Phonenumber) values(5,'mukesh','mukesh@gmail.com','6369988552');

select * from Sample; 

Select * from Sample where Id=2;
Select * from Sample where Id in(2,3);
select Name,Phonenumber from sample where Id=2;
select * from sample where phonenumber = '6369988552';

update sample set Name = 'Prasanna' where id = 1;

delete from sample where id=2;


Create table name(
id int primary key identity(1,1),
name varchar(10),
phonenumber varchar(10)
);


create table address(
city varchar(10),
state varchar(10),
id int foreign key references Name(id)
);

Insert into name values('Prasana','534892');
Insert into address values('chennai','TamilNadu',1);
Insert into name values('venkatesh','45784');
Insert into address  values('venkatesh','TamilNadu',2);

select * from name;
select * from address;


select * from name
Inner join address on name.name =address.city;


select *
from name a, name b 
where a.id = b.id;
