using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static GameController gameController;
    
    public Text coinsText;

    private int coins;  
      
 
    void Awake()
    {
        if(gameController == null){
            gameController = this;
        }
    }
    
   
    public void SetCoins(int c){
        coins += c;
        UpdateHUD();
   
    }
   public int GetCoins(){
       return coins;
   }
 
   void UpdateHUD(){
    coinsText.text = GetCoins().ToString();
   }



}
