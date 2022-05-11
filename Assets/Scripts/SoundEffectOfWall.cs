/*
 * Duvarlara bir şey çarptığında ses efekti olsun diye bu script yapılmıştır
 */
using UnityEngine;

public class SoundEffectOfWall : MonoBehaviour
{
   [SerializeField] private AudioClip _audio;

   private void OnCollisionEnter2D(Collision2D col)
   {
      AudioSource.PlayClipAtPoint(_audio,transform.position);
   }
}
