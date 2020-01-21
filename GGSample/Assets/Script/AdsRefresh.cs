using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GreedyGame.Runtime;

public class AdsRefresh : MonoBehaviour
{
    public void buttonclick()
	{
		GreedyGameAgent.Instance.startEventRefresh();
		Debug.Log("GG[Ads] Refresh");

	}
}
