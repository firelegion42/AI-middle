using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Scriptable Objects/PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
    public int bulletCount;
    public float maxHealth;
    public float movementSpeed;
    public int jumpSpeed;
    public float bulletSpeed;

}
