/*
 * Sahne'nin gereken değişkenlerinin atanması ve o değişkenlerin kullanımı için bu script yapılmıştır
 */

using UnityEngine;

public class SceneScript : MonoBehaviour
{
    [SerializeField] private SceneType sceneType;
    private  int _numOfBrick;
    private  float _speedOfCircle;
    private  Vector2 _powerOfThrowing;
    private void Start()
    {
        _numOfBrick = sceneType.GetNumOfBrick();
        _speedOfCircle = sceneType.GetSpeedOfCircle();
        _powerOfThrowing = sceneType.GetPowerOfThrowing();
    }

    public int GetNumOfBrick()
    {
        return _numOfBrick;
    }

    public void DecreaseNumOfBrick(int value)
    {
        _numOfBrick -= value;
    }
    
    public float GetSpeedOfCircle()
    {
        return _speedOfCircle;
    }

    public Vector2 GetPowerOfThrowing()
    {
        return _powerOfThrowing;
    }
    

}
