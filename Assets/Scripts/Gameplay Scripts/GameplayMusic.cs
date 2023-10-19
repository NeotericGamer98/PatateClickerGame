using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] musicTracks;

    private int currentTrackIndex = 0;

    void Start()
    {
        // Ensure the audio source is assigned.
        if (audioSource == null)
        {
            Debug.LogError("Audio source is not assigned.");
            enabled = false; // Disable the script.
        }
    }

    // Start playing the gameplay music tracks in sequential order.
    public void PlayGameplayMusic()
    {
        if (musicTracks.Length == 0)
        {
            Debug.LogWarning("No music tracks assigned.");
            return;
        }

        // Check if the current track index is within the bounds of the array.
        if (currentTrackIndex < musicTracks.Length)
        {
            audioSource.clip = musicTracks[currentTrackIndex];
            audioSource.Play();
            currentTrackIndex++;
        }
        else
        {
            // If all tracks have been played, reset to the first track.
            currentTrackIndex = 0;
            audioSource.clip = musicTracks[currentTrackIndex];
            audioSource.Play();
            currentTrackIndex++;
        }
    }
}
