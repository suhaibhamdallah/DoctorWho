CREATE OR ALTER FUNCTION fnEnemies (
	@episodeId int
)
RETURNS varchar(MAX) AS
BEGIN
	DECLARE @enemy_names varchar(MAX)

	SET @enemy_names = (
		SELECT STRING_AGG(EnemyName, ', ') AS Result FROM tblEnemy
		INNER JOIN tblEpisodeEnemy ON tblEnemy.EnemyId = tblEpisodeEnemy.EnemyId
		WHERE tblEpisodeEnemy.EpisodeId = @episodeId
	);

	RETURN @enemy_names
END;

GO

SELECT dbo.fnEnemies(1) as result