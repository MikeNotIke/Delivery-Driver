using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] Color32 NoPackageColour = new Color32(1,1,1,1);
    [SerializeField] Color32 hasOnePackageColour = new Color32(1,1,1,1);
    [SerializeField] Color32 hasTwoPackageColour = new Color32(1,1,1,1);
    [SerializeField] Color32 hasThreePackageColour = new Color32(1,1,1,1);
    [SerializeField] Color32 hasFourPackageColour = new Color32(1,1,1,1);
    [SerializeField] Color32 hasMaxPackageColour = new Color32(1,1,1,1);
    [SerializeField]float destroyDellay = 0.5f;
    

    [SerializeField] int maxNumberOfPackages = 5;
    int currentNumberOfPackages = 0;



    void Start(){
      SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void  OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You dumb dumb");
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Package" && currentNumberOfPackages <= maxNumberOfPackages){
            Debug.Log("Package");
            currentNumberOfPackages++;
            ChangeColour(currentNumberOfPackages);
            Destroy(other.gameObject, destroyDellay);
            
        }

        if (other.tag == "Customer" && currentNumberOfPackages > 0){
            
            Debug.Log("Customer");
            currentNumberOfPackages--;
            ChangeColour(currentNumberOfPackages);
        }
    }

    public void ChangeColour(int currentNumberOfPackages){
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
       switch (currentNumberOfPackages){
                case 0:
                spriteRenderer.color = NoPackageColour;
                break;
                case 1:
                spriteRenderer.color = hasOnePackageColour;
                break;
                case 2:
                spriteRenderer.color = hasTwoPackageColour;
                break;
                case 3:
                spriteRenderer.color = hasThreePackageColour;
                break;
                case 4:
                spriteRenderer.color = hasFourPackageColour;
                break;
                default:
                spriteRenderer.color = hasMaxPackageColour;
                break;
            }
    }

    

}
