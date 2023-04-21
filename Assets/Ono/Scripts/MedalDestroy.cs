using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalDestroy : MonoBehaviour
{
    public  MedalManager medalManager;
    public int getcoin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Medal")
        {
            medalManager.GetMedal(getcoin);
            Destroy(other.gameObject);
        }
    }
}
