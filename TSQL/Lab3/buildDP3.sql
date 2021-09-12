
CREATE DATABASE UNIV;

CREATE TABLE course
(
  CID INT PRIMARY KEY IDENTITY,
  CNAME  VARCHAR(20),
  Duration INT

  CONSTRAINT C1 UNIQUE(Duration)
);

CREATE TABLE INSTRUCTOR
(
    INSID int PRIMARY KEY IDENTITY,
    Fname VARCHAR(20),
    Lname VARCHAR(20),
    Salary int DEFAULT  3000,
    hiredate date DEFAULT GETDATE(),
    BD date,
    AGE as YEAR(getDate() - YEAR(BD)),
    overTime int ,
    netSal as Salary + overTime,
    address VARCHAR(20),

    CONSTRAINT C2 check(Salary >= 1000 and Salary <= 5000),
    CONSTRAINT C3 UNIQUE(overTime),
    CONSTRAINT C4 check(address in ('alex' , 'cairo'))
);

CREATE TABLE teaches
(
    INID int FOREIGN KEY REFERENCES INSTRUCTOR(InSID) on delete cascade on update cascade,
    CID int FOREIGN KEY REFERENCES course(CID) on delete cascade on update cascade,

    CONSTRAINT C5 PRIMARY KEY NONCLUSTERED (INID,CID)
);


CREATE TABLE LABEL 
(
  LID  int FOREIGN KEY REFERENCES INSTRUCTOR(InSID) on delete cascade on update cascade , 
  LOCATION VARCHAR(20) , 
  Capicity int,
  CID int FOREIGN KEY REFERENCES course(CID) on delete cascade on update cascade,
  
  CONSTRAINT C6 check(Capicity < 20),
  CONSTRAINT C7 PRIMARY KEY NONCLUSTERED (LID , CID)
);


