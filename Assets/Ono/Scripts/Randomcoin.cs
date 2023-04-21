using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomcoin : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabCube;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayCoroutine());
    }

    // Update is called once per frame
    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Randomcoin>().enabled = false;
    }
    void Update()
    {
        // 30フレーム毎にシーンにプレハブを生成
        if (Time.frameCount % 3 == 0)
        {
            // プレハブの位置をランダムで設定
            float x = Random.Range(-3f, 3f);
            float z = Random.Range(2f, -3f);
            Vector3 pos = new Vector3(x, 3.0f, z);

            // プレハブを生成
            Instantiate(PrefabCube, pos, Quaternion.identity);
        }
    }
}
