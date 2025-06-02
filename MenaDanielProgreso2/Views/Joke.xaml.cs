using MenaDanielProgreso2.Services;

namespace MenaDanielProgreso2.Views;

public partial class Joke : ContentPage
{
    private readonly JokeService _jokeService;
    public Joke()
	{
		InitializeComponent();
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://official-joke-api.appspot.com/random_joke")
        };
        _jokeService = new JokeService(httpClient);
        LoadJoke();
    }
    private async void LoadJoke()
    {
        try
        {
            var joke = await _jokeService.GetRandomJokeAsync();
            SetupLabel.Text = joke.setup;
            PunchlineLabel.Text = joke.punchline;
        }
        catch (Exception ex)
        {
            SetupLabel.Text = $"Error fetching joke: {ex.Message}";
        }
    }
}