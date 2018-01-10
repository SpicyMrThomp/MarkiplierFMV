using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieManager : MonoBehaviour {
    public static MovieManager instance = null;

    public Movie movie;
    public MovieScreen movieScreen;
    public Material material;
    private int key = 1;
    public string title = " ";
    private bool paused = false;
    public float currentTime;
    private float option1Time, option2Time, option3Time, option4Time;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        title = Library.GetFileName(key);
        movie = new Movie(Resources.Load<MovieTexture>("Movies\\" + title));
        movieScreen = GameObject.FindGameObjectWithTag("Player").GetComponent<MovieScreen>();
        movieScreen.PlayMovie(movie.GetMovie());

        SetOptionTime();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Checks for end of movie
        if (!movie.GetMovie().isPlaying && !paused)
        {
            //Checks for ending
            if(Library.DoesKeyExist(key, Library.GetEndingDictionary()))
            {
                key = 1;
                ChooseMovie(key);
            }
            else
                RandomChoice(movie);
        }
        else
            currentTime = movieScreen.audio.time;

        //Checks when the options appear
        CheckOptionTime(currentTime);
	}

    public void CheckOptionTime(float time)
    {
        if (time >= option1Time && !RemoteManager.instance.GetOptionActive(1))
            RemoteManager.instance.SetOptionActive(1, true);
        else if(RemoteManager.instance.GetOptionActive(1) && time < option1Time)
            RemoteManager.instance.SetOptionActive(1, false);

        if (time >= option2Time && !RemoteManager.instance.GetOptionActive(2))
            RemoteManager.instance.SetOptionActive(2, true);
        else if (RemoteManager.instance.GetOptionActive(2) && time < option2Time)
            RemoteManager.instance.SetOptionActive(2, false);

        if (time >= option3Time && !RemoteManager.instance.GetOptionActive(3))
            RemoteManager.instance.SetOptionActive(3, true);
        else if (RemoteManager.instance.GetOptionActive(3) && time < option3Time)
            RemoteManager.instance.SetOptionActive(3, false);

        if (time >= option4Time && !RemoteManager.instance.GetOptionActive(4))
            RemoteManager.instance.SetOptionActive(4, true);
        else if (RemoteManager.instance.GetOptionActive(4) && time < option4Time)
            RemoteManager.instance.SetOptionActive(4, false);
    }

    public void RandomChoice(Movie m)
    {
        int range = 1;
        int outValue = 0;
        int option = 0;

        if (Library.GetOption1().TryGetValue(key, out outValue))
            range++;
        if (Library.GetOption2().TryGetValue(key, out outValue))
            range++;
        if (Library.GetOption3().TryGetValue(key, out outValue))
            range++;
        if (Library.GetOption4().TryGetValue(key, out outValue))
            range++;

        option = Random.Range(1, option);
        ChooseMovie(key, option);
    }

    public void ChooseMovie(int k, int op = 0)
    {
        if (op > 0)
            key = Library.GetOption(k, op);
        else
            key = k;

        title = Library.GetFileName(key);
        movie = new Movie(Resources.Load<MovieTexture>("Movies\\" + title));
        movieScreen = GameObject.FindGameObjectWithTag("Player").GetComponent<MovieScreen>();
        movieScreen.PlayMovie(movie.GetMovie());

        RemoteManager.instance.Reset();
        SetOptionTime();
    }

    public void SetPause(bool p)
    {
        if (p)
            movieScreen.PauseMovie(movie.GetMovie());
        else
            movieScreen.UnPauseMovie(movie.GetMovie());
        paused = p;
    }

    public bool GetPause()
    {
        return paused;
    }

    public int GetKey()
    {
        return key;
    }

    public void SetOptionTime()
    {
        option1Time = Library.GetOptionTime(key, 1);
        option2Time = Library.GetOptionTime(key, 2);
        option3Time = Library.GetOptionTime(key, 3);
        option4Time = Library.GetOptionTime(key, 4);
    }
}
