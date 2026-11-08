/* Write your T-SQL query statement below */
select u.name , Sum(t.amount) as balance
from Users u
INNER JOIN Transactions t ON u.account = t.account 
group by u.account , u.name
Having sum(t.amount) > 10000

;