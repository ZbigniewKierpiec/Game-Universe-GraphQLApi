using GraphQL.Data;
using GraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.GqlTypes
{
    public class QueryType
    {


        public async Task<Games> GetGameByIdAsync([Service] ApplicationDbContext context, int id)
        {
            return await context.Games.FindAsync(id);
        }



        public async Task<List<Games>> AllGamesAsync([Service]ApplicationDbContext context)
        {
            return await context.Games.ToListAsync();
        }



    }
}
