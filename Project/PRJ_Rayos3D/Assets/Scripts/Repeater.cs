using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class Repeater : MonoBehaviour
{
    public float lineDistance = 10;
    private LineRenderer _lineR, _branchLineRenderer;
    private Repeater _lastRepeater, _lastDualRepeater;
    public Vector3 hitPoint;

    public bool isDouble;

    [SerializeField] private bool _isFocus = false;
    [SerializeField] Transform spawnPoint, branchPoint;
    [SerializeField] GameObject _ps;

    // Start is called before the first frame update
    private void Awake()
    {
        _lineR = GetComponent<LineRenderer>();
        if (isDouble)
        {
            _branchLineRenderer = new GameObject("BranchLineRenderer").AddComponent<LineRenderer>();
            _branchLineRenderer.transform.SetParent(transform);

            _branchLineRenderer.startWidth = 0.2f;
            _branchLineRenderer.endWidth = 0.2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _lineR.SetPosition(0, spawnPoint.position);
        _lineR.SetPosition(1, spawnPoint.position + spawnPoint.forward * lineDistance);
        Repeater target = null;
        Repeater target2 = null;


        if (Physics.Raycast(spawnPoint.position, spawnPoint.forward, out RaycastHit hit, lineDistance))
        {
            _lineR.SetPosition(1, hit.point);

            if (isDouble)
            {
                _branchLineRenderer.SetPosition(0, branchPoint.position);
                _branchLineRenderer.SetPosition(1, branchPoint.position + branchPoint.forward * lineDistance);
                _branchLineRenderer.enabled = true;


                if (Physics.Raycast(branchPoint.position, branchPoint.forward, out RaycastHit hit2, lineDistance))
                {
                    _branchLineRenderer.SetPosition(1, hit2.point);
                }


                target2 = hit2.transform.gameObject.GetComponent<Repeater>();

                if (target2 != null)
                {
                    target2.hitPoint = hit.point;
                    target2.enabled = true;
                }
            }


            target = hit.transform.gameObject.GetComponent<Repeater>();

            if (target != null)
            {
                target.hitPoint = hit.point;
                target.enabled = true;
            }
        }

        if (_lastRepeater != null && _lastRepeater != target)
        {
            _lastRepeater.enabled = false;
        }

        if (_lastDualRepeater != null && _lastDualRepeater != target2)
        {
            _lastDualRepeater.enabled = false;
        }


        _lastRepeater = target;
        _lastDualRepeater = target2;
    }

    private void OnEnable()
    {
        _lineR.enabled = true;
        if (isDouble)
        {
            _branchLineRenderer.enabled = true;
        }
        if (_ps == null)
        {
            return;
        }

        _ps.SetActive(true);

        if (!_isFocus)
        {
            _ps.transform.position = hitPoint;
        }
    }

    private void OnDisable()
    {
        if (_lastRepeater != null)
        {
            _lastRepeater.enabled = false;
        }

        if (_lastDualRepeater != null)
        {
            _lastDualRepeater.enabled = false;
        }

        _lineR.enabled = false;
        if (isDouble)
        {
            _branchLineRenderer.enabled = false;
        }
        _ps.SetActive(false);
    }

    public void SetLineDistance(float increment)
    {
        lineDistance = Mathf.Clamp(lineDistance + increment * 0.25f, 0, 20);
    }
}
