using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   Animator animator;
   bool Dead;
   

   void Start()
   {
       
       animator = GetComponent<Animator>();
   }

   void Update()
   {

   
         void OnTriggerEnter(Collider DeathHole)
        {
            if(DeathHole.CompareTag("Ball"))
            {
                animator.SetBool("Dead", true);
            }
        }
   }
       
       
   
}

