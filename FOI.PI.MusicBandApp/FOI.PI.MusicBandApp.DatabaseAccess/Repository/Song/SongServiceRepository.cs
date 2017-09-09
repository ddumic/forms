using FOI.PI.MusicBandApp.Contracts.Song;
using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts;
using System.Linq;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository.Song
{
    public class SongServiceRepository : ISongServiceRepository
    {
        public ErrorDto AddSong(SongDto song)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Pjesma.Add(new Pjesma()
                {
                    godina_izdanja = song.Year,
                    id_zanr = song.Genre.Id,
                    izvodac = song.Performer,
                    naziv = song.Name,
                    trajanje = song.Duration
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public ErrorDto AddBandSong(int bandId, int songId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var song = db.Pjesma.FirstOrDefault(x => x.id_pjesma == songId);
                db.Bend.FirstOrDefault(x => x.id_bend == bandId).Pjesma1.Add(song);
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public ErrorDto DeleteSong(int bandId, int songId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var band = db.Bend.Where(x => x.id_bend == bandId).FirstOrDefault();
                band.Pjesma1.Remove(band.Pjesma1.FirstOrDefault(x => x.id_pjesma == songId));
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public List<GenreDto> GetGenres()
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<GenreDto>();

                foreach (var genre in db.Zanr)
                {
                    responseDto.Add(new GenreDto()
                    {
                        Id = genre.id_zanr,
                        Description = genre.opis,
                        Name = genre.naziv
                    });
                }

                return responseDto;
            }
        }

        public List<SongDto> GetBandSongs(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<SongDto>();

                foreach (var song in db.Bend.Where(x => x.id_bend == bandId).FirstOrDefault().Pjesma1)
                {
                    responseDto.Add(new SongDto()
                    {
                        Duration = song.trajanje,
                        Genre = new GenreDto()
                        {
                            Description = song.Zanr.opis,
                            Id = song.Zanr.id_zanr,
                            Name = song.Zanr.naziv
                        },
                        Name = song.naziv,
                        Performer = song.izvodac,
                        Id = song.id_pjesma,
                        Year = song.godina_izdanja
                    });
                }

                return responseDto;
            }
        }

        public List<SongDto> GetAvailableSongs(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<SongDto>();

                foreach (var song in db.Pjesma.Where(x => x.Bend.id_bend != bandId))
                {
                    responseDto.Add(new SongDto()
                    {
                        Duration = song.trajanje,
                        Genre = new GenreDto()
                        {
                            Description = song.Zanr.opis,
                            Id = song.Zanr.id_zanr,
                            Name = song.Zanr.naziv
                        },
                        Name = song.naziv,
                        Performer = song.izvodac,
                        Id = song.id_pjesma,
                        Year = song.godina_izdanja
                    });
                }

                return responseDto;
            }
        }
    }
}
