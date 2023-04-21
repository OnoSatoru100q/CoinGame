using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pusher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector3(0.02f, 1.01f, 0.27f), 1f).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
