using UnityEngine;

public class TrashSorter : MonoBehaviour
{
    [SerializeField] string colorType;
    [SerializeField] Collector collector;
    bool complete = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == colorType)
        {
            Destroy(other.gameObject);
            if (!complete)
            {
                collector.CollectOne();
                complete = true;
            }
        }
    }
}
