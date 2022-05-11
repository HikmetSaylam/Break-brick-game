/*
 * oyun başlamadan önce top'un pedalla birlikte hareket etmesi için ve oyun başladıktan sonra gereken çarpışma
 * testleri için bu script yapılmıştır
 * 
 */


using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleScript : MonoBehaviour
{
    private SceneScript _sceneScript;
    private GameObject _pedal;
    private bool _isClicked;

    private void Awake()
    {
        _sceneScript = GameObject.Find("SceneManager").GetComponent<SceneScript>();
        _pedal = GameObject.FindObjectOfType<PedalScript>().gameObject;
    }
    
    
    private void FixedUpdate()
    {
        if (!_isClicked)
        {
            transform.position = new Vector3(_pedal.transform.position.x,
                _pedal.transform.position.y+0.3f, //pedal'in biraz üstünde durması için 0.3 eklenmiştir
                1f);
            if (Input.GetKey(KeyCode.Mouse0))
            {
                GetComponent<Rigidbody2D>().AddForce(_sceneScript.GetPowerOfThrowing());
                _isClicked = true;
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("lowerWall")) //Oyuncu, oyunun alt sınırını geçince oyunu kaybeder
        {
            StartScript.gameState = StartScript.GameState.Lose;
            SceneManager.LoadScene("EntryScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("Pedal"))
        {
            if(Input.GetKey(KeyCode.Mouse0)) //top pedala dokunduğunda mousce'a tıklanırsa top hızlanır
                GetComponent<Rigidbody2D>().AddForce(new Vector2(20f,_sceneScript.GetSpeedOfCircle()));
        }
    }
}
