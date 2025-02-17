/* Write your T-SQL query statement below */
SELECT a.actor_id , a.director_id
FROM ActorDirector a
GROUP BY actor_id,director_id
Having COUNT(a.timestamp) >= 3;