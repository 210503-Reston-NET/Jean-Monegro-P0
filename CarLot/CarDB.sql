drop table reviews
drop table CARINVENTORY
--table definition
create table CARINVENTORY
(
    id int identity primary key,
    name nvarchar(50) not null,
    year nvarchar(50) not null,
    mpg nvarchar(50) not null
);

INSERT INTO CARINVENTORY (name) values
('One'), ('Two'), ('Three');

