Create database MISDB;

Use MISDB;

CREATE TABLE hired_candidates ( 
  Id int NOT NULL Primary Key,
  First_Name varchar(100) NOT NULL,
  Middle_Name varchar(100) DEFAULT NULL,
  Last_Name varchar(100) NOT NULL,
  Email varchar(50) NOT NULL,
  Mobile_Num bigint NOT NULL,
  Hired_City varchar(50) NOT NULL,
  Hired_Date datetime NOT NULL,
  Degree varchar(100) NOT NULL,
  Aggregate_Per float DEFAULT NULL,
  Current_Pincode int DEFAULT NULL,
  Permanent_Pincode int DEFAULT NULL,
  Hired_Lab varchar  DEFAULT NULL,
  Attitude_Remark varchar(15) DEFAULT NULL,
  Communication_Remark varchar(15) DEFAULT NULL,
  Knowledge_Remark varchar(15) DEFAULT NULL,
  Status varchar  NOT NULL,
  Creator_Stamp datetime DEFAULT NULL,
  Creator_User int DEFAULT NULL,
);
Insert Into hired_candidates Values(1, 'deepak', 'Kiran', 'Patil', 'deepak.63584@gmail.com ',8956748596, 'Pune','2019-12-13','B.E' , 75.25,5245,5478,'Mumbai', 'Good', 'Good','Good','Good', null,1);
Insert into hired_candidates values(2, 'John', 'A', 'Doe', 'john.doe@example.com', 9876543210, 'New York', '2023-01-01', 'B.Sc', 78.5, 10001, 10001, 'Lab A', 'Good', 'Excellent', 'Excellent', 'Hired', '2023-09-26 09:00:00', 2)
Insert into hired_Candidates values(3, 'Michael', 'Bond', 'Smith', 'michael.smith@example.com', 9876543212, 'Los Angeles', '2023-02-10', 'PhD', 92.0, 90003, 90003, 'Lab C', 'Excellent', 'Good', 'Excellent', 'Hired', '2023-09-26 11:45:00', 3)
Insert Into hired_candidates values(4, 'William', 'D', 'Brown', 'william.brown@example.com', 9876543214, 'Houston', '2023-04-20', 'B.Tech', 80.0, 77005, 77005, 'Lab B', 'Good', 'Good', 'Good', 'Hired', '2023-09-26 14:15:00', 1)
Insert into hired_candidates values(5, 'James', 'F', 'Anderson', 'james.anderson@example.com', 9876543216, 'Miami', '2023-06-10', 'B.Com', 75.5, 33007, 33007, 'Lab A', 'Good', 'Good', 'Good', 'Hired', '2023-09-26 16:45:00', 3)

Create TABLE fellowship_candidates (
  id int NOT NULL Primary Key,
  first_name varchar(100) NOT NULL,
  middle_name varchar(100) DEFAULT NULL,
  last_name varchar(100) NOT NULL,
  email varchar(50) NOT NULL,
  mobile_num bigint NOT NULL,
  hired_city varchar(50) NOT NULL,
  hired_date datetime NOT NULL,
  degree varchar(50) NOT NULL,
  aggr_per float Default Null ,
  current_pincode int DEFAULT NULL,
  permanent_pincode int DEFAULT NULL,
  hired_lab varchar(20) DEFAULT NULL,
  attitude_remark varchar(15) DEFAULT NULL,
  communication_remark varchar(15) DEFAULT NULL,
  knowledge_remark varchar(15) DEFAULT NULL,
  birth_date date NOT NULL,
  is_birth_date_verified int DEFAULT 0,
  parent_name varchar(50) DEFAULT NULL,
  parent_occupation varchar(100) NOT NULL,
  parent_mobile_num bigint NOT NULL,
  parent_annual_sal float DEFAULT NULL,
  local_addr varchar(255) NOT NULL,
  permanent_addr varchar(150) DEFAULT NULL,
  photo_path varchar(500) DEFAULT NULL,
  joining_date date DEFAULT NULL,
  candidate_status varchar(20) NOT NULL,
  personal_info_filled int   DEFAULT 0,
  bank_info_filled int  DEFAULT 0,
  educational_info_filled int DEFAULT 0,
  doc_status varchar(20) DEFAULT NULL,
  remark varchar(150) DEFAULT NULL,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL
) 
Insert Into fellowship_candidates Values(1, 'deepak', 'Kiran', 'Patil', 'deepak.63584@gmail.com ',8956748596, 'Pune','2019-12-13','B.E' , 75.25,5245,5478,'Mumbai', 'Good', 'Good' , 'Good', '1999-12-13', 1, 'Kiran', 'Farmer' , 7584962547, 300000, 'Pune', 'Pune' , 'photo_path', '2019-12-13', 'Good',1, 1, 1, 'Correct', 'Good', null,1);
Insert Into fellowship_candidates Values(2, 'John', 'A', 'Doe', 'john.doe@example.com', 9876543210, 'New York', '2023-01-01', 'B.Sc', 78.5, 10001, 10001, 'Lab A', 'Good', 'Excellent', 'Excellent', '1999-12-13', 1, 'Emily', 'Driver' , 9898767656, 450000, 'Punjab', 'Punjab' , 'photo_path2', '2019-12-13', 'Good',1, 1, 1, 'Correct', 'Good', null,1);
Insert Into fellowship_candidates Values(3, 'Michael', 'Bond', 'Smith', 'michael.smith@example.com', 9876543212, 'Los Angeles', '2023-02-10', 'PhD', 92.0, 90003, 90003, 'Lab C', 'Excellent', 'Good', 'Excellent', '1999-10-13', 1, 'Ava', 'Farmer' , 9234323456, 350000, 'Chennai', 'Chennai' , 'photo_path3', '2019-10-13', 'Good',1, 1, 1, 'Correct', 'Good', null,1);
Insert Into fellowship_candidates Values(4, 'William', 'D', 'Brown', 'william.brown@example.com', 9876543214, 'Houston', '2023-04-20', 'B.Tech', 80.0, 77005, 77005, 'Lab B', 'Good', 'Good', 'Good', '2001-01-13', 1, 'William', 'Engineeer' , 9867654456, 500000, 'Bangalore', 'Bangalore' , 'photo_path4', '2019-01-13', 'Good',1, 1, 1, 'Correct', 'Good', null,1);
Insert Into fellowship_candidates Values(5, 'James', 'F', 'Anderson', 'james.anderson@example.com', 9876543216, 'Miami', '2023-06-10', 'B.Com', 75.5, 33007, 33007, 'Lab A', 'Good', 'Good', 'Good', '1998-07-13', 1, 'Lucas', 'Doctor' , 6787898973, 900000, 'Mumbai', 'Mumbai' , 'photo_path5', '2019-12-10', 'Good',1, 1, 1, 'Correct', 'Good', null,1);

Create TABLE candidates_personal_det_check(
Id int NOT NULL,
candidate_id int NOT NULL,
field_name int NOT NULL,
is_verified int DEFAULT NULL,
lastupd_stamp datetime DEFAULT NULL,
lastupd_user int DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL
)
Insert Into candidates_personal_det_check values(1, 1, 1, 1, '2020-01-01 10:00:00', 0, '2020-01-01 11:00:00', 1)
Insert Into candidates_personal_det_check values(2, 2, 2, 0, NULL, NULL, '2023-09-26 09:30:00', 2)
Insert Into candidates_personal_det_check values(3, 3, 2, 1, '2023-09-26 13:00:00', 3, '2023-09-26 12:00:00', 4)
Insert Into candidates_personal_det_check values(4, 4, 1, 1, '2023-09-26 15:00:00', 4, '2023-09-26 14:00:00', 3)
Insert Into candidates_personal_det_check values(5, 5, 3, 0, NULL, NULL, '2023-09-26 13:30:00', 1)
Select * from candidates_personal_det_check

CREATE TABLE candidate_bank_det(
id int NOT NULL Primary Key,
candidate_id int NOT NULL,
CONSTRAINT FK_candidate_bank_det_candidate_id FOREIGN KEY (candidate_id)REFERENCES fellowship_candidates (id),
name varchar(100) NOT NULL,
account_num bigint NOT NULL,
is_account_num_verified int DEFAULT 0,
ifsc_code varchar(20) NOT NULL,
is_ifsc_code_verified int DEFAULT 0,
pan_number varchar(10) DEFAULT NULL,
is_pan_number_verified int DEFAULT 0,
addhaar_num bigint NOT NULL,
is_addhaar_num_verified int DEFAULT 0,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
)
Insert Into candidate_bank_det Values(1, 1, 'deepak Patil', 1234567890, 1, 'ABCD123456', 1, 'ABCPD1234X', 1, 9876543210, 1, '2023-09-26 10:00:00', 2)
Insert Into candidate_bank_det Values(2, 2, 'John Doe', 2345678901, 0, 'EFGH234567', 1, NULL, 0, 8765432109, 1, '2023-09-26 10:30:00', 2)
Insert Into candidate_bank_det Values (3, 3, 'Michael Smith', 3456789012, 1, 'IJKL345678', 1, 'IJKPE4567Y', 1, 7654321098, 1, '2023-09-26 11:00:00', 3)
Insert Into candidate_bank_det Values (4, 4, 'William Brown', 4567890123, 0, 'MNOP456789', 1, NULL, 0, 6543210987, 1, '2023-09-26 11:30:00', 2)
Insert Into candidate_bank_det Values  (5, 5, 'James Anderson', 5678901234, 1, 'QRST567890', 1, 'QRSTP5678Z', 1, 5432109876, 1, '2023-09-26 12:00:00', 3)

CREATE TABLE candidates_bank_det_check 
id int NOT NULL,
candidate_id int NOT NULL,
field_name int NOT NULL,
is_verified int DEFAULT NULL,
lastupd_stamp datetime DEFAULT NULL,
lastupd_user int DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL
);
Insert Into candidates_bank_det_check values(1, 1, 1, 1, '2020-01-01 10:00:00', 0, '2020-01-01 11:00:00', 1)
Insert Into candidates_bank_det_check values(2, 2, 2, 0, NULL, NULL, '2023-09-26 09:30:00', 2)
Insert Into candidates_bank_det_check values(3, 3, 2, 1, '2023-09-26 13:00:00', 3, '2023-09-26 12:00:00', 4)
Insert Into candidates_bank_det_check values(4, 4, 1, 1, '2023-09-26 15:00:00', 4, '2023-09-26 14:00:00', 3)
Insert Into candidates_bank_det_check values(5, 5, 3, 0, NULL, NULL, '2023-09-26 13:30:00', 1)

CREATE TABLE candidate_qualification(
id int NOT NULL primary key,
candidate_id int NOT NULL,
CONSTRAINT FK_candidate_qual_candidate_id FOREIGN KEY (candidate_id) REFERENCES
fellowship_candidates (id),
diploma int DEFAULT 0,
degree_name varchar(10) NOT NULL,
is_degree_name_verified int DEFAULT 0,
employee_decipline varchar(100) NOT NULL,
is_employee_decipline_verified int DEFAULT 0,
passing_year int NOT NULL,
is_passing_year_verified int  DEFAULT 0,
aggr_per float DEFAULT NULL,
final_year_per float DEFAULT NULL,
is_final_year_per_verified int DEFAULT 0,
training_institute varchar(20) NOT NULL,
is_training_institute_verified int DEFAULT 0,
training_duration_month int DEFAULT NULL,
is_training_duration_month_verified int DEFAULT 0,
other_training varchar(255) DEFAULT NULL,
is_other_training_verified int DEFAULT 0,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
)
INSERT INTO candidate_qualification VALUES (1, 1, 0, 'B.E', 1, 'Computer Science', 1, 2020, 1, 78.5, 75.0, 1, 'ABC Institute', 1, 12, 1, 'Java Programming', 1, '2023-09-26 10:00:00', 1)
INSERT INTO candidate_qualification VALUES (2, 2, 1, 'B.Sc', 0, 'Physics', 1, 2019, 1, 68.0, 67.5, 0, 'XYZ College', 1, 24, 1, 'Chemistry Lab Skills', 1, '2023-09-26 10:30:00', 2)
INSERT INTO candidate_qualification VALUES (3, 3, 0, 'MBA', 1, 'Business Administration', 1, 2021, 1, 85.0, 83.5, 1, 'MNO University', 1, 18, 1, 'Leadership Training', 1, '2023-09-26 11:00:00', 3)
INSERT INTO candidate_qualification VALUES (4, 4, 1, 'M.Sc', 0, 'Chemistry', 1, 2022, 1, 72.5, 70.0, 0, 'PQR Institute', 1, 36, 1, 'Lab Management', 1, '2023-09-26 11:30:00', 4)
INSERT INTO candidate_qualification VALUES (5, 5, 0, 'B.Tech', 1, 'Electrical Engineering', 1, 2019, 1, 76.0, 74.5, 1, 'LMN College', 1, 24, 1, 'Embedded Systems', 1, '2023-09-26 12:00:00', 5)

CREATE TABLE candidates_education_det_check (
id int NOT NULL,
candidate_id int  NOT NULL,
field_name int NOT NULL,
is_verified int DEFAULT NULL,
lastupd_stamp datetime DEFAULT NULL,
lastupd_user int DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL
);
Insert Into candidates_education_det_check values(1, 1, 1, 1, '2020-01-01 10:00:00', 0, '2020-01-01 11:00:00', 1)
Insert Into candidates_education_det_check values(2, 2, 2, 0, NULL, NULL, '2023-09-26 09:30:00', 2)
Insert Into candidates_education_det_check values(3, 3, 2, 1, '2023-09-26 13:00:00', 3, '2023-09-26 12:00:00', 4)
Insert Into candidates_education_det_check values(4, 4, 1, 1, '2023-09-26 15:00:00', 4, '2023-09-26 14:00:00', 3)
Insert Into candidates_education_det_check values(5, 5, 3, 0, NULL, NULL, '2023-09-26 13:30:00', 1)

CREATE TABLE user_details (
id int NOT NULL primary key,
email varchar(50) NOT NULL,
first_name varchar(100) NOT NULL,
last_name varchar(100) NOT NULL,
password varchar(15) NOT NULL,
contact_number bigint NOT NULL,
verified bit DEFAULT NULL,
Constraint AK_TransactionID UNIQUE(Email)
);
INSERT INTO user_details VALUES (1, 'deepak.63584@gmail.com', 'deepak', 'patil', 'deepak', 8956748596, 1)
INSERT INTO user_details VALUES (2, 'john.doe@example.com', 'John', 'doe', 'John', 987654321, 1)
INSERT INTO user_details VALUES (3, 'michael.smith@example.com', 'Michael', 'Smith', 'Micheal', 9876543212, 0)
INSERT INTO user_details VALUES (4, 'william.brown@example.com', 'William', 'Brown', 'William', 9876543214, 1)
INSERT INTO user_details VALUES (5, 'james.anderson@example.com', 'James', 'Anderson', 'James', 9876543216, 0)

CREATE TABLE user_roles (
user_id int  NOT NULL ,
role_name varchar(100)
)
INSERT INTO user_roles VALUES (1, 'Manager')
INSERT INTO user_roles VALUES (2, 'Developer')
INSERT INTO user_roles VALUES(3, 'Supervisor')
INSERT INTO user_roles VALUES (4, 'Analyst')
INSERT INTO user_roles VALUES (5, 'Designer')

Select * from hired_candidates
select * from fellowship_candidates
select * from candidates_personal_det_check
select * from candidate_bank_det
select * from candidates_bank_det_check
select * from candidate_qualification
select * from candidates_education_det_check
select * from user_details
select * from user_roles

--27/09/2023
CREATE TABLE company(
id int NOT NULL Primary key,
name varchar(20) NOT NULL,
address varchar(150) DEFAULT NULL,
location varchar(50) DEFAULT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL
)
Insert into company values (1,'Amazon','Chennai','Chennai',1,'01-01-2020',1);
Insert into company values (2,'Flipkart','Mumbai','Mumbai',1,'01-06-2015',2);
Insert into company values (3,'Ajio','Delhi','Delhi',1,'01-01-2021',4);
Insert into company values (4,'Google','Chennai','Chennai',1,'08-15-2020',5);
Insert into company values (5,'Microsoft','Bangalore','Bangalore',1,'10-01-2008',1);

CREATE TABLE tech_type (
id int NOT NULL primary key,
type_name varchar(50) NOT NULL,
cur_status char(1) DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL
)
Insert into tech_type values(1,'Hp Laptap','A','09-12-2000',1)
Insert into tech_type values(2,'Dell Laptap','B','01-04-2010',2)
Insert into tech_type values(3,'Hp Desktop','C','12-30-2001',3)
Insert into tech_type values(4,'Dell Desktop','D','01-26-2010',4)
Insert into tech_type values(5,'Apple Laptap','E','05-01-2015',5)
Select * from tech_type

CREATE TABLE tech_stack (
id int NOT NULL primary key,
tech_name varchar(50) NOT NULL,
image_path varchar(500) DEFAULT NULL,
framework text DEFAULT NULL,
cur_status char(1) DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL
)
Insert into tech_stack values(1,'Web Development','image-1','html,css,js','A','2023-06-10',1);
Insert into tech_stack values(2,'Mobile App Development','image-2','React native','B','2023-01-15',2);
Insert into tech_stack values(3,'DataBase Management','image-3','Sql,Mongodb','C','2023-04-25',3);
Insert into tech_stack values(4,'Machine Learning','image-4','Python','D','2023-01-29',4);
Insert into tech_stack values(5,'Cloud Computing','image-5','AWS,Azure','E','2023-03-31',5);

CREATE TABLE maker_program(
id int NOT NULL primary key,
program_name varchar(10) NOT NULL,
program_type varchar(10) DEFAULT NULL,
program_link text DEFAULT NULL,
tech_stack_id int DEFAULT NULL,
tech_type_id int NOT NULL,
is_program_approved int,
description varchar(500) DEFAULT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
CONSTRAINT FK_maker_program_tech_stack_id FOREIGN KEY (tech_stack_id) REFERENCES tech_stack(id),
CONSTRAINT FK_maker_program_tech_type_id FOREIGN KEY (tech_type_id) REFERENCES tech_type (id),
)
Insert into maker_program values (1,'webinar','Webinar','hhttps;//webinar.com',2,3,1,'Explain Technology in Webinar',1,'09-27-2023',1)
Insert into maker_program values (2,'workshop','Workshop1','https://workshop.com',1,5,1,'Hands on Experience in Workshop',1,'06-15-2023',2)
Insert into maker_program values (3,'Hackathan','hackathan','https://hackathan.com',3,5,1,'Prctice coding in hackathan',1,'01-23-2023',3)
Insert into maker_program values (4,'SkillRack','SkillRack','https://Skillrack.com',1,2,1,'Practice coding in skillrack',1,'02-01-2023',4)
Insert into maker_program values (5,'Udemy','Udemy','https://Udemy.com',5,1,1,'Learn About the Technology',1,'09-20-2023',5)

Select * from maker_program;

CREATE TABLE lab(
id int NOT NULL PRIMARY KEY,
name varchar(50) DEFAULT NULL,
location varchar(50) DEFAULT NULL,
address varchar(255) DEFAULT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
)
Insert into Lab values(1,'Lab1','Chennai','Chennai',1,'01-01-2020',1)
Insert into Lab values(2,'Lab2','Delhi','Delhi',1,'01-01-2020',2)
Insert into Lab values(3,'Lab3','Pune','Pune',1,'01-01-2020',3)
Insert into Lab values(4,'Lab4','Bangalore','Bangalore',1,'01-01-2020',4)
Insert into Lab values(5,'Lab5','Mysore','Mysore',1,'01-01-2020',5)

CREATE TABLE app_parameters (
id int NOT NULL,
key_type varchar(20) NOT NULL,
key_value varchar(20) NOT NULL,
key_text varchar(80) DEFAULT NULL,
cur_status char(1) DEFAULT NULL,
lastupd_user int DEFAULT NULL,
lastupd_stamp datetime DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
seq_num int DEFAULT NULL,	
)
Insert into app_parameters values(1,'Type A','Value1','Text for value1','A',1001,'01-01-2020','01-01-2020',1001,1);
Insert into app_parameters values(2,'Type B','Value2','Text for value2','B',1002,'01-01-2020','01-01-2020',1002,1);
Insert into app_parameters values(3,'Type C','Value3','Text for value3','C',1003,'01-01-2020','01-01-2020',1003,1);
Insert into app_parameters values(4,'Type D','Value4','Text for value4','D',1004,'01-01-2020','01-01-2020',1004,1);
Insert into app_parameters values(5,'Type E','Value5','Text for value5','E',1005,'01-01-2020','01-01-2020',1005,1);
Select * from app_parameters 

CREATE TABLE Mentor(
Id int NOT NULL PRIMARY KEY,
Name varchar(50) DEFAULT NULL,
Mentor_Type varchar(20) DEFAULT NULL,
Lab_Id int NOT NULL
CONSTRAINT FK_Mentor_Lab_Id FOREIGN KEY(Lab_Id) REFERENCES Lab(Id),
Status int DEFAULT 1,
Creator_Stamp datetime DEFAULT NULL,
Creator_User int DEFAULT NULL
);
Insert into mentor values(1,'John Doe','TypeA',3,1,'01-01-2020',1);
Insert into mentor values(2,'Jane smith','TypeB',2,1,'01-01-2020',2);
Insert into mentor values(3,'Alice Johnson','TypeC',5,1,'01-01-2020',3);
Insert into mentor values(4,'Bob Brown','TypeD',4,1,'01-01-2020',4);
Insert into mentor values(5,'Eva Wilson','TypeE',1,1,'01-01-2020',5);

CREATE TABLE mentor_ideation_map(
id int NOT NULL PRIMARY KEY,
mentor_id int NOT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
CONSTRAINT FK_mentor_ideation_map_mentor_id FOREIGN KEY (mentor_id) REFERENCES mentor(id),
)
Insert into mentor_ideation_map values(1,4,1,'01-01-2020',1);
Insert into mentor_ideation_map values(2,2,1,'01-01-2020',2);
Insert into mentor_ideation_map values(3,3,1,'01-01-2020',3);
Insert into mentor_ideation_map values(4,1,1,'01-01-2020',4);
Insert into mentor_ideation_map values(5,5,1,'01-01-2020',5);

CREATE TABLE mentor_techstack(
id int NOT NULL Primary key,
mentor_id int NOT NULL,
tech_stack_id int NOT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
CONSTRAINT FK_mentor_mentor_id FOREIGN KEY (mentor_id) REFERENCES mentor(id),
CONSTRAINT FK_mentor_tech_stack_id FOREIGN KEY (tech_stack_id) REFERENCES tech_stack(id)
)
Insert into mentor_techstack values (1,3,3,1,'01-01-2020',1)
Insert into mentor_techstack values (2,2,2,1,'01-01-2020',2)
Insert into mentor_techstack values (3,5,5,1,'01-01-2020',3)
Insert into mentor_techstack values (4,4,4,1,'01-01-2020',4)
Insert into mentor_techstack values (5,1,1,1,'01-01-2020',5)

CREATE TABLE lab_threshold(
id int NOT NULL PRIMARY KEY,
lab_id int NOT NULL,
lab_capacity varchar(50) DEFAULT NULL,
lead_threshold int DEFAULT NULL,
ideation_engg_threshold int DEFAULT NULL,
buddy_engg_threshold int DEFAULT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
CONSTRAINT FK_lab_lab_id FOREIGN KEY (lab_id) REFERENCES Lab(id)
)
INSERT INTO lab_threshold (id, lab_id, lab_capacity, lead_threshold, ideation_engg_threshold, buddy_engg_threshold, status, creator_stamp, creator_user)
VALUES
(1, 1, 'High', 5, 10, 15, 1, '2023-09-26 22:00:00', 1),
(2, 2, 'Medium', 4, 8, 12, 1, '2023-09-26 22:15:00', 2),
(3, 3, 'Low', 3, 6, 9, 1, '2023-09-26 22:30:00', 3),
(4, 4, 'High', 5, 10, 15, 1, '2023-09-26 22:45:00', 1),
(5, 5, 'Medium', 4, 8, 12, 1, '2023-09-26 23:00:00', 2)

Select * from company
select * from tech_stack
select * from tech_type
select * from maker_program
select * from lab
select * from app_parameters
select * from Mentor
select * from mentor_ideation_map
select * from mentor_techstack


--26/09/2023
Select * from hired_candidates Inner Join
fellowship_candidates on hired_candidates.Id = fellowship_candidates.id Inner join
candidates_personal_det_check on hired_candidates.Id = candidates_personal_det_check.id Inner join
candidate_bank_det on candidates_personal_det_check.candidate_id = candidate_bank_det.candidate_id inner join
candidates_bank_det_check on candidate_bank_det.candidate_id = candidates_bank_det_check.candidate_id inner join
candidate_qualification on candidate_bank_det.candidate_id = candidate_qualification.candidate_id inner join
candidates_education_det_check on candidate_bank_det.candidate_id = candidates_education_det_check.candidate_id inner join
user_details on hired_candidates.id = user_details.id inner join
user_roles on hired_candidates.id=user_roles.user_id;

--27/09/2023
SELECT * FROM company INNER JOIN
tech_type ON company.id = tech_type.id INNER JOIN
tech_stack ON company.id = tech_stack.id INNER JOIN
maker_program ON company.id = maker_program.id INNER JOIN
lab ON company.id = lab.id INNER JOIN
Mentor ON company.id = Mentor.Id INNER JOIN
mentor_ideation_map ON company.id = mentor_ideation_map.id INNER JOIN
mentor_techstack ON company.id = mentor_techstack.id INNER JOIN
app_parameters ON company.id = app_parameters.id


--28/09/2023
CREATE TABLE company_requirement(
id int NOT NULL Primary Key,
company_id int NOT NULL,
candidate_id int NOT NULL,
requested_month varchar(20) NOT NULL,
city varchar(20) DEFAULT NULL,
is_doc_verification int DEFAULT 1,
requirement_doc_path varchar(500) DEFAULT NULL,
no_of_engg int NOT NULL,
tech_stack_id int NOT NULL,
tech_type_id int NOT NULL,
maker_programs_id int NOT NULL,
lead_id int NOT NULL,
ideateion_engg_id int DEFAULT NULL,
buddy_engg_id int DEFAULT NULL,
special_remark text DEFAULT NULL,
status int DEFAULT 1,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
CONSTRAINT FK_candidate_candidate_id FOREIGN KEY (candidate_id) REFERENCES fellowship_candidates (id),
)
INSERT INTO company_requirement (id, company_id, candidate_id, requested_month, city, is_doc_verification, requirement_doc_path, no_of_engg, tech_stack_id, tech_type_id, maker_programs_id, lead_id, ideateion_engg_id, buddy_engg_id, special_remark, status, creator_stamp, creator_user)
VALUES
(1, 1, 3, 'September 2023', 'Chennai', 1, 'doc1.pdf', 5, 1, 1, 1, 1, 2, 3, 'Special remarks for requirement 1', 1, '2023-09-27 09:00:00', 1),
(2, 2, 4, 'March 2023', 'Mumbai', 1, 'doc2.pdf', 4, 2, 2, 2, 2, 3, 4, 'Special remarks for requirement 2', 1, '2023-09-27 09:15:00', 2),
(3, 3, 5, 'May 2023', 'Mysore', 1, 'doc3.pdf', 3, 3, 3, 3, 3, 4, 5, 'Special remarks for requirement 3', 1, '2023-09-27 09:30:00', 3),
(4, 4, 1, 'September 2023', 'Delhi', 1, 'doc4.pdf', 5, 4, 1, 1, 1, 2, 3, 'Special remarks for requirement 4', 1, '2023-09-27 09:45:00', 1),
(5, 5, 2, 'July 2023', 'Pune', 1, 'doc5.pdf', 4, 5, 2, 2, 2, 3, 4, 'Special remarks for requirement 5', 1, '2023-09-27 10:00:00', 5)
Select * from company_requirement

CREATE TABLE candidate_techstack_assignment(
id int NOT NULL primary key,
requirement_id int NOT NULL,
candidate_id int NOT NULL FOREIGN KEY (candidate_id) REFERENCES fellowship_candidates (id),
assign_date datetime DEFAULT NULL,
status varchar(20) DEFAULT NULL,
creator_stamp datetime DEFAULT NULL,
creator_user int DEFAULT NULL,
CONSTRAINT FK_candidate_techstack_assignment_requirement_id FOREIGN KEY(requirement_id) REFERENCES company_requirement (id),
)
INSERT INTO candidate_techstack_assignment (id, requirement_id, candidate_id, assign_date, status, creator_stamp, creator_user)
VALUES
(1, 1, 3, '2023-09-27 09:00:00', 'Assigned', '2023-09-27 09:15:00', 1),
(2, 2, 4, '2023-09-27 09:15:00', 'Assigned', '2023-09-27 09:30:00', 2),
(3, 3, 2, '2023-09-27 09:30:00', 'Assigned', '2023-09-27 09:45:00', 3),
(4, 4, 5, '2023-09-27 09:45:00', 'Assigned', '2023-09-27 10:00:00', 1),
(5, 5, 1, '2023-09-27 10:00:00', 'Assigned', '2023-09-27 10:15:00', 5)

CREATE TABLE user_engagement_MIS(
id int NOT NULL primary key,
candidate_id int NOT NULL,
Date_Time date NOT NULL,
Cpu_Count int NOT NULL,
Cpu_Working_Time float NOT NULL,
Cpu_idle_Time float NOT NULL,
cpu_percent float NOT NULL,
Usage_cpu_count int NOT NULL,
number_of_software_interrupts_since_boot float NOT NULL,
number_of_system_calls_since_boot int NOT NULL,
number_of_interrupts_since_boot int NOT NULL,
cpu_avg_load_over_1_min float NOT NULL,
cpu_avg_load_over_5_min float NOT NULL,
cpu_avg_load_over_15_min float NOT NULL,
system_total_memory BIGINT NOT NULL,
system_used_memory float NOT NULL,
system_free_memory float NOT NULL,
system_active_memory float NOT NULL,
system_inactive_memory float NOT NULL,
system_buffers_memory int NOT NULL,
system_cached_memory float NOT NULL,
system_shared_memory int NOT NULL,
system_avalible_memory float  NOT NULL,
disk_total_memory BIGINT NOT NULL,
disk_used_memory BIGINT NOT NULL,
disk_free_memory BIGINT NOT NULL,
disk_read_count BIGINT NOT NULL,
disk_write_count BIGINT NOT NULL,
disk_read_bytes BIGINT NOT NULL,
disk_write_bytes BIGINT NOT NULL,
time_spent_reading_from_disk BIGINT NOT NULL,
time_spent_writing_to_disk BIGINT NOT NULL,
time_spent_doing_actual_Input_Output BIGINT NOT NULL,
number_of_bytes_sent BIGINT NOT NULL,
number_of_bytes_received BIGINT NOT NULL,
number_of_packets_sent BIGINT NOT NULL,
number_of_packets_recived BIGINT NOT NULL,
total_number_of_errors_while_receiving BIGINT NOT NULL,
total_number_of_errors_while_sending BIGINT NOT NULL,
total_number_of_incoming_packets_which_were_dropped BIGINT NOT NULL,
total_number_of_outgoing_packets_which_were_dropped BIGINT NOT NULL,
boot_time nvarchar(50) NOT NULL,
keyboard float NOT NULL,
mouse int NOT NULL,
technology nvarchar(100) NOT NULL,
files_changed int NOT NULL,
CONSTRAINT FK_user_engagemnt_mis_candidate_id FOREIGN KEY (candidate_id) REFERENCES fellowship_candidates (id)
)
Select * from user_engagement_MIS;
Drop table user_engagement_Mis

INSERT INTO user_engagement_MIS values
(9, 1, '2023-09-26', 4, 123.45, 67.89, 75.0, 8, 123.0, 456, 789, 1.23, 4.56, 7.89, 81920000000, 20.48, 61.44,
40.96, 20.48, 512, 20.48, 512, 102.40, 1048576, 524288, 5242880, 512345, 67890, 1234567, 7654321, 2345678, 9876543,
3456789, 1234567890, 987654321, 1234, 5678, 1234567, 7654321, 1234, 5678,'1 day', 0,0,'Android',1)
INSERT INTO user_engagement_MIS values
(10, 2, '2023-09-27', 4, 234.56, 78.90, 80.0, 4, 234.0, 567, 890, 2.34, 5.67, 8.90, 8192, 204.8, 614.4,
4096, 2048, 512, 2048, 512, 1024.0, 1048576, 524288, 5242880, 234567, 78901, 2345678, 8765432, 3456789, 9012345,
4567890, 234567890, 876543210, 2345, 6789, 2345678, 8765432, 2345, 6789,'1 Day',0, 0,'Android', 2)

INSERT INTO user_engagement_MIS values(6, 3, '2023-09-28', 8, 345.67, 89.01, 90.0, 6, 345.0, 678, 901, 3.45, 6.78, 9.01, 16384, 4096, 12288,
8192, 4096, 1024, 4096, 1024, 20480, 2097152, 1048576, 10485760, 345678, 89012, 3456789, 9876543, 4567890, 1234567,
5678901, 3456789012, 789012345, 3456, 7890, 3456789, 9876543, 3456, 7890,'1 day',0,0,'Android', 3)

INSERT INTO user_engagement_MIS values(7, 4, '2023-09-29', 8, 456.78, 90.12, 95.0, 4, 456.0, 789, 901, 4.56, 7.89, 0.12, 16384, 4096, 12288,
8192, 4096, 1024, 4096, 1024, 20480, 2097152, 1048576, 10485760, 456789, 90123, 4567890, 2345678, 5678901, 2345678,
9012345, 2345678901, 789012345, 4567, 8901, 2345678, 1234567, 4567, 8901,'1 day',0,0,'Android', 4)


INSERT INTO user_engagement_MIS values(8, 5, '2023-09-30 16:00:00', 4, 567.89, 12.34, 85.0, 8, 567.0, 890, 123, 5.67, 8.90, 1.23, 8192, 2048, 6144,
4096, 2048, 512, 2048, 512, 10240, 1048576, 524288, 5242880, 567890, 12345, 5678901, 2345678, 9012345, 4567890,
2345678, 1234567890, 567890123, 5678, 9012, 1234567, 7654321, 5678, 9012,'1 day',0,0,'Android', 5)

Select * from user_engagement_MIS

CREATE TABLE temporary_MIS(
Date_Time DATE NOT NULL,
Cpu_Count int NOT NULL,
Cpu_Working_Time Float NOT NULL,
Cpu_idle_Time float NOT NULL,
cpu_percent Float NOT NULL,
Usage_cpu_count int NOT NULL,
number_of_software_interrupts_since_boot Float NOT NULL,
number_of_system_calls_since_boot int NOT NULL,
number_of_interrupts_since_boot int NOT NULL,
cpu_avg_load_over_1_min Float NOT NULL,
cpu_avg_load_over_5_min Float NOT NULL,
cpu_avg_load_over_15_min Float NOT NULL,
system_total_memory BIGINT NOT NULL,
system_used_memory BIGINT  NOT NULL,
system_free_memory BIGINT  NOT NULL,
system_active_memory BIGINT  NOT NULL,
system_inactive_memory BIGINT NOT NULL,
system_buffers_memory BIGINT  NOT NULL,
system_cached_memory BIGINT  NOT NULL,
system_shared_memory BIGINT  NOT NULL,
system_avalible_memory BIGINT  NOT NULL,
disk_total_memory BIGINT  NOT NULL,
disk_used_memory BIGINT  NOT NULL,
disk_free_memory BIGINT  NOT NULL,
disk_read_count BIGINT  NOT NULL,
disk_write_count BIGINT  NOT NULL,
disk_read_bytes BIGINT  NOT NULL,
disk_write_bytes BIGINT  NOT NULL,
time_spent_reading_from_disk BIGINT  NOT NULL,
time_spent_writing_to_disk BIGINT  NOT NULL,
time_spent_doing_actual_Input_Output BIGINT  NOT NULL,
number_of_bytes_sent BIGINT  NOT NULL,
number_of_bytes_received BIGINT  NOT NULL,
number_of_packets_sent BIGINT  NOT NULL,
number_of_packets_recived BIGINT  NOT NULL,
total_number_of_errors_while_receiving BIGINT  NOT NULL,
total_number_of_errors_while_sending BIGINT  NOT NULL,
total_number_of_incoming_packets_which_were_dropped BIGINT  NOT NULL,
total_number_of_outgoing_packets_which_were_dropped BIGINT NOT NULL,
boot_time varchar(100) NOT NULL,
user_name varchar(50) NOT NULL Primary Key,
keyboard int NOT NULL,
mouse int  NOT NULL,
technology varchar(100) NOT NULL,
files_changed int  NOT NULL,
)


Bulk Insert temporary_MIS from 'C:\Users\PrasannaVenkateshRP\Downloads\CpuLogData2019-11-17-new.csv'
WITH
(
FIRSTROW = 2,
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
)
GO 

insert into temporary_MIS values ('2019-11-17 05:30:01',2,2937.5,276422.96,53.6,2,26718321,0,21852873,0,0.01,0,7893839872,2104496128,858034176,3811336192,2197868544,584396800,4346912768,407351296,5064630272,117088358400,56368902144,54727581696,448828,296929,3147111424,7024268288,550333,442946,376080,20332343,273405746,157626,585066,0,0,128,0,'1 day15:20:58.870261','deepak.63584@gmail.com ',0,0,'android',8)
insert into temporary_MIS values ('2019-11-17 05:30:02',2,2057.07,269460.2,50,2,24988954,0,20125421,0,0.01,0,7893831680,2020208640,711634944,3779506176,2349027328,622518272,4539469824,250732544,5305536512,117088358400,36491653120,74604830720,492170,251067,3220555776,6267409408,491999,393366,401452,89915961,327646828,249119,633754,0,0,52,0,'1 day 14:16:11.068401','john.doe@example.com',0,0,'android',5)
insert into temporary_MIS values ('2019-11-17 05:30:01',2,1010.69,136340.09,50,2,18961098,0,19345486,0.06,0.05,0,7893815296,778010624,4038762496,1855426560,1007542272,592011264,2485030912,124264448,6674055168,117088358400,75194273792,35902210048,172272,44459,1632532480,1544938496,204350,113490,131880,2064439602,2128790849,2515278,2736332,0,0,49,0,'19:36:09.905103','james.anderson@example.com',0,0,'android',3)

/*
insert into user_engagement_MIS  
(Select * from fellowship_candidates Left JOIN temporary_MIS
ON fellowship_candidates.email=temporary_MIS.user_name)
Union
(select * from fellowship_candidates Right JOIN temporary_MIS ON
fellowship_candidates.email=temporary_MIS.user_name)


insert into user_engagement_MIS Select(
select id,first_name, middle_name , last_name, mobile_num, hired_city,
hired_date, degree, aggr_per, current_pincode, permanent_pincode, hired_lab,
attitude_remark, communication_remark, knowledge_remark, birth_date ,
is_birth_date_verified, parent_name, parent_occupation, parent_mobile_num ,
parent_annual_sal, local_addr, permanent_addr, photo_path , joining_date,
candidate_status, personal_info_filled, bank_info_filled, educational_info_filled,
doc_status, remark , creator_stamp, creator_user
from fellowship_candidates LEFT JOIN temporary_MIS ON
fellowship_candidates.email=temporary_MIS.user_name)
UNION
(select id,first_name, middle_name , last_name, mobile_num, hired_city,
hired_date, degree, aggr_per, current_pincode, permanent_pincode, hired_lab,
attitude_remark, communication_remark, knowledge_remark, birth_date ,
is_birth_date_verified, parent_name, parent_occupation, parent_mobile_num ,
parent_annual_sal, local_addr, permanent_addr, photo_path , joining_date,
candidate_status, personal_info_filled, bank_info_filled, educational_info_filled,
doc_status, remark , creator_stamp, creator_user
from fellowship_candidates Right JOIN temporary_MIS ON
fellowship_candidates.email=temporary_MIS.user_name);


(select Date_Time, Cpu_Count, Cpu_Working_Time, Cpu_idle_Time, cpu_percent,
Usage_cpu_count, number_of_software_interrupts_since_boot ,
number_of_system_calls_since_boot, number_of_interrupts_since_boot,
cpu_avg_load_over_1_min, cpu_avg_load_over_5_min, cpu_avg_load_over_15_min,
system_total_memory , system_used_memory, system_free_memory, system_active_memory,
system_inactive_memory, system_buffers_memory,
system_cached_memory, system_shared_memory, system_avalible_memory,
disk_total_memory, disk_used_memory, disk_free_memory , disk_read_count,
disk_write_count, disk_read_bytes , disk_write_bytes, time_spent_reading_from_disk,
time_spent_writing_to_disk, time_spent_doing_actual_Input_Output, number_of_bytes_sent ,
number_of_bytes_received, number_of_packets_sent, number_of_packets_recived,
total_number_of_errors_while_receiving, total_number_of_errors_while_sending,
total_number_of_incoming_packets_which_were_dropped,
total_number_of_outgoing_packets_which_were_dropped, boot_time, keyboard, mouse,
technology, files_changed
from fellowship_candidates INNER JOIN temporary_MIS ON
fellowship_candidates.email=temporary_MIS.user_name);


create procedure produce_user_engagement_MIS_data()
begin
insert into user_engagement_MIS Select (select * from fellowship_candidates LEFT JOIN temporary_MIS
ON fellowship_candidates.email=temporary_MIS.user_name)
UNION
(select * from fellowship_candidates LEFT JOIN temporary_MIS ON
fellowship_candidates.email=temporary_MIS.user_name)
end */
select Date_Time, Cpu_Count, Cpu_Working_Time, Cpu_idle_Time, cpu_percent,
Usage_cpu_count, number_of_software_interrupts_since_boot , number_of_system_calls_since_boot, number_of_interrupts_since_boot,
cpu_avg_load_over_1_min, cpu_avg_load_over_5_min, cpu_avg_load_over_15_min,
system_total_memory , system_used_memory, system_free_memory, system_active_memory, system_inactive_memory,  system_buffers_memory,
system_cached_memory, system_shared_memory, system_avalible_memory, disk_total_memory, disk_used_memory, disk_free_memory , disk_read_count,
disk_write_count, disk_read_bytes , disk_write_bytes, time_spent_reading_from_disk,
time_spent_writing_to_disk, time_spent_doing_actual_Input_Output, number_of_bytes_sent ,
number_of_bytes_received, number_of_packets_sent, number_of_packets_recived,
total_number_of_errors_while_receiving, total_number_of_errors_while_sending,
total_number_of_incoming_packets_which_were_dropped, total_number_of_outgoing_packets_which_were_dropped, boot_time, keyboard, mouse,
technology, files_changed
from   fellowship_candidates RIGHT JOIN temporary_MIS ON fellowship_candidates.email=temporary_MIS.user_name;



insert into user_engagement_MIS (select * from fellowship_candidates LEFT JOIN temporary_MIS ON fellowship_candidates.email=temporary_MIS.user_name) 
UNION
(select * from   fellowship_candidates  RIGHT JOIN temporary_MIS ON fellowship_candidates.email=temporary_MIS.user_name);

insert into user_engagement_MIS(
select id,first_name, middle_name , last_name, mobile_num,   hired_city,
hired_date, degree, aggr_per,  current_pincode, permanent_pincode, hired_lab,
attitude_remark, communication_remark,  knowledge_remark,   birth_date ,
is_birth_date_verified,  parent_name,  parent_occupation,   parent_mobile_num ,
parent_annual_sal,  local_addr,  permanent_addr,   photo_path ,  joining_date,  
candidate_status,  personal_info_filled,   bank_info_filled,  educational_info_filled,
doc_status,  remark ,  creator_stamp, creator_user
from fellowship_candidates LEFT  JOIN temporary_MIS  ON fellowship_candidates.email=temporary_MIS.user_name)
UNION
(select id,first_name, middle_name , last_name, mobile_num,   hired_city,
hired_date, degree, aggr_per,  current_pincode, permanent_pincode, hired_lab,
attitude_remark, communication_remark,  knowledge_remark,   birth_date ,
is_birth_date_verified,  parent_name,  parent_occupation,   parent_mobile_num ,
parent_annual_sal,  local_addr,  permanent_addr,   photo_path ,  joining_date,  
candidate_status,  personal_info_filled,   bank_info_filled,  educational_info_filled,
doc_status,  remark ,  creator_stamp, creator_user
from fellowship_candidates RIGHT  JOIN temporary_MIS  ON fellowship_candidates.email=temporary_MIS.user_name);

Select * from fellowship_candidates 


create procedure produce_user_engagement_MIS_data
as
insert into user_engagement_MIS(id,candidate_id,Date_Time, Cpu_Count, Cpu_Working_Time, Cpu_idle_Time, cpu_percent,
Usage_cpu_count, number_of_software_interrupts_since_boot , number_of_system_calls_since_boot, number_of_interrupts_since_boot,
cpu_avg_load_over_1_min, cpu_avg_load_over_5_min, cpu_avg_load_over_15_min,
system_total_memory , system_used_memory, system_free_memory, system_active_memory, system_inactive_memory,  system_buffers_memory,
system_cached_memory, system_shared_memory, system_avalible_memory, disk_total_memory, disk_used_memory, disk_free_memory , disk_read_count,
disk_write_count, disk_read_bytes , disk_write_bytes, time_spent_reading_from_disk,
time_spent_writing_to_disk, time_spent_doing_actual_Input_Output, number_of_bytes_sent ,
number_of_bytes_received, number_of_packets_sent, number_of_packets_recived,
total_number_of_errors_while_receiving, total_number_of_errors_while_sending,
total_number_of_incoming_packets_which_were_dropped, total_number_of_outgoing_packets_which_were_dropped, boot_time, keyboard, mouse,
technology, files_changed)
select id,id,Date_Time, Cpu_Count, Cpu_Working_Time, Cpu_idle_Time, cpu_percent,
Usage_cpu_count, number_of_software_interrupts_since_boot , number_of_system_calls_since_boot, number_of_interrupts_since_boot,
cpu_avg_load_over_1_min, cpu_avg_load_over_5_min, cpu_avg_load_over_15_min,
system_total_memory , system_used_memory, system_free_memory, system_active_memory, system_inactive_memory,  system_buffers_memory,
system_cached_memory, system_shared_memory, system_avalible_memory, disk_total_memory, disk_used_memory, disk_free_memory , disk_read_count,
disk_write_count, disk_read_bytes , disk_write_bytes, time_spent_reading_from_disk,
time_spent_writing_to_disk, time_spent_doing_actual_Input_Output, number_of_bytes_sent ,
number_of_bytes_received, number_of_packets_sent, number_of_packets_recived,
total_number_of_errors_while_receiving, total_number_of_errors_while_sending,
total_number_of_incoming_packets_which_were_dropped, total_number_of_outgoing_packets_which_were_dropped, boot_time, keyboard, mouse,
technology, files_changed
from   fellowship_candidates RIGHT JOIN temporary_MIS ON fellowship_candidates.email=temporary_MIS.user_name								


Create Trigger [tr_Candidates_Personal_Det_Check]
On[Candidates_Personal_Det_Check]
for
insert,update,delete
as
print 'you can not insert,update and delete this table'
rollback;
Insert Into candidates_personal_det_check values(6, 1, 1, 1, '2020-01-01 10:00:00', 0, '2020-01-01 11:00:00', 1)

Create Procedure Sp_UserEngagementCursor
as
begin
Declare Csr_GetFirstUser cursor Scroll for Select * from user_engagement_MIS
open Csr_GetFirstUser
Fetch First from Csr_GetFirstUser
Fetch last from Csr_GetFirstUser
Fetch Prior from Csr_GetFirstUser
Fetch absolute 7 from Csr_GetFirstUser
Fetch absolute -2 from Csr_GetFirstUser
Fetch Next From Csr_GetFirstUser
close Csr_GetFirstUser
Deallocate Csr_GetFirstUser
End
exec Sp_UserEngagementCursor


