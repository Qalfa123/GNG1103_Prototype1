using GLTF.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableData : MonoBehaviour
{
    [TextArea]
    public string Subtitles;
    public AudioSource SoundSource;
    public SubtitleManager manager;
    public float getSubtitleDuration()
    {
        return SoundSource.clip.length;
    }
    // Start is called before the first frame update
    void Start()
    {
      if(SoundSource == null)
        {
            SoundSource = GetComponent<AudioSource>();
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
