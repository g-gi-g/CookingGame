using System.Collections;
using UnityEngine;

public class cookmovebacon : MonoBehaviour
{
    private int foodValue = 0;
    private MeshRenderer baconMat;
    private string isMoved = "n";

    void Start()
    {
        baconMat = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (isMoved == "n")
        {
            GetComponent<Transform>().position = new Vector3(gameflow.plateXpos, 0.5f, 0f);
            gameflow.plateValue[gameflow.plateNum] += foodValue;
            isMoved = "y";
        }
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 100;
        if (isMoved == "n")
            baconMat.material.color = new Color(0.3f, 0.3f, 0.3f);
    }
}
