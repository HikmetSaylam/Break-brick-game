/*
 * Oyun'un her sahnesinde müziğin bölünmeden çalışması için bu script yapılmıştır
 */
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private static bool _isThereMusic;
    private void Start()
    {
        if (!_isThereMusic)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            _isThereMusic = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
