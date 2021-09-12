USE Company_SD;

--1
    SELECT Dp.Dependent_name , Dp.Sex
    FROM
        Employee AS E JOIN Dependent AS Dp ON E.SSN = Dp.ESSN
    WHERE E.Sex = 'F' and Dp.Sex = 'F'

UNION

    SELECT Dp.Dependent_name , Dp.Sex
    FROM
        Employee AS E JOIN Dependent AS Dp ON E.SSN = Dp.ESSN
    WHERE E.Sex = 'M' and Dp.Sex = 'M';

--2
SELECT P.Pname  , sum(W.[Hours]) AS [Total Hours]
FROM
    Project AS P join Works_for As W on P.Pnumber = W.Pno
GROUP BY P.Pname;

--3
SELECT *
FROM Departments AS D
WHERE D.Dnum = 
              (SELECT E2.Dno
FROM Employee AS E2
WHERE E2.SSN =  (SELECT min(E1.SSN)
FROM Employee AS E1));

--4
SELECT D.Dname , max(E.Salary) AS [mx Salary], min(E.Salary) As "mn Salary", AVG(E.Salary) As [Avg Salary]
FROM
    Departments AS D join Employee As E on D.Dnum = E.Dno
GROUP BY D.Dname;

--5
SELECT E1.Lname
FROM Employee  AS E1
WHERE   E1.SSN not in (SELECT DP.ESSN
    FROM Dependent AS DP)
    and E1.SSN in (SELECT D.MGRSSN
    FROM Departments As D);

--6
SELECT D.Dnum , D.Dname , COUNT(E.SSN)
FROm
    Departments AS D join Employee As E on D.Dnum = E.Dno
GROUP BY D.Dnum , Dname
HAVING AVG(E.Salary) < (SELECT AVG(E2.Salary)
FROM Employee AS E2);

--7
SELECT *
FROM
    Works_for AS W JOIN Employee AS E on W.ESSn = E.SSN
ORDER BY E.Dno , E.Fname , E.Lname;

--8
-- SELECT TOP 2 E.Salary
-- FROM Employee AS E
-- ORDER BY Salary DESC;

    SELECT max(E2.Salary) AS "Max two salried"
    FROM Employee E2
UNION ALL
    SELECT max(TEMP.SAL)
    FROM
        (SELECT E3.Salary AS SAL
        FROM Employee E3
        WHERE E3.SSN !=
            (SELECT SSN
        FROM Employee AS E
        WHERE E.Salary =  (SELECT max(E1.Salary)
        FROM Employee E1))) AS TEMP;

--9
SELECT E.Fname + ' ' + E.Lname AS [Emp Name]
FROM Employee AS E
WHERE E.Fname + ' ' + E.Lname in (SELECT Dp.Dependent_name
FROM Dependent AS Dp);

--10
INSERT INTO Departments
    (Dnum , MGRSSN)
VALUES(100 , 968574);

UPDATE Employee
    SET Dno = 100
    WHERE SSN = 968574;

UPDATE Departments
    SET MGRSSN = 102672
    WHERE Dnum = 20;

UPDATE Employee
    SET Dno = 20
    WHERE SSN = 102672;

UPDATE Employee
    SET Superssn = 102672
    WHERE SSN = 102660;

--11
UPDATE Dependent
    SET ESSN = 102672
    WHERE ESSN = 223344;

UPDATE Departments 
    SET MGRSSN = 102672 , [MGRStart Date] = GETDATE()
    WHERE MGRSSN = 223344;

UPDATE Employee
    SET Superssn = 102672
    WHERE Superssn = 223344;

UPDATE Works_for 
    SET ESSN = 102672
    WHERE ESSN = 223344;

DELETE Employee 
WHERE SSN=223344;

--12
UPDATE Employee 
SET Salary += (30 * Salary) / 100
WHERE SSN in(
        SELECT ESSn
FROM Project AS P join Works_for AS W On P.Pnumber = W.Pno
WHERE Pname = 'Al Rabwah');

