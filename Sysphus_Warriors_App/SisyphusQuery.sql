
Select * from Member
select * from Member where Nom ='Monsif'
select * from Member where Nom ='Bahim'
use [SisyphusWarriors]

create table Member(
CIN varchar(30) primary key Not null,
Nom varchar(30) Not null,
Telephone varchar(30) Not null ,
Age int not null,
Sexe varchar(15) not null,
Date_inscription date not null,
Participation_Comp varchar(15) not null,
)
drop table [dbo].[Member]

select * from Member

drop table Member
create table Loginn (
Nom_Utilisateur varchar(30) not null,
Mode_Passe varchar(30) Not null
)
insert into Loginn values ('admin' ,'admin'),('Admin','Admin'),('guest','guest'),('Guest','Guest')

Select * Loginn where Nom_Utilisateur = 'admin'


select Nom from Member  where CIN = 'E404'

