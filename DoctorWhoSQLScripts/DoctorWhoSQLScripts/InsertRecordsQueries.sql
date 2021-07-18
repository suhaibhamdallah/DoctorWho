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

-- 4) This statement insert 5 records to tblCompanion
INSERT INTO tblCompanion(
	CompanionName,
	WhoPlayed
)
VALUES 
	(
		'Suhaib Hamdallah',
		NULL
	),
	(
		'Anas Zakarneh',
		NULL
	),
	(
		'Mohammad Abu-Qasedo',
		NULL
	),
	(
		'Zaid Noor',
		NULL
	),
	(
		'Yazan Fouqha',
		NULL
	);

-- 5) This statement insert 5 records to tblEpisode
INSERT INTO tblEpisode(
	SeriesNumber,
	EpisodeNumber,
	EpisodeType,
	EpisodeTitle,
	EpisodeDate,
	AuthorId,
	DoctorId,
	Notes
)
VALUES 
	(
		1,
		1,
		'TYPE 1',
		'Title 1.1',
		'2018-01-01',
		1,
		1,
		NULL
	),
	(
		1,
		2,
		'TYPE 2',
		'Title 1.2',
		'2018-01-02',
		2,
		2,
		NULL
	),
	(
		1,
		3,
		'TYPE 1',
		'Title 1.3',
		'2018-01-03',
		3,
		3,
		NULL
	),
	(
		1,
		4,
		'TYPE 2',
		'Title 1.4',
		'2018-01-04',
		4,
		4,
		NULL
	),
	(
		1,
		5,
		'TYPE 3',
		'Title 1.5',
		'2018-01-05',
		5,
		NULL,
		NULL
	);

-- 6) This statement insert 5 records to tblEpisodeCompanion
INSERT INTO tblEpisodeCompanion(
	EpisodeId,
	CompanionId
)
VALUES 
	(
		1,
		1
	),
	(
		2,
		2
	),
	(
		1,
		3
	),
	(
		4,
		1
	),
	(
		NULL,
		5
	);

-- 7) This statement insert 5 records to tblEpisodeEnemy
INSERT INTO tblEpisodeEnemy(
	EpisodeId,
	EnemyId
)
VALUES 
	(
		1,
		1
	),
	(
		2,
		2
	),
	(
		3,
		3
	),
	(
		4,
		4
	),
	(
		5,
		5
	);
