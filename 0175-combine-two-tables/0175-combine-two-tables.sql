# Write your MySQL query statement below
SELECT p.firstName, p.lastName, city, state
FROM Person p
LEFT JOIN Address a ON p.personId = a.personId;
