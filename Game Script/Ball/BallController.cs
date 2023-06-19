using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private SetColor _color;
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    public int indexColor;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            if(collision.gameObject.GetComponent<SetColor>().color == _color.color) 
            {
                collision.gameObject.GetComponent<BrickController>().Destroyer();
                int x = Random.Range(0, 7);
                SFXController.instance.PlayBrickDst(x);

            }else if(collision.gameObject.GetComponent<SetColor>().color == SetColor.Color.white)
            {
                collision.gameObject.GetComponent<BrickController>().Destroyer();
                ChangeColor(0);
            }
            else
            {
                int x = Random.Range(0, 6);
                SFXController.instance.PlayBrickDstNot(x);
            }
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            int x = Random.Range(0, 7);
            SFXController.instance.PlayWallBounce(x);
        }
    }

    public void ChangeColor(int aux)
    {
        indexColor = aux;
        Switch();
    }

    public void Switch()
    {
        switch (indexColor)
        {
            case 0:
             _spriteRenderer.color = Color.white;
                _color.color = SetColor.Color.white;
            break;
            case 1:
                 _spriteRenderer.color = Color.red;
                _color.color = SetColor.Color.red;
                break;
            case 2:
                  _spriteRenderer.color = Color.green;
                _color.color = SetColor.Color.green;
                break;
            case 3:
                _spriteRenderer.color = Color.blue;
                _color.color = SetColor.Color.blue;
                break;
            case 4:
                _spriteRenderer.color = Color.yellow;
                _color.color = SetColor.Color.yellow;
                break;
            case 5:
                _spriteRenderer.color = HexToColor("#AE08EE");
                _color.color = SetColor.Color.purple;
                break;
            case 6:
                _spriteRenderer.color = HexToColor("#866109");
                _color.color = SetColor.Color.brown;
                break;
            
        }
    }

    Color HexToColor(string hex)
    {
        Color color = new Color();
        ColorUtility.TryParseHtmlString(hex, out color);
        return color;
    }
}
