using UnityEngine;

public class SceneGameController : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Instance.StopMusic();
    }
}
