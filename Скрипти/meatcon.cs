using UnityEngine;

public class meatcon : MonoBehaviour
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
        if (gameObject.name == "Cutlet")
            Instantiate(cloneObj, new Vector3(-3.04f, 0.5f, -0.04f), cloneObj.rotation);
    }
}
