USE Company_SD;

SELECT * 
FROM Employee;

SELECT E.Fname , E.Lname , E.Salary , E.Dno
FROM Employee AS E;

SELECT P.Pname , p.Plocation , p.Dnum 
FROM Project AS P;

SELECT E.Fname + ' ' + E.Lname AS "Full Name" , (10 * E.Salary) / 100 AS "ANNUAL COMM" 
FROM Employee AS E;


SELECT E.SSN , E.Fname + ' ' + E.Lname AS "Full Name"
FROM Employee AS E
WHERE E.Salary > 1000;


SELECT E.SSN , E.Fname + ' ' + E.Lname AS "Full Name"
FROM Employee AS E
WHERE E.Salary * 12 > 10000;


SELECT E.Fname + ' ' + E.Lname AS "Full Name" , E.Salary
FROM Employee AS E
WHERE E.Sex = 'F';

SELECT Drt.Dnum , Drt.Dname
FROM Departments AS Drt
WHERE Drt.MGRSSN = 968574;

SELECT P.Pnumber , P.Pname , P.Plocation
FROM Project AS P
WHERE P.Dnum = 10;

