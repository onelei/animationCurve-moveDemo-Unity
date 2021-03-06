﻿using UnityEngine;
using System.Collections;

public class MoveDemo : MonoBehaviour {
    
    [SerializeField] MoveItem MyMoveItem;
    [SerializeField] AnimationCurve CurveScale,CurveY,CurveZ;

   // private const float INIT_POS_X = -0.5f;//from [-0.5,0.5]
    private const float INIT_POS_X = 0f;//from [0,1]
    private const float DISTANCE_HEIGHT = 0.25f;

	// Use this for initialization
	void Start () {
	    
	}

    [ContextMenu("Init")]
    void Init() {
        MyMoveItem.gameObject.SetActive(false);
        NGUITools.DestroyChildren(transform);
        for (int i=0;i<5;++i) {
            var child = NGUITools.AddChild(gameObject, MyMoveItem.gameObject);
            child.SetActive(true);
            child.GetComponent<MoveItem>().SetData(i);
            var posX = INIT_POS_X + i * DISTANCE_HEIGHT;
            var pos = child.transform.position;
            child.name = "Move Item "+i;
            child.transform.position = new Vector3(posX, CurveY.Evaluate(posX), pos.z);
            child.transform.localScale = Vector3.one * 0.5f;
            //child.transform.localScale = Vector3.one * CurveScale.Evaluate(posX);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
