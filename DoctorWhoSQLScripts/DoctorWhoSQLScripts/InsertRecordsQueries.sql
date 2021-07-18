-- 1) This statement insert 5 records to tblEnemy
INSERT INTO tblEnemy (
	EnemyName,
	Description 
)
VALUES 
	(
		'Eric Cartman',
		'Eric Theodore Cartman, often referred to just by his surname, ......'
	),
	(
		'Vicky',
		'Vicky is one of the two main antagonists of Nickelodeons The Fairly OddParents.'
	),
	(
		'Stewie Griffin',
		'Stewart Gilligan "Stewie" Griffin is a main character from the animated television series Family Guy. ......'
	),
	(
		'Maleficent',
		'Maleficent is the main antagonist of Disneys 1959 animated feature film Sleeping Beauty.......'
	),
	(
		'Mr. Pickles ',
		NULL
	);

-- 2) This statement insert 5 records to tblAuthor
INSERT INTO tblAuthor(
	AuthorName	
)
VALUES 
	(
		'Stephen Hillenburg'
	),
	(
		'Craig McCracken'
	),
	(
		'Genndy Tartakovsky'
	),
	(
		'Alex Hirsch'
	),
	(
		'Butch Hartman'
	);

-- 3) This statement insert 5 records to tblDoctor
INSERT INTO tblDoctor(
	DoctorNumber,
	DoctorName,
	BirthDate,
	FirstEpisodeDate,
	LastEpisodeDate
)
VALUES 
	(
		1,
		'Dr. William A. Abdu, M.D, M.S.',
		'1961-03-15',
		'2014-08-11',
		'2019-09-08'
	),
	(
		2,
		'Dr. Myles. B. Abbott, M.D.',
		'1961-03-15',
		'2014-08-11',
		'2019-09-08'
	),
	(
		3,
		'Dr. Fouad. M. Abbas, M.D.',
		'1961-03-15',
		'2014-08-11',
		'2019-09-08'
	),
	(
		4,
		'Dr. Khalid Abbed, M.D.',
		'1961-03-15',
		'2014-08-11',
		'2019-09-08'
	),
	(
		5,
		'Dr. Naresh Trehan',
		'1961-03-15',
		NULL,
		NULL
	);

