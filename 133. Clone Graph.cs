/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<Node, Node> visitedNodes = new Dictionary<Node, Node>();
    public Node CloneGraph(Node node) {
        return deepFirstSearch(node);
    }

    public Node deepFirstSearch(Node node) {
        if(node == null){
            return null;
        }

        if (visitedNodes.ContainsKey(node)) {
            return visitedNodes[node];
        }

        Node clonedNode = new Node(node.val);
        visitedNodes[node] = clonedNode;

        foreach(Node neighbor in node.neighbors){
            clonedNode.neighbors.Add(deepFirstSearch(neighbor));
        }


        return clonedNode;
    }
}

