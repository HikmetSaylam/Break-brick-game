/*
 * Oyuncunun isteğine bağlı olarak level seçimi yapılması için bu script yapılmıştır
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour
{
    public void EasyButtonOnClick()
    {
        SceneManager.LoadScene("EasyLevelScene");
    }
    
    public void NormalButtonOnClick()
    {
        SceneManager.LoadScene("NormalLevelScene");
    }
    
    public void HardButtonOnClick()
    {
        SceneManager.LoadScene("HardLevelScene");
    }
}
