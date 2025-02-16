/* Write your T-SQL query statement below */
UPDATE Salary
SET sex = CASE
WHEN sex = 'f' THEN 'm'
WHEN sex = 'm' THEN 'f'
End
WHERE sex in ('m','f')
;