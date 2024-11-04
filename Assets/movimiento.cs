using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speedx = 5.0f;
    public int directionx = 1;

    
    public int directiony = 1;

    private Transform _componentTransform;
    private SpriteRenderer _componentSpriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        _componentTransform = GetComponent<Transform>();
        _componentSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _componentTransform.position = new Vector2(_componentTransform.position.x + speedx * directionx * Time.deltaTime, _componentTransform.position.y + speedx * directiony * Time.deltaTime);
        if (_componentTransform.position.x >= 7.427f)
        {
            directionx = directionx * -1;
            _componentSpriteRenderer.flipX = true;

        }
        else if ( _componentTransform.position.x <= -7.431f)
        {
            directionx = directionx * -1;
            _componentSpriteRenderer.flipX = false;
        }


        if(_componentTransform.position.y >= 4.12f)
        {
            directiony = directiony* -1;
            _componentSpriteRenderer.flipX = true;
        }
        else if( _componentTransform.position.y <= -4.05f)
        {
            directiony = directiony * -1;
            _componentSpriteRenderer.flipX = false;
        }

    }
}
