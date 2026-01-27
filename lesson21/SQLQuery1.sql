--select * from Players;
--select * from Teams;
--select * from Trainers;

--alter table Players add Salary int;

--update Players set Salary = (Players.Age / 10)* Teams.Rate from Teams left join Players on Teams.TeamId=Players.TeamId ;

create trigger Salary_Calculation_Update_Insert
on Players
after UPDATE, insert
as update Players set Salary = Players.Age * Teams.Rate / 10 from Teams left join Players on Teams.TeamId=Players.TeamId where PlayerId = (select PlayerId from inserted) ;


insert into Players (PlayerId, Name, TeamId)
Values (16, 'Rock', 1);

update Players set Age = 25 Where PlayerId = 16
update Players set Age = 22 Where PlayerId = 1

select * from Players