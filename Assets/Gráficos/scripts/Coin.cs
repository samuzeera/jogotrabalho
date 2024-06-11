using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private BoxCollider2D col;

    void Awake()
    {
        col= GetComponent<BoxCollider2D>();
    }
    
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            col.enabled = false;
            GameController.gameController.SetCoins(1);
            Destroy(this.gameObject);
        }
    }
   
}
