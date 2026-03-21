using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject firePoint;
    [SerializeField] float launchForce = 250;
    [SerializeField] GameObject rifleBullet; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().flipX)
        {
            if (Input.GetAxisRaw("Vertical") < 0.0f)
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetAxisRaw("Vertical") > 0.0f)
            {
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else
        {
            if (Input.GetAxisRaw("Vertical") < 0.0f)
            {
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            else if (Input.GetAxisRaw("Vertical") > 0.0f)
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        if (Input.GetAxisRaw("Horizontal") < 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKeyDown("c"))
        {
            // Use the FirePoint's Right axis. This is a unit vector (length of 1).
            Vector2 shootDirection = Vector2.right;

            // If you are flipping the sprite, the 'Right' axis might need to be inverted
            if (GetComponent<SpriteRenderer>().flipX)
            {
                shootDirection *= -1;
            }
            Debug.Log(shootDirection);
            Launch(shootDirection);
        }
    }

    void Launch(Vector2 direction)
    {
        GameObject projectileObject = Instantiate(rifleBullet, firePoint.transform.position, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(direction, launchForce);
    }
}
