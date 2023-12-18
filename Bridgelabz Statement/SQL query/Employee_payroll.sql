
--UC 1
Create database Payroll_Service;
 use Payroll_Service  

--UC 2
Create table employee_payroll(
id int primary key identity(1,1),
name varchar(30) NOT NULL,
salary varchar(30),
start_date date
);
 
--UC 3
Insert into employee_payroll values('A','1000','2018-01-01');
Insert into employee_payroll values('B','1100','2019-02-01');
Insert into employee_payroll values('C','1200','2018-03-01');
Insert into employee_payroll values('D','1300','2019-04-01');
Insert into employee_payroll values('E','1400','2018-05-01');

--UC 4
Select * from employee_payroll;

--UC 5
Select * from employee_payroll where name='B';
Select * from employee_payroll where start_date between CAST('2019-01-01' as Date) and GETDATE();
 
--UC 6
Alter table employee_payroll
Add Gender Char(1);

update employee_payroll set basic_pay =200  where id=9;
update employee_payroll set Gender ='F' where id=2;
update employee_payroll set Gender ='M' where id=3;
update employee_payroll set Gender ='F' where id=4;
update employee_payroll set Gender ='M' where id=5;

--UC7
Select sum(cast(salary as bigint))as sum from employee_payroll ; 
Select Avg(cast(salary as bigint))as avg from employee_payroll; 
Select min(cast(salary as bigint))as min from employee_payroll; 
Select max(cast(salary as bigint))as max from employee_payroll; 
Select gender,count(*) from employee_payroll group by(gender);

--UC8
	Alter table employee_payroll
	Add phone varchar(10), address varchar(30),department varchar(20); 

	--UC9
	alter table employee_payroll
	Add basic_pay bigint,deductions bigint, taxable_pay bigint,income_tax bigint,net_pay bigint;

	--UC10
	Insert into employee_payroll values('Terisa','2000','2019-01-01','F','6467356845','chennai','Sales',353,121,123,324,142);
	Insert into employee_payroll values('Terisa','2000','2019-01-01','F','6467356845','chennai','Marketing',353,121,123,324,142);

--Stored Procedures for the employee Payroll Table
create Procedure AddEmployeeDetails(
@name varchar(20),
@salary varchar(20),
@start_date date,
@gender char(1),
@phone varchar(10), 
@address varchar(30),
@department varchar(20),
@basic_pay bigint,
@deductions bigint,
@taxable_pay bigint,
@income_tax bigint,
@net_pay bigint 
)
As
begin insert Into employee_payroll values(@name,@salary,@start_Date,@gender,@phone,@address,@department,@basic_pay,@deductions,@taxable_pay,@income_tax,@net_pay)
End

create Procedure GetEmployeeDetails
As
Begin
Select * from employee_payroll
End

Create Procedure DeleteEmployee
(
@id int
)
As
Begin Delete from employee_payroll where id=@id
End

Create Procedure UpdateEmployeeDetails  
(
@id int,
@name varchar(20),
@salary varchar(20),
@start_date date,
@gender char(1),
@phone varchar(10), 
@address varchar(30),
@department varchar(20),
@basic_pay bigint,
@deductions bigint,
@taxable_pay bigint,
@income_tax bigint,
@net_pay bigint
)
as
begin 
update employee_payroll set Name=@name,salary=@salary,start_date=@start_Date,gender=@gender,phone=@phone,address=@address,department=@department,basic_pay=@basic_pay,deductions=@deductions,taxable_pay=@taxable_pay,income_tax=@income_tax,net_pay=@net_pay where id=@id
End

Create Procedure ParticularPeriod(
@start_date date
)
As
Begin
Select * from employee_payroll where start_date between CAST(@start_date as Date) and GETDATE();
End

Alter Procedure SumAvgMinMax
As
Begin
Select sum(cast(salary as bigint))as sum , 
Avg(cast(salary as bigint))as avg,
min(cast(salary as bigint))as min,
max(cast(salary as bigint))as max from employee_payroll; 
end


--UC11
Create table Salary(
Salid int primary key identity(1,1),
Salary bigint,
basic_pay bigint,
deductions bigint,
taxable_pay bigint,
income_Tax bigint,
net_pay bigint,
);
Insert into Salary values(1100,150,150,150,150,150);
Insert into Salary values(1200,200,200,200,200,200);
Insert into Salary values(1300,250,250,250,250,250);
Insert into Salary values(1400,300,300,300,300,300);
Insert into Salary values(2000,400,400,400,400,400);
Insert into Salary values(2000,400,400,400,400,400);


Create table Department(
deptid int primary key identity(1,1),
Dept_name varchar(20)
);
insert into Department values('Marketing');

Create table employee(
id int primary key identity(1,1),
name varchar(30),
start_date date,
start_date dateonly
phone varchar(10),
address varchar(30),
salid int Foreign Key References Salary(Salid)
);
Insert into employee values('B','2018-01-01','9876546128','chennai',2);
Insert into employee values('C','2019-01-01','9876456621','chennai',3);
Insert into employee values('D','2018-02-01','9873456634','chennai',4);
Insert into employee values('E','2019-07-01','9872355665','chennai',5);
Insert into employee values('Teresa','2018-01-10','9876525678','chennai',6);
Insert into employee values('Teresa','2018-01-10','9876546566','chennai',7); 

Create  table emp_department_mapping(
id int primary key identity(1,1),
empid int Foreign key References employee(id),
deptid int Foreign key references Department(deptid)
);

select * from Salary; 
select * from Department;
select * from employee;   
select * from emp_department_mapping;       

select * from employee
Inner join Salary on employee.salid= Salary.Salid
Inner join Department on Salary.salid = Department.deptid;  

Select e.*,d.* from employee e,Department d where e.id=d.deptid  and e.id=1;


Select Max(salary) as max_salary from Salary
select Min(salary) as min_salary from Salary
select Avg(salary) as Avg_salary from Salary
select Sum(salary) as Sum_salary from Salary