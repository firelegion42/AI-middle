using DG.Tweening;
using UnityEngine;

public class HealingPotion : MonoBehaviour
{
    [SerializeField] private float potionHeight;

    private Vector3 move;

    private void Awake()
    {
        transform.DOMove(new Vector3(transform.position.x, potionHeight, transform.position.z), 2).SetEase(Ease.InOutBack).SetLoops(-1,LoopType.Yoyo);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.DOKill();
        transform.DOMove(new Vector3(transform.position.x, potionHeight, transform.position.z), 3).SetEase(Ease.InSine);
        transform.DORotate(new Vector3(0,170,0), 3);
        transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 3);
        Destroy(gameObject, 3);
    }
}
