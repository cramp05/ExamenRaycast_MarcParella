using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class RaycastScript : MonoBehaviour
{
    InputAction _clickAction;
    InputAction _mouseAction;
    Vector2 _mousePosition;

    public Text contador;

    bool corrutine = true;

    void Awake()
    {
        _clickAction = InputSystem.actions["Attack"];
        _mouseAction = InputSystem.actions["MousePosition"];
    }

    void Update()
    {
        _mousePosition = _mouseAction.ReadValue<Vector2>();
        if(corrutine == true)
        {
            if(_clickAction.WasPressedThisFrame())
            {
            StartCoroutine(ContadorSegundos()); 

            }
        }
        
    }

    IEnumerator ContadorSegundos()
    {
        corrutine = false;
    
        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.collider.CompareTag("Tag1"))
            {
                contador.text = "5";
                yield return new WaitForSeconds(1);
                contador.text = "4";
                yield return new WaitForSeconds(1);
                contador.text = "3";
                yield return new WaitForSeconds(1);
                contador.text = "2";
                yield return new WaitForSeconds(1);
                contador.text = "1";
                SceneManager.LoadScene("Scene1");
            }
            if(hit.collider.CompareTag("Tag2"))
            {
                contador.text = "5";
                yield return new WaitForSeconds(1);
                contador.text = "4";
                yield return new WaitForSeconds(1);
                contador.text = "3";
                yield return new WaitForSeconds(1);
                contador.text = "2";
                yield return new WaitForSeconds(1);
                contador.text = "1";
                SceneManager.LoadScene("Scene2");
            }
            if(hit.collider.CompareTag("Tag3"))
            {
                contador.text = "5";
                yield return new WaitForSeconds(1);
                contador.text = "4";
                yield return new WaitForSeconds(1);
                contador.text = "3";
                yield return new WaitForSeconds(1);
                contador.text = "2";
                yield return new WaitForSeconds(1);
                contador.text = "1";
                SceneManager.LoadScene("Scene3");
            }
        }

        

        //ShootRaycast();

    }

    /*void ShootRaycast()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.collider.CompareTag("Tag1"))
            {
                SceneManager.LoadScene("Scene1");
            }
            if(hit.collider.CompareTag("Tag2"))
            {
                SceneManager.LoadScene("Scene2");
            }
            if(hit.collider.CompareTag("Tag3"))
            {
                SceneManager.LoadScene("Scene3");
            }
        }
    }*/
}
