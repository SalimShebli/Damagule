using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_MainPlayer : MonoBehaviour
{

    #region public_variables
    public GameObject BootPrefab;
    #endregion

    #region private_variables
    M_Damagule mainPlayerModel;
    Stack<M_Damagule> Boots;
    float distanceBetweenBoots = 2f;//just for fun
    #endregion
    // Use this for initialization
    #region private_functions
    void Start () {
        mainPlayerModel = gameObject.GetComponent<M_Damagule>();
        Boots = new Stack<M_Damagule>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    #endregion

    #region public_functions
    public void MoveLeft()
    {
        Vector2 pos = mainPlayerModel.GetPosition();
        pos.x -= 0.1f;
        mainPlayerModel.SetNewPosition(pos);
    }
    public void MoveRight()
    {
        Vector2 pos = mainPlayerModel.GetPosition();
        pos.x += 0.1f;
        mainPlayerModel.SetNewPosition(pos);
    }
    public void UpdateBootsNumber(int newValue)
    {
        if (Boots.Count == newValue) return;
        if(Boots.Count<newValue)
        {
            while(Boots.Count<newValue)
            {
                M_Damagule newBoot = Instantiate(BootPrefab).GetComponent<M_Damagule>();
                newBoot.gameObject.GetComponent<C_Boot>().SetMainPlayer(mainPlayerModel);
                newBoot.InitializeBoot(Boots.Count+1);
                newBoot.gameObject.GetComponent<C_Boot>().SetDistanceFromMain(distanceBetweenBoots * newBoot.GetId());
                Boots.Push(newBoot);
            }
        }
        else
        {
            while(Boots.Count>newValue)
            {
                M_Damagule bootToDestroy = Boots.Peek();
                bootToDestroy.gameObject.GetComponent<C_Boot>().destroyBoot();
                Boots.Pop();
            }
        }
    }
    #endregion
}
