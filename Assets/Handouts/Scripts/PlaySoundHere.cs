using UnityEngine;

public class PlaySoundHere : MonoBehaviour
{
    [SerializeField] private AudioClip audioToPlay;

    /// <summary>
    /// Uses the audio manager to play a given sound at its own location.
    /// </summary>
    public void PlaySound()
    {
        if (audioToPlay == null)
        {
            Debug.LogWarning("No audio set in" + gameObject.name);
            return;
        }

        if (SoundManager.Instance == null)
        {
            Debug.LogWarning("AudioManager not found, add it to the scene");
            return;
        }

        SoundManager.Instance.PlaySoundAtLocation(audioToPlay, transform.position);
    }
}
