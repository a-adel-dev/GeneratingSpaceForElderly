using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField] Transform chair;
    [SerializeField] Transform bedLandingRight;
    [SerializeField] Transform bedLandingLeft;
    [SerializeField] Transform exit;
    [SerializeField] Transform cupboard;
    Transform[] positionList = new Transform[4];

    Mover mover;
    int counter;

    private void Start()
    {
        positionList[0] = bedLandingRight; 
        positionList[1] = cupboard;
        positionList[2] = chair; 
        positionList[3] = exit;
        mover = GetComponent<Mover>();
        mover.MoveTo(positionList[counter]);
    }

    private void Update()
    {
        if (mover.ReachedDestination())
        {
            counter++;
            if (counter < positionList.Length)
            {
                mover.MoveTo(positionList[counter]);
            }
            
        }
    }

}
