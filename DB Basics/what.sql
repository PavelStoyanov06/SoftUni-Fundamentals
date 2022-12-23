#CREATE DATABASE `softuni`;
USE `softuni`;

SELECT * FROM `students`
WHERE `grade` = 5 AND `first_name` = 'Linda'
/*SELECT * FROM `students`
WHERE `grade` >= 5
ORDER BY `grade` DESC;*/
/*SELECT * FROM `students`
WHERE `first_name` = 'Linda';*/
#DROP DATABASE `softuni`;
#DROP TABLE `students`;
#TRUNCATE TABLE `students`;
/*SELECT `last_name`, `grade` FROM `students`
LIMIT 5;*/
/*SELECT * FROM `students`
LIMIT 5;*/
#SELECT `first_name`, `age`, `grade` FROM `students`
#SELECT * FROM `students`;
/*CREATE TABLE `students`(
	`id` INT AUTO_INCREMENT PRIMARY KEY,
    `first_name` VARCHAR(50),
    `last_name` VARCHAR(50),
    `age` INT,
    `grade` DOUBLE
);*/
/*INSERT INTO `students` (`first_name`, `last_name`, `age`, `grade`)
VALUES
('Guy', 'Gilbert', 15, 4.5),
('Kevin', 'Brown', 17, 5.4),
('Roberto', 'Tamburello', 19, 6),
('Linda', 'Smith', 18, 5),
('John', 'Stones', 16, 4.25),
('Nicole', 'Nelson', 17, 5.50);*/