ALTER FUNCTION fnCompanions (
	@episodeId int
)
RETURNS varchar(MAX) AS
BEGIN
	DECLARE @return_value varchar(MAX)

	SET @return_value = (
		SELECT STRING_AGG(CompanionName, ', ') AS Result FROM tblCompanion
		INNER JOIN tblEpisodeCompanion ON tblCompanion.CompanionId = tblEpisodeCompanion.CompanionId
		WHERE tblEpisodeCompanion.EpisodeId = @episodeId
	);

	RETURN @return_value
END;

GO

SELECT dbo.fnCompanions(1) as result