using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyMonster : MovingMonster
{
   override protected void Update(){
       Vector2 start = (Vector2)transform.position + Vector2.down*0.51f;
       Vector2 direction = Vector2.down;
       if(speed.x <0){
           start += Vector2.left*0.51f;
           
       }
       else{
           start += Vector2.right*0.51f;
       }
        Debug.DrawRay(start,direction*hitRange,Color.red);
        RaycastHit2D hit = Physics2D.Raycast(start,direction,hitRange);

        if(hit.collider == null){
            speed.x*= -1;
        }
       base.Update();
   }
}
