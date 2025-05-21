using UnityEngine;

public class clickplace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "bunBottom")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 0.1f, 0f), cloneObj.rotation);

        if (gameObject.name == "bunTop")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 1f, 0f), cloneObj.rotation);

        if (gameObject.name == "Cheese")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 0.5f, 0f), cloneObj.rotation);

        gameflow.plateValue[gameflow.plateNum] += foodValue;
        Debug.Log(gameflow.plateValue[gameflow.plateNum] + " " + gameflow.orderValue[gameflow.plateNum]);
    }
}
