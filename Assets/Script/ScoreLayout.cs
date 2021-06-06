using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLayout : MonoBehaviour
{
	public string sortingLayerName;
	public int sortingOrder;

	void Start()
	{
		MeshRenderer mesh = GetComponent<MeshRenderer>();
		mesh.sortingLayerName = sortingLayerName;
		mesh.sortingOrder = sortingOrder;

	}
}
