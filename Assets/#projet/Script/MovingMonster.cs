using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{
    public Vector2 speed = Vector2.zero;
    private SpriteRenderer sprinteRenderer;
    public float hitRange = 0.1f;
    
    void Start()
    {
        sprinteRenderer=GetComponent<SpriteRenderer>();
        
    }

    
    virtual protected void Update()
    {
        Vector2 start;
        Vector2 direction;

        Vector2 deplacement = speed*Time.deltaTime;
        transform.position += (Vector3)deplacement;

        if (speed.x <0){
            sprinteRenderer.flipX = true;
            start =(Vector2)transform.position + Vector2.left*0.51f;
            direction = Vector2.left;
        }
        else{
            sprinteRenderer.flipX = false;
            start = (Vector2) transform.position + Vector2.right*0.51f;
            direction=Vector2.right;
        }
        Debug.DrawRay(start,direction*hitRange,Color.black);
        RaycastHit2D hit = Physics2D.Raycast(start,direction,hitRange);

        if(hit.collider != null){
            speed.x*= -1;
        }
        //Debug.DrawRay((Vector2)transform.position, Vector2.right*100,Color.red);
        //RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position + Vector2.left*0.5f, Vector2.right);
        //if(hit.collider != null){
        //    print(hit.collider.name);
        //}


    }
}
