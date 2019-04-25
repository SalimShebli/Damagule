using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Damagule : MonoBehaviour
{

    #region private_variables
    int id;
    Color color;
    bool isBoot;
    #endregion
    
    #region public_functions
    void Start()
    {
        id = 0;
        color = gameObject.GetComponent<Renderer>().material.color;
        isBoot = false;
    }
    public int GetId()
    {
        return id;
    }
    public void InitializeBoot(int id)
    {
        this.id = id;
        isBoot = true;
    }
    public void SetNewPosition(Vector2 position)
    {
        transform.position = position;
    }
    public Vector2 GetPosition()
    {
        return transform.position;
    }
    #endregion
}
