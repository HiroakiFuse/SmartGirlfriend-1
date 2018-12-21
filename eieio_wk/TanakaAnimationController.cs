using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * walkonでアニメーションを再生するクラス。
 * Animatorウィンドウの方でboolの「walk」parameterを作る必要あり
 */
public class TanakaAnimationController : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	private void Start () {
		animator = GetComponent<Animator>();
	}
	
	public void WalkOn () {
		animator.SetBool("walk",true);
	}
}
