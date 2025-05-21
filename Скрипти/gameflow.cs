using TMPro;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public static int[] menu = { 11001, 11011, 11101, 11111, 12001, 12011, 12101, 12111 };

    public static int[] orderValue = { 0, 0, 0 };
    public static int[] plateValue = { 0, 0, 0 };
    public static float[] orderTimer = { 0, 0, 0 };

    public static int plateNum = 0;
    public static float plateXpos = 0;

    public Transform plateSelector;

    public MeshRenderer[] currentPic;

    public Texture[] orderPics;

    public static float emptyPlateNow = -1;

    public TMP_Text cashText;
    public static float totalCash = 0;

    public TMP_Text[] dishTimerTexts;

    public static float mainTimer;
    public TMP_Text mainTimerText;

    public GameObject gameOverCanvas;
    public TMP_Text finalCashText;

    void Start()
    {
        int randomIndex;

        for (int i = 0; i < 3; ++i)
        {
            randomIndex = Random.Range(0, menu.Length);
            orderValue[i] = menu[randomIndex];
            orderTimer[i] = 60;
        }

        mainTimer = 120;
        plateValue = new int[] { 0, 0, 0 };
        totalCash = 0;
        emptyPlateNow = -1;
        plateNum = 0;
        plateXpos = 0;
    }

    void Update()
    {
        mainTimer -= Time.deltaTime;

        if (mainTimer <= 0)
        {
            gameOverCanvas.SetActive(true);
            finalCashText.text = "Total cash: " + totalCash;
        }

        mainTimerText.text = "Time left: " + (int)mainTimer / 60 + " m " + (int)mainTimer % 60 + " s";

        cashText.text = "Cash: " + totalCash;

        for (int rep = 0; rep < 3; rep++)
        {
            orderTimer[rep] -= Time.deltaTime;

            if (orderTimer[rep] >= 0)
                dishTimerTexts[rep].text = (rep + 1) + " " + "Dish time left: " + (int)orderTimer[rep] + " s";
            else
                dishTimerTexts[rep].text = (rep + 1) + " " + "Dish time left: 0 s";

            if (orderValue[rep] == 11001)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[0];

            else if (orderValue[rep] == 11011)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[1];

            else if (orderValue[rep] == 11101)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[2];

            else if (orderValue[rep] == 11111)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[3];

            else if (orderValue[rep] == 12001)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[4];

            else if (orderValue[rep] == 12011)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[5];

            else if (orderValue[rep] == 12101)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[6];

            else if (orderValue[rep] == 12111)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[7];
        }

        if (Input.GetKeyDown("tab"))
        {
            plateNum += 1;
            plateXpos += 2;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateXpos = 0;
            }
        }

        plateSelector.transform.position = new Vector3(plateXpos, 0, 0);
    }
}
