using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject medalPrefab;
    private float span = 1.0f;
    private float lefttime,righttime=0;
    public MedalManager medalManager;
    // Update is called once per frame
    void Update()
    {
        lefttime += Time.deltaTime;
        righttime += Time.deltaTime;
    }
    public void LeftClick()
    {
        if (span < lefttime)
        {
            GameObject medal = Instantiate(medalPrefab, new Vector3(-2.43f, 6.03f, -1.95f), Quaternion.Euler(90f,-110f, 0f));
            lefttime = 0;
            medalManager.LostMedal();
        }
    }
    public void RightClick()
    {
        if (span < righttime)
        {
            GameObject medal = Instantiate(medalPrefab, new Vector3(1.16f, 6.03f, -1.95f), Quaternion.Euler(90f, -110f, 0f));
            righttime = 0;
            medalManager.LostMedal();
        }
    }
}
