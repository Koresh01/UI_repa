using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    private void Start()
    {
        myFx = transform.AddComponent<AudioSource>();
        hoverFx = Resources.Load<AudioClip>("Audio/pointerEnter");
        clickFx = Resources.Load<AudioClip>("Audio/pointerDown");
    }
    public void HoverSoud()
    {
        myFx.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }
}
