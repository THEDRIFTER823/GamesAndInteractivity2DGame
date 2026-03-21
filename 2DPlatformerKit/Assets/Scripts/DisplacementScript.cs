using UnityEngine;

public class DisplacementScript : MonoBehaviour
{
    int currentStage = 0;
    MovingObject movingObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        movingObject = GetComponent<MovingObject>();
    }

    // Update is called once per frame
    void Update()
    {
        float height = transform.localPosition.y;
        if (height <= -0.24f)
        {
            currentStage = 0;
        }
        else if (height <= 0f)
        {
            currentStage = 1;
        }
        else if (height <= 0.25f)
        {
            currentStage = 2;
        }
        else if (height <= 0.5f)
        {
            currentStage = 3;
        }
    }

    public void NextStage()
    {
        Debug.Log("Current stage: " + currentStage);
        movingObject.MoveInstantToNode(currentStage);
        movingObject.MoveToNode(4);
    }
    
    void PrevStage()
    {
        currentStage--;
    }

    public int GetStage()
    {
        return currentStage;
    }
}
