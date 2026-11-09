/* Write your T-SQL query statement below */
select user_id , Count(*) as followers_count
from Followers 
Group by user_id ;