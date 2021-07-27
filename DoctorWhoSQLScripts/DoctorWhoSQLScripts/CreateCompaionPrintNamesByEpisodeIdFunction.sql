CREATE OR ALTER FUNCTION fnCompanions (
	@episodeId int
)
RETURNS varchar(MAX) AS
BEGIN
	DECLARE @companion_names varchar(MAX)

	SET @companion_names = (
		SELECT STRING_AGG(CompanionName, ', ') AS Result FROM tblCompanion
		INNER JOIN tblEpisodeCompanion ON tblCompanion.CompanionId = tblEpisodeCompanion.CompanionId
		WHERE tblEpisodeCompanion.EpisodeId = @episodeId
	);

	RETURN @companion_names
END;

GO

SELECT dbo.fnCompanions(1) as result