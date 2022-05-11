/*
 * pedalin hareketini mouce'a tabi tutmak için bu script yapılmıştır
 */


using System;
using UnityEngine;

public class PedalScript : MonoBehaviour
{
    [SerializeField] private AudioClip _audio;
    private void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, 1f));
        float x = Mathf.Clamp(mousePos.x, -7, 7); //pedal ekranın dışına çıkmaması için x'i -7 ile +7 arasında sınırlandırılmıştır
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.PlayClipAtPoint(_audio,transform.position);
    }
}
