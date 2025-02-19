CREATE Database Internship2025;

CREATE TABLE Employees(
   EmployeeID INT PRIMARY KEY IDENTITY(1,1),
   FirstName NVARCHAR(50) NOT NULL,
   LastName NVARCHAR(50) NOT NULL,
   Email NVARCHAR(50) NOT NULL,
   Salary DECIMAL(18,2) NOT NULL
 );

 INSERT INTO Employees (FirstName,LastName,Email,Salary) 
 VALUES ('Hello','World','hello@gmail.com',13000)s


 SELECT * FROM Employees

 SELECT Email FROM Employees;


 UPDATE Employees SET FirstName = 'demo', LastName = 'test' WHERE EmployeeID = 3; 

 DELETE FROM Employees Where EmployeeID = 3;


 SELECT FirstName From Employees WHERE Salary > 12500;


 SELECT * FROM Employees WHERE Salary BETWEEN 12000 AND 15000;


 SELECT * FROM Employees ORDER BY Salary DESC;


  --COUNT total Employess

 SELECT COUNT(*) AS TotolEmployees FROM Employees;



 ALTER TABLE Employees ADD PhoneNumber NVARCHAR(15);


 -- Average salary of all Employees

 SELECT AVG(Salary) As AveraeSalary FROM Employees;





 Create table Departments (
 DepartmentID INT PRIMARY KEY IDENTITY(1,1),
 DepartmentName NVARCHAR(100) NOT NULL
 );


 INSERT into Departments(DepartmentName) VALUES ('Finance');

 -- INNER JOIN

 SELECT Employees.FirstName, Employees.LastName, Departments.DepartmentName FROM Employees
 INNER JOIN Departments ON Employees.EmployeeID = Departments.DepartmentID;



ALTER TABLE Employees ADD DepartmentID Int;


UPDATE Employees SET DepartmentID =3 WHERE EmployeeID =4;


-- LEFT JOIN
SELECT Employees.FirstName, Employees.LastName,Departments.DepartmentName FROM Employees
LEFT JOIN Departments ON Employees.DepartmentIDwhat  = Departments.DepartmentID;


-- RIGHT JOIN
SELECT Employees.FirstName, Departments.DepartmentName From Employees RIGHT JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID;


-- USE OF AND OPERATOR
SELECT FirstName, LastName, Salary FROM Employees WHERE DepartmentId = 1 AND Salary > 12500;

-- USE OF OR OPERATOR
SELECT FirstName, LastName, Salary FROM Employees WHERE DepartmentId = 1 OR Salary > 12500;





SELECT Top 1 FirstName, LastName, Salary FROM Employees ORDER BY Salary DESC;


-- UNION Clause(Combining Results of Two Queries) and it remove duplicates

SELECT FirstName FROM Employees UNION SELECT DepartmentName FROM Departments;


-- UNION ALL include duplicates
SELECT FirstName FROM Employees
UNION ALL 
SELECT DepartmentName FROM Departments;


-- IS NULL 
SELECT FirstName, LastName FROM Employees WHERE DepartmentID IS NULL;

-- IS NOT NULL
SELECT FirstName, LastName FROM Employees WHERE DepartmentID IS NOT NULL;


-- IN CLAUSE 
SELECT FirstName, LastName FROM Employees WHERE DepartmentID IN (1,2);



-- STORED PROCEDURE


CREATE PROCEDURE GetAllUsers
AS 
BEGIN 
     SELECT * FROM Employees;
END;

-- To execute

EXEC GetAllUsers;


-- Stored Procedure with Parameters

ALTER PROCEDURE GetEmployeeById
@UserId INT
AS 
BEGIN 
    SELECT * FROM Employees WHERE EmployeeID = @UserId;
END;


EXEC GetEmployeeById @UserId = 1;


-- Stored Procedure for Inserting Data




CREATE PROCEDURE InserEmployee
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50),
@Email NVARCHAR(100),
@Salary decimal(10,2),
@PhoneNumber NVARCHAR(100),
@DepartMentId INT


AS BEGIN 
INSERT INTO Employees (FirstName,LastName,Email,Salary,PhoneNumber,DepartmentID) 
VALUES (@FirstName, @LastName,@Email,@Salary,@PhoneNumber,@DepartMentId);
END;


EXEC InserEmployee @FirstName = 'John', @LastName = 'Doe', @Email='johndoe@gmail.com',@Salary='16000',@PhoneNumber = '9846109393',@DepartMentId=1;

-- Stored Procedure with IF-ELSE Logic

CREATE PROCEDURE CheckUserExists 
@EmployeeId INT
AS BEGIN 
IF EXISTS (SELECT 1 FROM Employees WHERE EmployeeID=@EmployeeId)
PRINT 'USER EXISTS';
ELSE
PRINT 'USER NOT FOUND';
END;

EXEC CheckUserExists @EmployeeId =2;

-- DELETE PROCEDURE

DROP PROCEDURE CheckUserExists;



/* https://www.sql-practice.com practise  */
SELECT * FROM patients


select first_name,last_name,gender FROM patients WHERE gender='M';

select first_name,last_name FROM patients where allergies IS NULL;

select first_name from patients where first_name LIKE 'C%'; -- first name started with C letter 

select first_name, last_name FROm patients where weight between 100 AND 120;



update patients SET allergies='NKA'   where allergies is null;

select concat(first_name,' ', last_name) AS full_name from patients;



SELECT count(*) AS a FROm admissions;


SELECT 
    p.FirstName, 
    p.LastName, 
    prov.ProvinceName
FROM Patients p
JOIN Provinces prov ON p.ProvinceCode = prov.ProvinceCode;

select count(*) FROm patients where year(birth_date) = 2010;




select first_name,last_name, height from patients where height= (select max(height) from patients);

 


select * FROM patients where patient_id in (1,45,534,879,1000);

select * from admissions where admission_date = discharge_date;



select patient_id, count(*) attending_doctor_id from admissions where patient_id = 579;



select distinct(city) As unique_cities from patients where province_id = 'NS';


select first_name, last_name, birth_date from patients where height > 160 and weight > 70;


select first_name, last_name , allergies from patients where allergies Is not NULL and city = 'Hamilton';



select distinct year(birth_date) from patients order by  birth_date asc;

select first_name from patients group by first_name having count(*) =1;


select patient_id, first_name from patients where first_name like 's%s' And len(first_name) >= 6;



select p.patient_id, p.first_name, p.last_name From patients p join admissions ad ON p.patient_id = ad.patient_id where ad.diagnosis = 'Dementia';




-- Students table
CREATE TABLE Students (
StudentID INT PRIMARY KEY IDENTITY(1,1),
Name varchar(100) NOT NULL,
AGE int,
Grade VARCHAR(10),
City VARCHAR(50)
);


INSERT INTO Students (Name, Age, Grade, City) VALUES
('Alice', 15, '10th', 'New York'),
('Bob', 16, '11th', 'Los Angeles'),
('Charlie', 14, '9th', 'Chicago'),
('David', 17, '12th', 'Houston'),
('Emma', 15, '10th', 'Phoenix');


CREATE VIEW StudentGrades AS SELECT StudentID, Name, Grade FROM Students;

SELECT * FROM StudentGrades;


CREATE VIEW TenthGraders AS SELECT StudentID, Name, Grade FROM Students 
WHERE Grade = '10th';

SELECT * FROM TenthGraders;


DROP VIEW StudentGrades;



CREATE DATABASE ProductDB;
GO
USE ProductDB;
GO

CREATE TABLE Products(
Id INT IDENTITY(1,1) PRIMARY KEY,
NAME VARCHAR(100) NOT NULL,
Price DECIMAL(18,2) NOT NULL
);