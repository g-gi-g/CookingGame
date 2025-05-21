using System.Collections;
using UnityEditor;
using UnityEngine;

public class serveplate : MonoBehaviour
{
    public int thisPlate;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameflow.orderValue[thisPlate] == gameflow.plateValue[thisPlate])
        {
            Debug.Log("correct" + " " + gameflow.orderTimer[gameflow.plateNum]);
            if (gameflow.orderTimer[thisPlate] > 0)
                gameflow.totalCash += gameflow.orderTimer[thisPlate] * 0.1f;

        }
           
        gameflow.emptyPlateNow = transform.position.x;
        StartCoroutine(platereset());

        int randomIndex = Random.Range(0, gameflow.menu.Length);
        gameflow.orderValue[thisPlate] = gameflow.menu[randomIndex];
        gameflow.plateValue[thisPlate] = 0;
        gameflow.orderTimer[thisPlate] = 60;
    }

    IEnumerator platereset()
    {
        yield return new WaitForSeconds(0.2f);
        gameflow.emptyPlateNow = -1;
    }
}
