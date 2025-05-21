using UnityEngine;

public class baconcon : MonoBehaviour
{
    public Transform cloneObj;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Bacon")
            Instantiate(cloneObj, new Vector3(-5.5f, 0.5f, -0.05f), cloneObj.rotation);
    }
}
