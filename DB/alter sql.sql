alter table administrator AUTO_INCREMENT = 100000000;
insert into administrator(username,password)values('test11','test');
insert into administrator(username,password)values('test11',uuid());
select * from administrator
select uuid_short();
delete from administrator
select * from customer_account