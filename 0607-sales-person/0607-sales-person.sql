/* Write your T-SQL query statement below */
select s.name
from SalesPerson s
WHERE NOT EXISTS (
    SELECT 1 
    FROM Orders o
    INNER JOIN Company c ON o.com_id = c.com_id
    WHERE o.sales_id = s.sales_id and c.name = 'RED'
);