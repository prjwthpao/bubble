using UnityEngine;

public class SceneWinController : MonoBehaviour
{
    public AudioClip musicClip;

    private void Start()
    {
        AudioManager.Instance.PlayMusic(musicClip);
    }
}
