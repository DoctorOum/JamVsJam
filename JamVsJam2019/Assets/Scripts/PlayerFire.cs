using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    bool isFire;
    public float shootInterval;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    IEnumerator Fire()
    {
        isFire = true;



        yield return new WaitForSeconds(shootInterval);
        isFire = false;
    }
}
