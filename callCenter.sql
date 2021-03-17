Create Database CallCenterDB
GO

Use CallCenterDB
GO

Create table clientIndividual(
	id int IDENTITY(1,1) PRIMARY KEY, 
	name varchar(100) not null,
	surname varchar(100) not null
);
GO

insert into clientIndividual(name, surname) values('John', 'Smith')
GO



Create Table adminstrators(
	id int IDENTITY(1,1) PRIMARY KEY,
	name varchar(100) not null,
	surname varchar(100) not null,
	password varchar(150) not null
);
GO
 
insert into adminstrators(name, surname, password) values('Talaat','Elesh','1234')
GO


Select * from clientIndividual
Select * from adminstrators
GO