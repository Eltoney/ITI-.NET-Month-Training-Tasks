USE Company_SD;

--1
SELECT D.Dnum  ,D.Dname ,  E.SSN , E.Fname + ' ' + E.Lname As "Manager name"
FROM 
    Departments AS D JOIN Employee AS E on D.MGRSSN = E.SSN;

--2
SELECT D.Dname , P.Pname
FROM 
    Project AS P JOIN Departments AS D on P.Dnum = D.Dnum;

--3
SELECT DP.* , E.Fname
FROM 
    Dependent AS Dp JOIN Employee AS E on Dp.ESSN = E.SSN;

--4
SELECT P.Pnumber , P.Pname , P.Plocation
FROM Project AS P
WHERE P.City in ('alex'  , 'cairo');

--5
SELECT P.*
FROM Project AS P
WHERE P.Pname like 'a%';

--6
SELECT * 
FROM Employee AS E
WHERE E.Dno = 30 AND E.Salary >= 1000 AND  E.Salary <= 2000 ;

--7
SElECT E.Fname + ' ' + E.Lname As "name"
FROM 
    Project AS P Join Works_for AS W ON P.Pnumber = W.Pno
    JOIN
        Employee AS E on E.SSN = W.ESSn
WHERE P.Pname = 'AL Rabwah'  and Dnum = 10 and W.Hours >= 10;

--8
SELECT E1.Fname + ' ' + E1.Lname as "Name" 
FROM 
    Employee AS E1 JOIN Employee AS E2 on E1.Superssn = E2.SSN
WHERE E2.Fname = 'Kamel' and E2.Lname = 'Mohamed';

--9
SELECT E.Fname + ' ' + E.Lname AS "Name" , P.Pname
FROM 
    Employee AS E JOIN Works_for AS W on E.SSN = W.ESSn
    JOIN 
        Project AS P on P.Pnumber = W.Pno
ORDER BY P.Pname;

--10
SELECT P.Pnumber , D.Dname , E.Lname , E.Address , E.Bdate
FROM 
    Project AS P JOIN Departments AS D on P.Dnum = D.Dnum
    JOIN Employee AS E on E.SSN = D.MGRSSN
WHERE P.City = 'cairo';

--11
SELECT E.*
FROM 
    Employee AS E JOIN Departments AS D on E.SSN = D.MGRSSN;

--12
SELECT *
FROM 
    Employee AS E LEFT JOIN Dependent AS Dp ON E.SSN = Dp.ESSN;

--13
INSERT INTO Employee(Dno , SSN , Superssn)
VALUES (30 , 102672 , 112233);

--14
INSERT INTO Employee(Dno , SSN)
VALUES (30 , 102660);

--15
INSERT INTO Departments(Dname , Dnum , MGRSSN , [MGRStart Date])
VALUES('DEPT IT' , 100 , 112233 , '1-11-2006');



