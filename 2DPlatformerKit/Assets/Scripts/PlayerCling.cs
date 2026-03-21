using UnityEngine;

public class PlayerCling : MonoBehaviour
{
    [SerializeField] PhysicsObjectManipulator pom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        if (pom != null)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
                pom.forceToAdd = 500 * new Vector3(Input.GetAxisRaw("Horizontal"), 1, 0);
            else
                if (Input.GetKeyDown("w"))
                   pom.forceToAdd = 500 * new Vector3(0, 1, 0); 
        }
    }
}
