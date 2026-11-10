/* Write your T-SQL query statement below */
select teacher_id ,Count(DISTINCT(subject_id)) as cnt
from Teacher
GROUP BY teacher_id ;