using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    GameManager GM;
     private float rotateSpeed=100f;
   void Awake() {
            GM=GameObject.Find("GameManager").GetComponent<GameManager>();
        GM.cur_points++;
     }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right*rotateSpeed); 
    }  
      void OnTriggerEnter(Collider other) {
        
    
    {
       if(other.gameObject.tag=="player")
       {
          Destroy(gameObject);
          GM.cur_points--;
          GM.UpdateUI();

}
    }
    }
}

