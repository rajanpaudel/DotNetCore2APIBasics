using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceForData.Models
{
    public class EFMediaItemRepository : IMediaItemRepository
    {
        private ApplicationDbContext dbContext;
        public EFMediaItemRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IQueryable<MediaItem> MediaItems => dbContext.MediaItems;

        public void SaveMediaItems(MediaItem mediaItem)
        {
            if (mediaItem.Id == 0)
            {
                dbContext.MediaItems.Add(mediaItem);
            }
            else
            {
                var item = dbContext.MediaItems.FirstOrDefault(x => x.Id == mediaItem.Id);
                if (item != null)
                {
                    item.Name = mediaItem.Name;
                    item.Medium = mediaItem.Medium;
                    item.Category = mediaItem.Category;
                    item.Year = mediaItem.Year;
                    item.WatchedOn = mediaItem.WatchedOn;
                }
            }
            dbContext.SaveChanges();
        }

        public MediaItem GetById(int id)
        {
            return dbContext.MediaItems.FirstOrDefault(x => x.Id == id);
        }
    }
}
