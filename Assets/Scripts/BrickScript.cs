/*
 * Tuğlaların sprite atamaları çarpışma testleri yapmak için bu script yapılmıştır
 */


using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickScript : MonoBehaviour
{
    private SceneScript _sceneScript;

    [SerializeField] private Sprite[] sprites;
    private int _maxCollisionNum;
    private int _collisionCounter;

    private void Awake()
    {
        _sceneScript = GameObject.Find("SceneManager").GetComponent<SceneScript>();
    }

    private void Start()
    {
        
        _maxCollisionNum = sprites.Length + 1; // her vuruştan sonra tuğla diğer sprite'a geçmek ve spriteler bitince tuğlanın yok edilmesi için bu değişken kullanılıyor
        _collisionCounter = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("Circle"))
        {
            _collisionCounter++;
            if (_collisionCounter >= _maxCollisionNum)
            {
                _sceneScript.DecreaseNumOfBrick(1);
                Destroy(this.gameObject);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite=sprites[_collisionCounter-1]; //max vuruş sayısı aşılmadığı sürece tuğla diğer sprite'a geçiyor
            }

            if (_sceneScript.GetNumOfBrick() == 0)
            {
                StartScript.gameState = StartScript.GameState.Win;
                SceneManager.LoadScene("EntryScene");
            }
        }
    }
    
}
