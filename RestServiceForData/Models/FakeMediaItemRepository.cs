using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceForData.Models
{
    public class FakeMediaItemRepository : IMediaItemRepository
    {
        public IQueryable<MediaItem> MediaItems => mediaItems.AsQueryable<MediaItem>();

        List<MediaItem> mediaItems = new List<MediaItem>();
        public FakeMediaItemRepository()
        {
            mediaItems.Add(media1);
            mediaItems.Add(media2);
            mediaItems.Add(media3);
            mediaItems.Add(media4);
            mediaItems.Add(media5);
            mediaItems.Add(media6);
            mediaItems.Add(media7);
        }
        public MediaItem GetById(int id)
        {
            return mediaItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMediaItems(MediaItem mediaItem)
        {
            mediaItem.Id = mediaItems.Count+1;
            mediaItems.Add(mediaItem);
        }
        MediaItem media1 = new MediaItem
        {
            Id = 1,
            Name = "Firebug",
            Medium = "Series",
            Category = "Science Fiction",
            Year = 2015,
            WatchedOn = 1236546
        };
        MediaItem media2 = new MediaItem
        {
            Id = 2,
            Name = "Fire Place",
            Medium = "Series",
            Category = "Science Fiction",
            Year = 2015,
            WatchedOn = 156498
        };
        MediaItem media3 = new MediaItem
        {
            Id = 3,
            Name = "Wooden wall",
            Medium = "Movies",
            Category = "True Story",
            Year = 2009,
            WatchedOn = 1234656546
        };
        MediaItem media4 = new MediaItem
        {
            Id = 4,
            Name = "Hammer Drill",
            Medium = "Movies",
            Category = "Science Fiction",
            Year = 2020,
            WatchedOn = 9658693
        };
        MediaItem media5 = new MediaItem
        {
            Id = 5,
            Name = "Door Slammed",
            Medium = "Series",
            Category = "Science Fiction",
            Year = 2021,
            WatchedOn = 6546
        };
        MediaItem media6 = new MediaItem
        {
            Id = 6,
            Name = "Cycle Race",
            Medium = "Movies",
            Category = "Reality Tv",
            Year = 2020,
            WatchedOn = 98745632
        };
        MediaItem media7 = new MediaItem
        {
            Id = 7,
            Name = "Firebug",
            Medium = "Series",
            Category = "Science Fiction",
            Year = 2011,
            WatchedOn = 963258
        };        
    }
}
