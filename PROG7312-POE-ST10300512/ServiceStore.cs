using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7312_POE_ST10300512
{
    public class ServiceStore
    {
        private static readonly ServiceStore _instance = new ServiceStore();
        public static ServiceStore Instance => _instance;

        // Node for a binary search tree to store requests by ID
        private class ServiceRequestNode
        {
            public ServiceStatus Data { get; set; }
            public ServiceRequestNode Left { get; set; }
            public ServiceRequestNode Right { get; set; }
            public ServiceRequestNode(ServiceStatus request)
            {
                Data = request;
            }
        }

        private ServiceRequestNode _root;


        // Add a request to binary search tree and heap
        public void AddRequest(ServiceStatus newRequest)
        {
            _root = AddRequestRecursive(_root, newRequest);
            AddRequestToHeap(newRequest);
        }

        // Find a request by its ID
        public ServiceStatus FindRequest(string uniqueID)
        {
            return FindRequestRecursive(_root, uniqueID);
        }

        // Get all requests in order by ID
        public List<ServiceStatus> GetAllRequests()
        {
            List<ServiceStatus> requests = new List<ServiceStatus>();
            InOrderTraversal(_root, requests);
            return requests;
        }

        // Recursively add a node to the binary search tree
        private ServiceRequestNode AddRequestRecursive(ServiceRequestNode current, ServiceStatus newRequest)
        {
            if (current == null)
            {
                return new ServiceRequestNode(newRequest);
            }
            if (string.Compare(newRequest.UniqueID, current.Data.UniqueID) < 0)
            {
                current.Left = AddRequestRecursive(current.Left, newRequest);
            }
            else
            {
                current.Right = AddRequestRecursive(current.Right, newRequest);
            }
            return current;
        }
        // Recursively search the binary search tree
        private ServiceStatus FindRequestRecursive(ServiceRequestNode current, string uniqueID)
        {
            if (current == null)
            {
                return null; 
            }
            if (current.Data.UniqueID == uniqueID)
            {
                return current.Data; 
            }
            if (string.Compare(uniqueID, current.Data.UniqueID) < 0)
            {
                return FindRequestRecursive(current.Left, uniqueID);
            }
            else
            {
                return FindRequestRecursive(current.Right, uniqueID);
            }
        }
        // Go through the binary search tree in order and collect requests
        private void InOrderTraversal(ServiceRequestNode node, List<ServiceStatus> requests)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, requests);
                requests.Add(node.Data);
                InOrderTraversal(node.Right, requests);
            }
        }

        // Min-heap for requests smaller number is more urgent
        private List<ServiceStatus> _requestHeap = new List<ServiceStatus>();

        // Add request to heap
        private void AddRequestToHeap(ServiceStatus newRequest)
        {
            _requestHeap.Add(newRequest);
            HeapUp(_requestHeap.Count - 1);
        }

        // Get the most urgent request
        public ServiceStatus GetNextUrgentRequest()
        {
            if (_requestHeap.Count == 0) return null;

            ServiceStatus next = _requestHeap[0];
            _requestHeap[0] = _requestHeap[_requestHeap.Count - 1];
            _requestHeap.RemoveAt(_requestHeap.Count - 1);
            HeapDown(0);
            return next;
        }

        // Move new object up in the heap
        private void HeapUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (_requestHeap[index].Priority < _requestHeap[parent].Priority)
                {
                    (_requestHeap[index], _requestHeap[parent]) = (_requestHeap[parent], _requestHeap[index]);
                    index = parent;
                }
                else
                {
                    break;
                }
            }
        }

        // Move down after removing
        private void HeapDown(int index)
        {
            int last = _requestHeap.Count - 1;
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;

                if (left <= last && _requestHeap[left].Priority < _requestHeap[smallest].Priority)
                    smallest = left;
                if (right <= last && _requestHeap[right].Priority < _requestHeap[smallest].Priority)
                    smallest = right;

                if (smallest != index)
                {
                    (_requestHeap[index], _requestHeap[smallest]) = (_requestHeap[smallest], _requestHeap[index]);
                    index = smallest;
                }
                else
                {
                    break;
                }
            }
        }

        // Node for workflow graph
        private class GraphNode
        {
            public string StatusName { get; set; }
            public List<GraphNode> Transitions { get; set; } = new List<GraphNode>();
            public GraphNode(string name) { StatusName = name; }
        }

        // Dictionary for workflow graph
        private Dictionary<string, GraphNode> _workflowGraph = new Dictionary<string, GraphNode>();

        public List<string> GetPossibleNextSteps(string currentStatus)
        {
            if (_workflowGraph.ContainsKey(currentStatus))
            {
                return _workflowGraph[currentStatus].Transitions.Select(node => node.StatusName).ToList();
            }
            return new List<string>(); 
        }

        public bool UpdateRequestStatus(ServiceStatus request, string newStatus)
        {
            string current = request.CurrentStatus;
            if (_workflowGraph.ContainsKey(current))
            {
                if (_workflowGraph[current].Transitions.Any(node => node.StatusName == newStatus))
                {
                    request.CurrentStatus = newStatus;
                    return true; 
                }
            }
            return false;
        }

        // Build workflow graph with valid transitions
        private void BuildWorkflowGraph()
        {
            var submitted = new GraphNode("Submitted");
            var assigned = new GraphNode("Assigned");
            var inProgress = new GraphNode("In Progress");
            var resolved = new GraphNode("Resolved");
            var closed = new GraphNode("Closed");
            var cancelled = new GraphNode("Cancelled");

            _workflowGraph.Add(submitted.StatusName, submitted);
            _workflowGraph.Add(assigned.StatusName, assigned);
            _workflowGraph.Add(inProgress.StatusName, inProgress);
            _workflowGraph.Add(resolved.StatusName, resolved);
            _workflowGraph.Add(closed.StatusName, closed);
            _workflowGraph.Add(cancelled.StatusName, cancelled);

            submitted.Transitions.Add(assigned);
            submitted.Transitions.Add(cancelled);

            assigned.Transitions.Add(inProgress);
            assigned.Transitions.Add(cancelled);

            inProgress.Transitions.Add(resolved);
            inProgress.Transitions.Add(cancelled);

            resolved.Transitions.Add(closed);
        }
        // Constructor
        private ServiceStore()
        {
            BuildWorkflowGraph();

            // Load existing issues into binary search tree and heap
            foreach (var issue in IssueStore.Issues)
            {
                var serviceStatus = new ServiceStatus(issue);
                AddRequest(serviceStatus);
            }
        }
    }
}


/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/