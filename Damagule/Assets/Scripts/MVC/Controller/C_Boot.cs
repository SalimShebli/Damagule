using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Boot : MonoBehaviour {

     M_Damagule MainPlayer;
     M_Damagule Boot ;
    float distanceFromMain;
	// Use this for initialization
	void Start () {
        Boot = GetComponent<M_Damagule>();
        Vector2 pos = MainPlayer.GetPosition();
        pos.x -= distanceFromMain;
        Boot.SetNewPosition(pos);
	}
	
	// Update is called once per frame
	void Update () {
	    	if(Vector2.Distance(MainPlayer.GetPosition(),Boot.GetPosition())>distanceFromMain)
            {
                Vector2 curPosition = Boot.GetPosition();
                if(curPosition.x<MainPlayer.GetPosition().x)
                {
                    curPosition.x += 0.1f;
                }
                else
                {
                    curPosition.x -= 0.1f;
                }
                Boot.SetNewPosition(curPosition);
            }
   	}
    public void SetMainPlayer(M_Damagule mainPlayer)
    {
        MainPlayer = mainPlayer;
       
    }
    public void SetDistanceFromMain(float dis)
    {
        distanceFromMain = dis;
       
       
    }
    public void destroyBoot()
    {
        Destroy(gameObject);
    }
}
