using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D selfbody)
    {
        if (selfbody.gameObject.tag == "Player")
        {
            Debug.Log("Hit!!!!!!!!!!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
