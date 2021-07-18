DELETE tblCompanion
FROM tblCompanion 
INNER JOIN tblEpisodeCompanion ON tblEpisodeCompanion.CompanionId = tblCompanion.CompanionId
WHERE EpisodeId IS NULL;