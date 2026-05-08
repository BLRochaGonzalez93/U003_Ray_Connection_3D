using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabRepeater, camera, prefabDualRepeater, winPanel, tutorialPanel;
    [SerializeField] private LayerMask _layerGround, _layerRepeater;
    [SerializeField] private MeshRenderer[] _areas;
    [SerializeField] private GameObject[] trophies, trophiesImg;
    [SerializeField] private TextMeshProUGUI reps, drepts;
    public List<GameObject> repeaters, dualRepeaters;

    private int maxRepeatersLvl1 = 12, maxRepeatersLvl2 = 30;



    private GameObject _currentRepeater;
    private Vector3 posicionInicial;

    private void Awake()
    {
        winPanel.SetActive(false);
        tutorialPanel.SetActive(false);

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7, 21, -10), Quaternion.Euler(75, 0, 0));
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(6, 18.5f, 0), Quaternion.Euler(75, -90, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level1")
        {
            reps.text = "x " + (maxRepeatersLvl1 - repeaters.Count) + " left";
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            reps.text = "x " + (maxRepeatersLvl2 - repeaters.Count) + " left";
            drepts.text = "x " + (2 - dualRepeaters.Count) + " left";
        }

        int sum = 0;
        for (int i = 0; i < trophies.Length; i++)
        {
            if (trophies[i].GetComponent<LineRenderer>().enabled == true)
            {
                trophiesImg[i].SetActive(true);
                sum++;
            }
            else
            {
                trophiesImg[i].SetActive(false);
            }
        }

        

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            winPanel.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (Input.GetKeyUp(KeyCode.Q))
            {
                if (camera.GetComponent<Transform>().position == new Vector3(7, 21, -10))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6, 18, -3), Quaternion.Euler(75, 90, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(-6, 18f, -3))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7, 21, 5), Quaternion.Euler(75, 180, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(7, 21, 5))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(20, 18, -3), Quaternion.Euler(75, -90, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(20, 18, -3))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7, 21, -10), Quaternion.Euler(75, 0, 0));
                }
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                if (camera.GetComponent<Transform>().position == new Vector3(7, 21, -10))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(20, 18, -3), Quaternion.Euler(75, -90, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(20, 18, -3))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7, 21, 5), Quaternion.Euler(75, 180, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(7, 21, 5))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6, 18, -3), Quaternion.Euler(75, 90, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(-6, 18f, -3))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7, 21, -10), Quaternion.Euler(75, 0, 0));
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (Input.GetKeyUp(KeyCode.Q))
            {
                if (camera.GetComponent<Transform>().position == new Vector3(6, 18.5f, 0))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 18.5f, -6), Quaternion.Euler(75, 0, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(0, 18.5f, -6))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6, 18.5f, 0), Quaternion.Euler(75, 90, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(-6, 18.5f, 0))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 18.5f, 6), Quaternion.Euler(75, 180, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(0, 18.5f, 6))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(6, 18.5f, 0), Quaternion.Euler(75, -90, 0));
                }

            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                if (camera.GetComponent<Transform>().position == new Vector3(6, 18.5f, 0))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 18.5f, 6), Quaternion.Euler(75, 180, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(0, 18.5f, 6))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6, 18.5f, 0), Quaternion.Euler(75, 90, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(-6, 18.5f, 0))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 18.5f, -6), Quaternion.Euler(75, 0, 0));
                }
                else if (camera.GetComponent<Transform>().position == new Vector3(0, 18.5f, -6))
                {
                    camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(6, 18.5f, 0), Quaternion.Euler(75, -90, 0));
                }

            }
        }



        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerRepeater))
            {
                _currentRepeater = hit.transform.gameObject;
            }
            else if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerGround))
            {
                if (SceneManager.GetActiveScene().name == "Level1")
                {
                    if (repeaters.Count < maxRepeatersLvl1)
                    {
                        _currentRepeater = Instantiate(prefabRepeater, hit.point, Quaternion.identity);
                        repeaters.Add(_currentRepeater);
                    }
                }
                else if (SceneManager.GetActiveScene().name == "Level2")
                {
                    if (repeaters.Count < maxRepeatersLvl2)
                    {
                        _currentRepeater = Instantiate(prefabRepeater, hit.point, Quaternion.identity);
                        repeaters.Add(_currentRepeater);
                    }
                }

            }
            if (_currentRepeater != null)
            {
                posicionInicial = _currentRepeater.transform.position;
            }

            for (int i = 0; i < _areas.Length; i++)
            {
                _areas[i].enabled = true;

            }

        }
        else if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerGround))
            {
                _currentRepeater.transform.position = hit.point;
            }

            _currentRepeater.transform.Rotate(Input.GetAxis("Horizontal") * Vector3.up);
            _currentRepeater.GetComponent<Repeater>().SetLineDistance(Input.GetAxis("Vertical"));
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerRepeater))
            {
                if (hit.transform.gameObject != _currentRepeater)
                {
                    _currentRepeater.transform.position = posicionInicial;
                }
            }

            for (int i = 0; i < _areas.Length; i++)
            {
                _areas[i].enabled = false;

            }

            if (sum == trophies.Length)
            {
                print("Has ganado, enhorabuena");
                winPanel.SetActive(true);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerRepeater))
            {
                _currentRepeater = hit.transform.gameObject;
            }
            else if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerGround))
            {
                if (SceneManager.GetActiveScene().name == "Level2")
                {
                    if (dualRepeaters.Count < 2)
                    {
                        _currentRepeater = Instantiate(prefabDualRepeater, hit.point, Quaternion.identity);
                        dualRepeaters.Add(_currentRepeater);
                    }
                }
            }

            if (_currentRepeater != null)
            {
                posicionInicial = _currentRepeater.transform.position;
            }

            for (int i = 0; i < _areas.Length; i++)
            {
                _areas[i].enabled = true;

            }
        }
    }

    public void SwapTutorial()
    {
        tutorialPanel.SetActive(!tutorialPanel.activeSelf);
    }

    static public void GoToLvl1()
    {
        SceneManager.LoadScene(1);
    }

    static public void GoToLvl2()
    {
        SceneManager.LoadScene(2);
    }

    static public void ExitGame()
    {
        Application.Quit();
    }
}
