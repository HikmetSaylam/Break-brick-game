/*
 * Oyunun başlangıç sahnesindeki mesajların görüntülemesi ve başla buttonun çalıştırılması için bu script yapılmıştır
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartScript : MonoBehaviour
{
    private static bool _isStarted;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;
    [SerializeField] private GameObject newGame;
    [SerializeField] private Text _text;
    [SerializeField] private AudioClip _audio; //oyun bitti ses efekti

    public enum GameState
    {
        Disabled,
        Win,
        Lose
    }

    public static GameState gameState;

    private void Start()
    {
        if (!_isStarted)
        {
            newGame.SetActive(true);
            _text.text = "START";
            _isStarted = true;
        }
        else
        {
            _text.text = "PLAY AGAIN";
            if (gameState.Equals(GameState.Win))
            {
                win.SetActive(true);
            }
            else if (gameState.Equals(GameState.Lose))
            {
                AudioSource.PlayClipAtPoint(_audio,transform.position);
                lose.SetActive(true);
            }

        }
    }
    public void StartButtonOnClick()
    {
        SceneManager.LoadScene("LevelScene");
    }
    
    public void QuitButtonOnClick()
    {
        Application.Quit();
    }

}
