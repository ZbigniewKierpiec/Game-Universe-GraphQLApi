using GraphQL.Data;
using GraphQL.Data.Entities;

namespace GraphQL.GqlTypes
{
    public class MutationType
    {

        
        public async Task<Games> SaveGameAsync([Service] ApplicationDbContext context , Games newGame)
        {
            context.Games.Add(newGame);
            await context.SaveChangesAsync();
               return newGame;
        }

        
        public async Task<Games> UpdateGameAsync([Service] ApplicationDbContext context, Games updateGame)
        {
            context.Games.Update(updateGame);
            await context.SaveChangesAsync();
            return updateGame;
        }

        



        public async Task<string> DeleteGameAsync([Service] ApplicationDbContext context ,int id )
        { 
             var gameToDelete = await context.Games.FindAsync(id);
            if (gameToDelete == null)
            {
                return "Invalid opertaion";
            }
            context.Games.Remove(gameToDelete);
            await context.SaveChangesAsync();
            return "Game was Deleted Sucessfully";

        }



    }
}
