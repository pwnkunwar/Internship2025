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





