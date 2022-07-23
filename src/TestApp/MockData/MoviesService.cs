namespace TestApp.MockData;

public static class MoviesService
{
    public static List<Movie> GetMovies() =>
        new List<Movie>()
        {
            new() { Title = "Batman", Year = 1989, Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_.jpg" },
            new() { Title = "The Dark Knight", Year = 2008, Poster = "https://ia.media-imdb.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            new() { Title = "Batman v Superman: Dawn of Justice", Year = 2016, Poster = "https://ia.media-imdb.com/images/M/MV5BYThjYzcyYzItNTVjNy00NDk0LTgwMWQtYjMwNmNlNWJhMzMyXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            new() { Title = "The Dark Knight Rises", Year = 2012, Poster = "https://ia.media-imdb.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            //new() { Title = "Batman Begins", Year = 2005, Poster = "https://ia.media-imdb.com/images/M/MV5BYzc4ODgyZmYtMGFkZC00NGQyLWJiMDItMmFmNjJiZjcxYzVmXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            new() { Title = "The LEGO Batman Movie", Year = 2017, Poster = "https://ia.media-imdb.com/images/M/MV5BMTcyNTEyOTY0M15BMl5BanBnXkFtZTgwOTAyNzU3MDI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            //new() { Title = "Batman Forever", Year = 1995, Poster = "https://ia.media-imdb.com/images/M/MV5BNWY3M2I0YzItNzA1ZS00MzE3LThlYTEtMTg2YjNiOTYzODQ1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            new() { Title = "Batman & Robin", Year = 1997, Poster = "https://ia.media-imdb.com/images/M/MV5BMGQ5YTM1NmMtYmIxYy00N2VmLWJhZTYtN2EwYTY3MWFhOTczXkEyXkFqcGdeQXVyNTA2NTI0MTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
            new() { Title = "Batman Returns", Year = 1992, Poster = "https://ia.media-imdb.com/images/M/MV5BOGZmYzVkMmItM2NiOS00MDI3LWI4ZWQtMTg0YWZkODRkMmViXkEyXkFqcGdeQXVyODY0NzcxNw@@._V1_UX182_CR0,0,182,268_AL_.jpg" }
        };
}