CREATE FUNCTION fnEnemies (
	@episodeId int
)
RETURNS varchar(MAX) AS
BEGIN
	DECLARE @return_value varchar(MAX)

	SET @return_value = (
		SELECT STRING_AGG(EnemyName, ', ') AS Result FROM tblEnemy
		INNER JOIN tblEpisodeEnemy ON tblEnemy.EnemyId = tblEpisodeEnemy.EnemyId
		WHERE tblEpisodeEnemy.EpisodeId = @episodeId
	);

	RETURN @return_value
END;

GO

SELECT dbo.fnEnemies(1) as result