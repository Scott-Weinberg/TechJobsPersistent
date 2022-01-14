--Part 1
SELECT * FROM jobs;

--Part 2
SELECT name FROM employers
WHERE location = "St. Louis City";
--Part 3
SELECT jobs.name, description FROM jobs
INNER JOIN jobskills
		ON jobskills.JobId = jobs.id
        INNER JOIN skills
			ON jobskills.SkillId = skillId
Where skills.Description Is NOT NULL;
