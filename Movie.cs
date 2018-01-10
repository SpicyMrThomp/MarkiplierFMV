using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Movie
{
    private MovieTexture movie;

    public Movie(MovieTexture m)
    {
        SetMovie(m);
    }

    public void SetMovie(MovieTexture m)
    {
        movie = m;
    }

    public MovieTexture GetMovie()
    {
        return movie;
    }
}
