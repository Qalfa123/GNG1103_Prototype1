using GLTF.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableData : MonoBehaviour
{
    [TextArea]
    public string Subtitles;
    public AudioSource SoundClip;
    public SubtitleManager manager;
    public float getSubtitleDuration()
    {
        return SoundClip.clip.length;
    }
    // Start is called before the first frame update
    void Start()
    {
      if(SoundClip == null)
        {
            SoundClip = GetComponent<AudioSource>();
        }
     if(manager == null)
        {
            // Find it ourselves
            manager = Object.FindObjectOfType<SubtitleManager>();
        }   
    }

    // Update is called once per frame
    public void StartInteraction()
    {
        manager.ShowText(Subtitles, getSubtitleDuration());
        GetComponent<AudioSource>().Play();
    }
}
