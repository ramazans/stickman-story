﻿using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class PathDefinition : MonoBehaviour {

	public Transform[] Points;
	public IEnumerator<Transform> GetPathEnumerator(){
		if (Points==null|| Points.Length < 1) 
		yield break;

		var direction = 1;
		var index =0;
		while (true) {
			yield return Points[index];
			if (Points.Length==1) 
				continue;
			if (index<=0) 
				direction=1;
			else if (index>= Points.Length-1) 
				direction = -1;	
			index = index + direction;
		}
	}
	public void OnDrawGizmos()
	{
		if (Points==null || Points.Length<2) 
			return;

        var points = Points.Where(t => t != null).ToList();
        if(points.Count<2)
            return;
		
		for (int i = 1; i < Points.Length; i++) {
			Gizmos.DrawLine(Points[i-1].position,Points[i].position);
		}
	}
}
