CREATE TABLE Patients (
    PatientId INT PRIMARY KEY,
    FullName VARCHAR(100),
    Phone VARCHAR(15)
);


CREATE TABLE TestReports (
    TestId INT PRIMARY KEY,
    PatientId INT,
    TestName VARCHAR(100),
    Status VARCHAR(20) 
);


INSERT INTO Patients VALUES (101, 'Abir Hasan', '01711223344');
INSERT INTO Patients VALUES (102, 'Sultana Razia', '01911223344');
INSERT INTO Patients VALUES (103, 'Sarah Johnson', '01511223344');


INSERT INTO TestReports VALUES (1, 101, 'Blood Test', 'Pending');
INSERT INTO TestReports VALUES (2, 102, 'X-Ray', 'Pending');
INSERT INTO TestReports VALUES (3, 103, 'MRI', 'Done');





DROP TABLE Patients;

CREATE TABLE Patients (
    PatientId INT PRIMARY KEY,
    FullName VARCHAR(100),
    Phone VARCHAR(15),
    PaidAmount INT 
);

INSERT INTO Patients VALUES (101, 'Abir Hasan', '01711223344', 5000);
INSERT INTO Patients VALUES (102, 'Sultana Razia', '01911223344', 3500);
INSERT INTO Patients VALUES (103, 'Sarah Johnson', '01511223344', 4000);


--ager tabel ea notun kisu add korsi
DROP TABLE Patients;

CREATE TABLE Patients (
    PatientId VARCHAR(50) PRIMARY KEY, 
    FullName VARCHAR(100),
    RegDate VARCHAR(20),
    DOB VARCHAR(20),
    Gender VARCHAR(20),
    BloodGroup VARCHAR(10),
    Phone VARCHAR(15),
    EmergencyContact VARCHAR(15),
    PaidAmount INT
);