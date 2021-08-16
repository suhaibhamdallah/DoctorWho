using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using DoctorWho.Web.Profiles;
using DoctorWho.Web.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DoctorWho.Web.Tests
{
    public class EpisodeServiceShould
    {
        private readonly Mock<IRepository<Episode, EpisodesView, int>> _episodeRepository;
        private IEpisodeService _episodeService;
        private readonly IMapper _mapper;

        public EpisodeServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new EpisodeProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _episodeRepository = new Mock<IRepository<Episode, EpisodesView, int>>();
        }

        [Fact]
        public async void GetEpisodes()
        {
            // -- Arrange 
            var collectionOfEpisodesShouldReturn = new List<EpisodesView>
            {
                new EpisodesView
                {
                    Id = 1,
                    AuthorId = 1,
                    AuthorName = "suhaib",
                    Companions = "suhaib, anas",
                    DoctorId = 5,
                    DoctorName = "Anas",
                    EpisodeDate = new DateTime(2017, 4, 5, 0, 0, 0),
                    EpisodeNumber = 2,
                    EpisodeTitle = "Title",
                    EpisodeType = "Type",
                    Enemies = "Ahmad",
                    SeriesNumber = 4, 
                    Notes = "Bla bla"
                }
            };

            _episodeRepository.Setup(p => p.FindAll()).ReturnsAsync(collectionOfEpisodesShouldReturn);

            _episodeService = new EpisodeService(_episodeRepository.Object, _mapper);

            // -- Act
            var actualCollectionOfEpisodes = await _episodeService.GetEpisodes();
            var expectedCollectionOfEpisodes = _mapper.Map<IEnumerable<EpisodeDto>>(collectionOfEpisodesShouldReturn);

            // -- Assert 
            Assert.NotStrictEqual(expectedCollectionOfEpisodes, actualCollectionOfEpisodes);
        }

        [Fact]
        public async void GetEpisode()
        {
            //-- Arrange
            var episodeToReturn = new EpisodesView
            {
                Id = 1,
                AuthorId = 1,
                AuthorName = "suhaib",
                Companions = "suhaib, anas",
                DoctorId = 5,
                DoctorName = "Anas",
                EpisodeDate = new DateTime(2017, 4, 5, 0, 0, 0),
                EpisodeNumber = 2,
                EpisodeTitle = "Title",
                EpisodeType = "Type",
                Enemies = "Ahmad",
                SeriesNumber = 4,
                Notes = "Bla bla"
            };

            _episodeRepository.Setup(p => p.FindById(1)).ReturnsAsync(episodeToReturn);

            _episodeService = new EpisodeService(_episodeRepository.Object, _mapper);

            //-- Act
            var actualEpisode = await _episodeService.GetEpisode(1);
            var expectedEpisode = _mapper.Map<EpisodeDto>(episodeToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedEpisode, actualEpisode);
        }
    }
}
