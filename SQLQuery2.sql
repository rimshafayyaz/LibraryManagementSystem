create table L_Login_Data(
LID int foreign key references Librarian_Data (L_ID) ,
L_Username varchar(40),
L_Password varchar(40),
)

select * from L_Login_Data
select * from Librarian_Data
select * from Student_Data
select * from S_Login_Data
select * from Book_Data
select * from B_issue
select * from B_return

insert into Student_Data values ('2018CS70','Rimsha Fayyaz','CS','4','03248406639','mishafayyaz@gmail.com','St.58, H.372 Mughalpura Lahore')
insert into Student_Data values ('2018CS73','Ayesha Kanwal','CS','4','03224600404','ayeshakanwal@gmail.com','Kanwal Stret ,Layyah')
insert into Student_Data values ('2018CS76','Hassan Latif','CS','4','03054707053','hassnlatif@gmail.com',' Tandiawala Faisalabad')

create table S_Login_Data(
S_Reg_no varchar(50) foreign key references Student_Data ([S_Registration No.]) ,
S_Username varchar(50),
S_Password varchar(50),
)

create table Book_Data(
B_Code varchar(50) primary key,
B_Name varchar(50),
B_Author varchar(50),
B_Publication date,
B_Subject varchar(50),
B_Copies int
)

create table B_issue(
BCode varchar(50) foreign key references Book_Data (B_Code),
BName varchar(50),
SRegNo varchar(50)foreign key references Student_Data ([S_Registration No.]),
SName varchar(50),
LID_issuetime int foreign key references Librarian_Data (L_ID),
LName_issuetime varchar(50) ,
issuedate date
)

create table B_return(
BCode varchar(50) foreign key references Book_Data (B_Code),
BName varchar(50),
SRegNo varchar(50)foreign key references Student_Data ([S_Registration No.]),
SName varchar(50),
LID_returntime int foreign key references Librarian_Data (L_ID),
LName_returntime varchar(50) ,
returndate date
)
