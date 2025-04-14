/* Write your T-SQL query statement below */
SELECT * 
FROM products
WHERE description LIKE '%SN____-____'  OR description LIKE '%SN____-____ %';
