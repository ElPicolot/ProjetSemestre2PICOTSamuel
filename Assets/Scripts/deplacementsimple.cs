using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementsimple : MonoBehaviour
{
	public Rigidbody2D rb;
	[SerializeField] float jumpAmount ;
	bool toucheSol = true;
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)&& toucheSol)
		{
			rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
			toucheSol = true;
		}
		Movement();
		//lvc
	}

	private void OnCollisionEnter2D(Collision2D collision)
    {

		if (collision.gameObject.tag == "Ladder")
        {
			toucheSol = true;
        }
		if (collision.gameObject.tag == "porte1")
		{
			toucheSol = true;
		}
		if (collision.gameObject.tag == "porte2")
		{
			toucheSol = true;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "Ladder")
		{
			toucheSol = false;
		}
		if (collision.gameObject.tag == "porte1")
		{
			toucheSol = false;
		}
		if (collision.gameObject.tag == "porte2")
		{
			toucheSol = false;
		}
	}

	void Movement()
	{
		/*if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector2.right * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.up * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.Q))
		{
			transform.Translate(Vector2.up * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(180, 0);
		}
		*/
		/*
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.up * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.Q))
		{
			transform.Translate(Vector2.up * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(180, 0);
		}
		*/
		if (Input.GetKey(KeyCode.G))
		{
			transform.Translate(Vector2.right * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.F))
		{
			transform.Translate(Vector2.right * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		}
	}
}

