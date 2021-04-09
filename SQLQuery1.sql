create database Student3
go
use Student3
go

create table logen
(
loge varchar(20) primary key identity,
pwd varchar(20) not null
)
go
create table classes
(
Id int primary key identity,
ClassName varchar(20) not null
)
go
create table stuinfo
(
Id int primary key identity,
Name varchar(20) not null,
Age int not null,
Mobile varchar(20) not null,
Email varchar(20) not null,
ClassId int references classes(Id)  not null,
AddTime datetime  default(getdate())
)
go
insert into logen values('asd','123456')
go
insert into classes values('.net')
insert into classes values('java')
insert into classes values('ÆóĞÅ')
insert  into stuinfo values('¶­´óÌÎ',20,'13811111111','346@qq.com',1,default)
insert  into stuinfo values('ÕÔÏÈ¾ü',21,'13822222222','345@qq.com',2,default)
insert  into stuinfo values('¶­ÏÈÉú',22,'13833333333','347@qq.com',3,default)
insert  into stuinfo values('ËïÎò¿Õ',12,'13811111121','34111@qq.com',1,default)
insert  into stuinfo values('Öí°Ë½ä',11,'13822222121','3422@qq.com',2,default)
insert  into stuinfo values('ÌÆÉ®',23,'138333333121','3433@qq.com',3,default)
insert  into stuinfo values('É³É®',30,'13811111222','3444@qq.com',1,default)
insert  into stuinfo values('ÄÈÔú',45,'13822222223','3455@qq.com',2,default)
insert  into stuinfo values('Àî¾¸',67,'13833333343','34666@qq.com',3,default)
go
select * from classes
go
select * from stuinfo
go
