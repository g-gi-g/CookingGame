using UnityEngine;

public class removefood : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (gameflow.emptyPlateNow > transform.position.x - 0.4f && gameflow.emptyPlateNow < transform.position.x + 0.4f)
            Destroy(gameObject);
    }
}
