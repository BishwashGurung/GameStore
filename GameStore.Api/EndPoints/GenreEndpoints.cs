using GameStore.Api.Data;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.EndPoints;

public static class GenreEndpoints
{
    public static RouteGroupBuilder MapGenreEndPoints(this WebApplication app)
    {
        var group = app.MapGroup("genres");

        // GET /genres
        group.MapGet("/", async (GameStoreContext dbContext) => 
            await dbContext.Genres
                        .Select(genre => genre.ToDto())
                        .AsNoTracking()
                        .ToListAsync()
        );
        return group;
    }
}
