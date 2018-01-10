using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovieScreen : MonoBehaviour {
    private Camera camera;
    private float screenWidth = 0f;
    private float screenHeight = 0f;
    private int pixelsToUnityUnits = 100; //The documented pixel to unit(y) ratio
    private float aspectRatio = 0f;

    //public MovieTexture movie;
    public AudioSource audio;

    // Use this for initialization
    void Start ()
    {
        camera = FindObjectOfType<Camera>();
        GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Texture");

        //PlayMovie();
    }
	
	// Update is called once per frame
	void Update ()
    {
        ScaleToScreen();
	}

    void ScaleToScreen()
    {
        aspectRatio = Screen.width / (float)Screen.height; // in respect to width
        screenHeight = (camera.orthographicSize * 2 * pixelsToUnityUnits);
        screenWidth = (screenHeight * aspectRatio);

        this.transform.localScale = new Vector2(screenWidth / pixelsToUnityUnits, screenHeight / pixelsToUnityUnits);
    }

    public void PlayMovie(MovieTexture m)
    {
        try { GetComponent<Renderer>().material.mainTexture = m; }
        catch { GetComponent<RawImage>().material.mainTexture = m; }

        m.loop = false;
        m.Play();
        audio = GetComponent<AudioSource>();
        audio.clip = m.audioClip;
        audio.Play();

        Debug.Log("Playing");
    }

    public void PauseMovie(MovieTexture m)
    {
        m.Pause();
        audio.Pause();
        Debug.Log("Paused");
    }

    public void UnPauseMovie(MovieTexture m)
    {
        m.Play();
        audio.UnPause();
        Debug.Log("Resumed");
    }
}
