using System.Collections;
using UnityEngine;

public class TrashScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameflow.emptyPlateNow = gameflow.plateXpos;
        StartCoroutine(platereset());
    }

    IEnumerator platereset()
    {
        yield return new WaitForSeconds(0.2f);
        gameflow.emptyPlateNow = -1;
    }
}
