/* Write your T-SQL query statement below */
select user_id , UPPER(LEFT(name,1)) + LOWER(SUBSTRING(name,2,len(name)))  as name
from Users
ORDER BY user_id  ;