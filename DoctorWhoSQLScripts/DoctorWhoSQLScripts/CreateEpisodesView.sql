CREATE OR ALTER VIEW viewEpisodes AS
SELECT  tblDoctor.DoctorName,
		tblAuthor.AuthorName,
		dbo.fnCompanions(tblEpisode.EpisodeId) as Companions,
		dbo.fnEnemies(tblEpisode.EpisodeId) as Enemies
FROM tblEpisode
LEFT JOIN tblAuthor ON tblAuthor.AuthorId = tblEpisode.AuthorId
LEFT JOIN tblDoctor ON tblDoctor.DoctorId = tblEpisode.DoctorId;
