CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId VARCHAR(50) UNIQUE NOT NULL ,
    Password VARCHAR(100) NOT NULL
);

INSERT INTO Users (UserId, Password)
VALUES 
('patient1', 'abcd'),
('patient2', 'efgh'),
('patient3', 'ijkl'),
('patient4', 'mnop'),
('patient5', 'qrst'),

('admin' , 'khulja');

select * from Users
where UserId='patient3'
and Password = 'ijkl'