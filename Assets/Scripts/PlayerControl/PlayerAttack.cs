using UnityEngine;

public class PlayerAttack : MonoBehaviour, IAttack
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _gun;
    [SerializeField] private float _bulletSpeed;

    private int bulletCount;
    private GameObject _currentBullet;
    

    public void Attack()
    {
        _currentBullet = Instantiate(_bullet, _gun.position, Quaternion.identity);


        Rigidbody currentVelocity = _currentBullet.GetComponent<Rigidbody>();
        currentVelocity.linearVelocity = _gun.up * _bulletSpeed;
        bulletCount++;
        Destroy(_currentBullet, 1);
    }
}
