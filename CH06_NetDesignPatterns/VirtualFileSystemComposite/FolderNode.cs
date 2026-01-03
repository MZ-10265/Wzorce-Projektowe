using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Folder może zawierać inne element: pliki, foldery
//folder implementuje ten sam interfejs INode co FileNode ale ma listę dzieci i działa rekurencyjnie

public sealed class FolderNode : INode
{
    public string Name { get; }

    // Dzieci folderu: mogą być FileNode lub FolderNode, ale trzymamy je jako INode, żeby klient nie musiał znać typów
    private readonly List<INode> _children = new();

    public FolderNode(string name)
    {
        Name = name;
    }

    //dodawanie elementu do folderu.
    public void Add(INode node) => _children.Add(node);

    // Usuwanie elementu z folderu.
    public void Remove(INode node) => _children.Remove(node);

    public int GetSize()
    {
        //Rekurencja: rozmiar folderu = suma rozmiarów dzieci
        int sum = 0;
        foreach (var child in _children)
        {
            sum += child.GetSize();
        }
        return sum;
    }

    public void Print(string indent = "")
    {
        //najpierw wypisujemy folder
        Console.WriteLine($"{indent}+ {Name} ({GetSize()} KB)");
        //potem wszystkie dzieci w środku(rekurencja)
        foreach (var child in _children)
        {
            child.Print(indent + "  ");
        }
    }
}