using UnityEngine;
using UnityEngine.Video;

public class VideoToggle : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject Tv;

    public void ToggleVideo()
    {
        if (videoPlayer.isPlaying)
        {
            Tv.SetActive(false);
            videoPlayer.Stop();
        }
        else
        {
            Tv.SetActive(true);
            videoPlayer.Play();
        }
    }
}
