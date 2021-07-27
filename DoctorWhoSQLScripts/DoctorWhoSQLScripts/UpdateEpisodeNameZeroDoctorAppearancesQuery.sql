UPDATE [tblEpisode]
SET [EpisodeTitle] = CONCAT([tblEpisode].[EpisodeTitle], '_CANCELLED')
WHERE tblEpisode.DoctorId IS NULL;