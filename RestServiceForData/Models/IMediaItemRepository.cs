using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceForData.Models
{
    public interface IMediaItemRepository
    {
        IQueryable<MediaItem> MediaItems { get; }
        MediaItem GetById(int id);
        void SaveMediaItems(MediaItem mediaItem);
    }
}
