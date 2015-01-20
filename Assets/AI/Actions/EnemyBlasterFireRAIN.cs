using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;



[RAINAction]
public class EnemyBlasterFireRAIN : RAINAction
{
	EnemyBlasterFire fireBlasters;



    public override void Start(AI ai)
    {
		base.Start(ai);

		fireBlasters = ai.Body.GetComponentInChildren<EnemyBlasterFire>();
	}



    public override ActionResult Execute(AI ai)
	{
		fireBlasters.Shoot();

        return ActionResult.SUCCESS;
    }



    public override void Stop(AI ai)
    {
        base.Stop(ai);
    }
}



















