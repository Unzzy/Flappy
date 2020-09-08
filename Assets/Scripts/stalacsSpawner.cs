using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalacsSpawner : MonoBehaviour
{
    public GameObject Stalagmites;

    void Start()
    {
        StartCoroutine(Spawner());
    }

   IEnumerator Spawner()
   {
       while (true)
       {
       yield return new WaitForSeconds(2);
       float rand = Random.Range(-1f, 4f);
       GameObject newStalagmites = Instantiate(Stalagmites, new Vector3(2, rand, 0), Quaternion.identity);
       Destroy(newStalagmites,7);
       }
   }
}
