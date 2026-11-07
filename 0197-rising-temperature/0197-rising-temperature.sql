select w1.id 
from Weather w1
INNER JOIN Weather w2 ON DATEdiff(DAY , w2.recordDate ,w1.recordDate) = 1 
WHERE w1.temperature > w2.temperature;