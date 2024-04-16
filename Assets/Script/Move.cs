using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Move : MonoBehaviour
{
    public float speed;
    public float jumphigh;
    public bool groundCheck;
    public Animator animator;
    void OnCollisionEnter2D(Collision2D selfbody)
    {
        if (selfbody.gameObject.tag == "Ground")
        {
            Debug.Log("2131");
            groundCheck = true;
        }
    }
    void OnCollisionExit2D(Collision2D selfbodyexit)
    {
        if (selfbodyexit.gameObject.tag == "Ground")
        {
            groundCheck = false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
            if (groundCheck == true)
            {
                animator.SetBool("Run", true);
            }
        }
        else if (Input.GetKey("a"))
        {
            this.gameObject.transform.position -= new Vector3(speed, 0, 0);
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKeyDown("w") && groundCheck == true)
        {
            this.gameObject.transform.position += new Vector3(0, jumphigh, 0) * Time.fixedDeltaTime;
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }

        if (Input.GetKeyDown("j"))
        {
            this.gameObject.transform.Find("NormalAttack").GetComponent<PolygonCollider2D>().enabled = true;
            animator.SetBool("Attack", true);
        }
        else
        {
            this.gameObject.transform.Find("NormalAttack").GetComponent<PolygonCollider2D>().enabled = false;
            animator.SetBool("Attack", false);
        }
    }
}
