using System.Collections;
using System.Collections.Generic;
using GreedyGame.Runtime;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    public string unitId;

    void OnMouseDown()
    {

        GreedyGameAgent.Instance.showEngagementWindow(unitId);

    }

   public void Buttonclick()
    {
        GreedyGameAgent.Instance.showEngagementWindow(unitId);
    }
}
