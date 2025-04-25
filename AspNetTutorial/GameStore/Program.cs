using GameStore.Dto;
using GameStore.Utils;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

List<GameDto> games = Games.GetGames();

// Get /games
app.MapGet("games", () => games);

// Get /games/id
app.MapGet("games/{id:int}", (int id) => games.Find(game => game.Id == id));

app.Run();