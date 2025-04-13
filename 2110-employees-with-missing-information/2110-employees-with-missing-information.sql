/* Write your T-SQL query statement below */
SELECT employee_id FROM Employees
UNION
SELECT employee_id FROM Salaries
EXCEPT
SELECT employee_id FROM Employees
INTERSECT
SELECT employee_id FROM Salaries