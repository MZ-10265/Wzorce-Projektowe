using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface INode
{
    string Name { get; }
    int GetSize();
    void Print(string indent = "");
}