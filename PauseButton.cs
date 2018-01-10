using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AudioClip buttonSound;

    public virtual void OnPointerDown(PointerEventData ped)
    {
        this.gameObject.transform.localScale = new Vector3(.85f, .85f, .85f);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        RemoteManager.instance.PauseUnPauseMovie();
    }
}