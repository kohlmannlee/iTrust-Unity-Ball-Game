using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CubePrefab : MonoBehaviour


{

    public Transform points;
    //public bool fallOnce = false;


    void Update()
    {


        if (points.position.y < -1)
        {

            Score.initialScore = (Score.initialScore + 1);
            //once = true;
        }


    }
}
