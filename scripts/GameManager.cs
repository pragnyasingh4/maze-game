 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinsLeft; 
    public int cur_points=0;
 public int max_coins=0;
 public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
         Door.SetActive(false);
         max_coins=cur_points;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void UpdateUI()
   {
     if(cur_points > 0)
     {
     coinsLeft.text="Coins Left:"+cur_points.ToString("D3")+"/"+ max_coins.ToString("D3");
   
   }
   else if(cur_points<=0)
   {
        Door.SetActive(true);
   }
}
}
