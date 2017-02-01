using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCMusicStore.Models
{
    public class
        MusicStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MVCMusicStoreContext>
    {
        protected override void Seed(MVCMusicStoreContext context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            base.Seed(context);
        }

    }
}