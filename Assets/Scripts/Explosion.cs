using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float damage = 25f;
    private void OnTriggerEnter2D(Collider2D collison)
    {
        Player player = collison.GetComponent<Player>();
        Enemy enemy = collison.GetComponent<Enemy>();
        if (collison.CompareTag("Player"))
        {
            player.TakeDamage(damage);
        }
        if (collison.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage);
        }
    }
    public void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
