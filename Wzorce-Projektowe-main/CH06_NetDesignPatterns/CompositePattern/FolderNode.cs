using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FolderNode : INode
{
    public string Name { get; }
    private readonly List<INode> _children = new();

    public FolderNode(string name)
    {
        Name = name;
    }

    public void Add(INode node) => _children.Add(node);
    public void Remove(INode node) => _children.Remove(node);

    public int GetSize()
    {
        int sum = 0;
        foreach (var child in _children)
            sum += child.GetSize();
        return sum;
    }

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}+ {Name} ({GetSize()} KB)");
        foreach (var child in _children)
            child.Print(indent + "  ");
    }
}