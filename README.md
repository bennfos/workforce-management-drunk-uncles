# Bangazon Workforce Management

## Team
⋅⋅⋅Bennett Foster⋅⋅⋅
⋅⋅⋅Allison Patton⋅⋅⋅
⋅⋅⋅Michael Stiles⋅⋅⋅
⋅⋅⋅Carl Barringer⋅⋅⋅
⋅⋅⋅Noah Bartfield⋅⋅⋅

## Description
Bangazon Workforce Management is an ASP.NET MVC Web Application built using Visual Studio on Windows and uses SQL Server as the database engine. This application was designed to manage internal resources for a fictional e-commerce company called Bangazon. The application will allow users to create, view, edit and/or delete Employees, Training Programs, Departments, and Computers.

## Project Setup

1) Create new SQL server Database and name it BangazonWorkforce
2) Run a new query and copy & paste the script at the end of this README file
3) Run the application




## SQL Script

```
CREATE TABLE Department (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(55) NOT NULL,
	Budget 	INTEGER NOT NULL
);

CREATE TABLE Employee (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	FirstName VARCHAR(55) NOT NULL,
	LastName VARCHAR(55) NOT NULL,
	DepartmentId INTEGER NOT NULL,
	IsSupervisor BIT NOT NULL DEFAULT(0),
    CONSTRAINT FK_EmployeeDepartment FOREIGN KEY(DepartmentId) REFERENCES Department(Id)
);

CREATE TABLE Computer (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	PurchaseDate DATETIME NOT NULL,
	DecomissionDate DATETIME,
	Make VARCHAR(55) NOT NULL,
	Manufacturer VARCHAR(55) NOT NULL
);

CREATE TABLE ComputerEmployee (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	EmployeeId INTEGER NOT NULL,
	ComputerId INTEGER NOT NULL,
	AssignDate DATETIME NOT NULL,
	UnassignDate DATETIME,
    CONSTRAINT FK_ComputerEmployee_Employee FOREIGN KEY(EmployeeId) REFERENCES Employee(Id),
    CONSTRAINT FK_ComputerEmployee_Computer FOREIGN KEY(ComputerId) REFERENCES Computer(Id)
);


CREATE TABLE TrainingProgram (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(255) NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	MaxAttendees INTEGER NOT NULL
);

CREATE TABLE EmployeeTraining (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	EmployeeId INTEGER NOT NULL,
	TrainingProgramId INTEGER NOT NULL,
    CONSTRAINT FK_EmployeeTraining_Employee FOREIGN KEY(EmployeeId) REFERENCES Employee(Id),
    CONSTRAINT FK_EmployeeTraining_Training FOREIGN KEY(TrainingProgramId) REFERENCES TrainingProgram(Id)
);

INSERT INTO Department (Name, Budget) VALUES ('HR', 300000);
INSERT INTO Department (Name, Budget) VALUES ('Executive Team', 2000000);
INSERT INTO Department (Name, Budget) VALUES ('Marketing', 540000);
INSERT INTO Department (Name, Budget) VALUES ('Occult Studies', 81200);
INSERT INTO Department (Name, Budget) VALUES ('Silly Walks', 3800000);
INSERT INTO Department (Name, Budget) VALUES ('IT', 45);

INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Allison', 'Patton', 1, 1);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Bennett', 'Foster', 2, 1);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Bobby', 'Brady', 3, 1);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Brantley', 'Jones', 4, 1);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Brian', 'Wilson', 5, 1);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Carl', 'Barringer', 6, 1);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Curtis', 'Crutchfield', 1, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Ellie', 'Ash', 2, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Eric', 'Taylor', 3, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Haroon', 'Iqbal', 4, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Jacquelyn', 'McCray', 5, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Joe', 'Snyder', 6, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Kelly', 'Coles', 1, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Kevin', 'Sadler', 2, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Maggie', 'Johnson', 3, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Matthew', 'Ross', 4, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Michael', 'Stiles', 5, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Michelle', 'Jimenez', 6, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Noah', 'Bartfield', 1, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Sarah', 'Fleming', 2, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('William', 'Wilkinson', 3, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Ali', 'Abdulle', 4, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Samuel', 'Alpren', 5, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Sam', 'Britt', 6, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Jameka', 'Echols', 1, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Josh', 'Hibray', 2, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Brian', 'Jobe', 3, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('William', 'Mathison', 4, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Clifton', 'Matuszeski', 5, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('William', 'Mitchell', 6, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Joel', 'Mondesir', 1, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Christopher', 'Morgan', 2, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Meagan', 'Mueller', 3, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Jonathan', 'Schaffer', 4, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Stephen', 'Senft', 5, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Alexander', 'Thacker', 6, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Anne', 'Vick', 1, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Rose', 'Wisotzky', 2, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Michael', 'Yankura', 3, 0);
INSERT INTO Employee (FirstName, LastName, DepartmentId, IsSupervisor) VALUES ('Selamawit', 'GebreKidan', 4, 0);


INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2010-01-01', '2014-12-31', 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Macbook Pro', 'Apple');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2015-01-01', null, 'Surface Pro', 'Microsoft');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-01-01', null, 'Oryx', 'System76');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');
INSERT INTO Computer (PurchaseDate, DecomissionDate, Make, Manufacturer) Values ('2019-07-01', null, 'XPS', 'Dell');


INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (1, 1, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (2, 2, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (3, 3, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (4, 4, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (5, 5, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (6, 6, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (7, 7, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (8, 8, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (9, 9, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (10, 10, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (11, 11, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (12, 12, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (13, 13, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (14, 14, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (15, 15, '2010-01-01', '2014-12-31');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (1, 16, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (2, 17, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (3, 18, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (4, 19, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (5, 20, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (6, 21, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (7, 22, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (8, 23, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (9, 24, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (10, 25, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (11, 26, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (12, 27, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (13, 28, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (14, 29, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (15, 30, '2015-01-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (19, 34, '2019-08-02', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (20, 44, '2019-08-02', '2019-08-04');
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (20, 45, '2019-08-04', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (21, 44, '2019-08-05', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (25, 31, '2019-08-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (29, 32, '2019-08-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (30, 33, '2019-08-01', null);
INSERT INTO ComputerEmployee (EmployeeId, ComputerId, AssignDate, UnassignDate) VALUES (39, 40, '2019-08-01', null);



INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Productivity and You', '2018-09-14', '2018-09-18', 20);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('HR Rules Are Important, Really', '2018-09-15', '2018-09-19', 15);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Making the most of your imposter syndrome', '2019-04-01', '2019-04-10', 100);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2019-05-01', '2019-05-04', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2019-05-10', '2019-05-14', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2019-06-01', '2019-06-04', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2019-06-10', '2019-06-14', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2019-07-01', '2019-07-04', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Customer Service: Is it ok to yell at them?', '2019-12-01', '2019-12-05', 10);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Managing Your Manager', '2019-12-01', '2019-12-05', 10);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Goal Setting When No One Knows What''s Coming Next', '2020-01-10', '2020-01-14', 10);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2020-05-01', '2020-05-04', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2020-05-10', '2020-05-14', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2020-06-01', '2020-06-04', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2020-06-10', '2020-06-14', 30);
INSERT INTO TrainingProgram (Name, StartDate, EndDate, MaxAttendees) VALUES ('Grifting', '2020-07-01', '2020-07-04', 30);


INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (1, 1);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (1, 2);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (1, 3);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (2, 2);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (2, 3);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (20, 8);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (20, 8);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (1, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (2, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (3, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (4, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (5, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (6, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (7, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (8, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (9, 9);
INSERT INTO EmployeeTraining (EmployeeId, TrainingProgramId) VALUES (10, 9);

```
