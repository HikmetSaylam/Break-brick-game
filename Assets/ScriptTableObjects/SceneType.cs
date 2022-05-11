using UnityEngine;

[CreateAssetMenu(fileName = "New scene Type",menuName = "Scene type")]
public class SceneType : ScriptableObject
{
    [SerializeField] private int numOfBrick;
    [SerializeField] private float speedOfCircle;
    [SerializeField] private Vector2 powerOfThrowing;

    public int GetNumOfBrick()
    {
        return numOfBrick;
    }
    public float GetSpeedOfCircle()
    {
        return speedOfCircle;
    }
    public Vector2 GetPowerOfThrowing()
    {
        return powerOfThrowing;
    }
}
