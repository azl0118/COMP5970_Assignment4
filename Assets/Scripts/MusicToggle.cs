using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip trackA;
    public AudioClip trackB;

    private bool playA = true;

    void Start()
    {
        PlayCurrent();
    }

    void Update()
    {
        if (!musicSource.isPlaying)
        {
            playA = !playA;
            PlayCurrent();
        }
    }

    void PlayCurrent()
    {
        if (playA)
        {
            musicSource.clip = trackA;
        }
        else
        {
            musicSource.clip = trackB;
        }

        musicSource.Play();
    }
}