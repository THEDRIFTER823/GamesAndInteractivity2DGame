using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 direction, float force)
    {
        Debug.Log("launched " + force);
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //audioSource.PlayOneShot(impactSound);
        // EnemyStats e = other.collider.GetComponent<EnemyStats>();
        // if (e != null)
        // { 
        //     e.ChangeHealth(-1);
        // }
        // GetComponent<Collider2D>().enabled = false;
        // animator.SetTrigger("destroy");
        rigidbody2d.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
        Destroy(gameObject);
    }
}
