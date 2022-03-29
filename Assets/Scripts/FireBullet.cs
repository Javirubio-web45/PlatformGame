using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    // variable to define bullet speed
    private float speed = 10f;
    private Animator anim;

    void Awake(){
        anim = GetComponent<Animator>();
    }


    void Start()
    {
        StartCoroutine (DisableBullet(5f));
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //function to declare bullet direction
    void Move() {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        //direction
        transform.position = temp;
    }

    public float Speed{
        get{ 
            return speed; 
        }
        set{
            speed = value;
        }
    }

    IEnumerator DisableBullet(float timer){
        yield return new WaitForSeconds(timer);
        gameObject.SetActive(false);
    }
/*
    void OnTriggerEnter2D(Collider2D target){
        if(target.gameObject.tag == MyTags.BEETLE_TAG || target.gameObject.tag == MyTags.SNAIL_TAG){
            anim.Play("Explode");
            StartCoroutine (DisableBullet(0.9f));
        }
    }*/
}
































