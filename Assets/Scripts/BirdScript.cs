using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
   public int force;
   Rigidbody2D BirdRigid;
   public GameObject restartButton;
   

    void Start()
    {
      Time.timeScale = 1;
      BirdRigid = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))   
     {
         BirdRigid.velocity = Vector2.up * force;
     }
               if (Input.GetKey("escape"))
        {
            Application.Quit();}
    }

     private void OnCollisionEnter2D(Collision2D collision)
      {
        if (collision.collider.tag == "Enemy")
        {
         Destroy(gameObject);
         Time.timeScale = 0;
         restartButton.SetActive(true);
          if (Input.GetKey("escape"))
          {
            Application.Quit();
          }
        }
      }
    
}
