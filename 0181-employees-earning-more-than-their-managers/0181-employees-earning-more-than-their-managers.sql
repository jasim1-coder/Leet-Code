/* Write your T-SQL query statement below */
SELECT f.name as Employee
FROM Employee e
INNER JOIN Employee f ON e.id = f.managerId
WHERE e.salary < f.salary;