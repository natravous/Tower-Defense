using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    private Tower _placedTower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Fungsi yang terpanggil sekali ketika ada object Rigidbody yang menyentuh area collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_placedTower != null)
        {
            return;
        }

        Tower tower = collision.GetComponent<Tower>();
        if(tower != null)
        {
            tower.SetPlacePosition(transform.position);
            _placedTower = tower;
        }
    }
}
