CREATE OR ALTER PROCEDURE spSummariseEpisodes
AS BEGIN

  SELECT TOP 3 tblEpisodeCompanion.CompanionId,
		 tblCompanion.CompanionName,
		 COUNT(tblEpisodeCompanion.CompanionId) AS CompanionAppearing
  FROM tblEpisodeCompanion
  INNER JOIN tblCompanion ON tblEpisodeCompanion.CompanionId = tblCompanion.CompanionId
  GROUP BY tblEpisodeCompanion.CompanionId, tblCompanion.CompanionName
  ORDER BY CompanionAppearing DESC;

  SELECT TOP 3 tblEpisodeEnemy.EnemyId,
		 COUNT(tblEpisodeEnemy.EnemyId) AS EnemyAppearing,
		 tblEnemy.EnemyName
  FROM tblEpisodeEnemy
  INNER JOIN tblEnemy ON tblEpisodeEnemy.EnemyId = tblEnemy.EnemyId
  GROUP BY tblEpisodeEnemy.EnemyId, tblEnemy.EnemyName
  ORDER BY EnemyAppearing DESC;

END;

EXEC spSummariseEpisodes;