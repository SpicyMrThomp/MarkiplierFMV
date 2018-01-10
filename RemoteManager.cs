using UnityEngine;

public class RemoteManager : MonoBehaviour
{
    public static RemoteManager instance = null;
    private GameObject[] options = new GameObject[4];

    private void Start()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i] = GameObject.FindGameObjectWithTag("Option" + (i+1).ToString());
            SetOptionActive(i + 1, false);
        }
    }

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
    }

    public void PauseUnPauseMovie()
    {
        if (!MovieManager.instance.GetPause())
            MovieManager.instance.SetPause(true);
        else
            MovieManager.instance.SetPause(false);
    }

    public void SetOptionActive(int i, bool b)
    {
        if (b && Library.DoesKeyExist(MovieManager.instance.GetKey(), Library.GetOptionPosDictionary(i)))
        {
            SetOptionPosition(i, Library.GetOptionPos(MovieManager.instance.GetKey(), i));
            options[i - 1].SetActive(b);
        }
        else if(!b)
        {
            options[i - 1].SetActive(b);
        }
    }

    public bool GetOptionActive(int i)
    {
        return options[i - 1].activeInHierarchy;
    }

    public void SetOptionPosition(int i, Vector2 pos)
    {
        options[i - 1].transform.localPosition = pos;
    }

    public void Reset()
    {
        for(int i = 1; i <= options.Length; i++)
        {
            SetOptionActive(i, false);
        }
    }
}
