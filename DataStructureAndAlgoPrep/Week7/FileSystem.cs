using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgoPrep.Week7;

public class FileSystem
{
    private readonly DirectoryNode root;

    public FileSystem()
    {
        this.root = new DirectoryNode
        {
            Name = "/",
        };
    }

    public IList<string> Ls(string path)
    {
        string[] pathElements = path.Split("/");
        IList<string> lsResult = new List<string>();
        Node currentNode = this.root;

        for (int i = 0; i < pathElements.Length; ++i)
        {
            if (currentNode is DirectoryNode)
            {
                foreach (Node item in ((DirectoryNode)currentNode).DirectoryItems)
                {
                    if (item.Name.Equals(pathElements[i]))
                    {
                        currentNode = item;
                    }
                }
            }
            else
            {
                break;
            }
        }

        if (currentNode is DirectoryNode)
        {
            foreach (Node item in ((DirectoryNode)currentNode).DirectoryItems)
            {
                lsResult.Add(item.Name);
            }
        }
        else
        {
            lsResult.Add(pathElements[pathElements.Length-1]);
        }

        return lsResult.OrderBy((str) => str).ToList();
    }

    public void Mkdir(string path)
    {
        string[] pathElemennts = path.Split("/");
        Node currentNode = this.root;

        for (int i = 1; i < pathElemennts.Length; ++i)
        {
            if (currentNode is DirectoryNode)
            {
                bool fileExists = false;
                Node tempNode = null;

                foreach (var item in ((DirectoryNode)currentNode).DirectoryItems)
                {
                    if (item.Name.Equals(pathElemennts[i]))
                    {
                        fileExists = true;
                        tempNode = item;
                        break;
                    }
                }

                if (fileExists)
                {
                    currentNode = tempNode;
                }
                else
                {

                    Node newNode = new DirectoryNode
                    {
                        Name = pathElemennts[i],
                    };

                    ((DirectoryNode)currentNode).DirectoryItems.Add(newNode);
                    currentNode = newNode;
                }
            }
        }
    }

    public void AddContentToFile(string filePath, string content)
    {
        Node currentNode = this.root;
        string[] pathElements = filePath.Split("/");

        for (int i = 1; i < pathElements.Length - 1; ++i)
        {
            if (currentNode is DirectoryNode)
            {
                bool fileExists = false;
                Node tempNode = null;

                foreach (var item in ((DirectoryNode)currentNode).DirectoryItems)
                {
                    if (item.Name.Equals(pathElements[i]))
                    {
                        fileExists = true;
                        tempNode = item;
                        break;
                    }
                }

                if (fileExists)
                {
                    currentNode = tempNode;
                }
                else
                {
                    Node newNode = new DirectoryNode
                    {
                        Name = pathElements[i],
                    };

                    ((DirectoryNode)currentNode).DirectoryItems.Add(newNode);
                    currentNode = newNode;
                }
            }
        }

        bool fileExists2 = false;
        Node tempNode2 = null;
        foreach (var item in ((DirectoryNode)currentNode).DirectoryItems)
        {
            if (item.Name.Equals(pathElements[pathElements.Length - 1]))
            {
                fileExists2 = true;
                tempNode2 = item;
                break;
            }
        }

        if (fileExists2)
        {
            ((FileNode)tempNode2).Content += content;
        }
        else
        {
            Node newNode = new FileNode
            {
                Name = pathElements[pathElements.Length - 1],
                Content = content,
            };

            ((DirectoryNode)currentNode).DirectoryItems.Add(newNode);
        }
    }

    public string ReadContentFromFile(string filePath)
    {
        Node currentNode = this.root;
        string[] filePathElements = filePath.Split("/");
        StringBuilder strBuilder = new StringBuilder();

        for (int i = 1; i < filePathElements.Length - 1; ++i)
        {
            if (currentNode is DirectoryNode)
            {
                foreach (Node item in ((DirectoryNode)currentNode).DirectoryItems)
                {
                    if (item.Name.Equals(filePathElements[i]))
                    {
                        currentNode = item;
                        break;
                    }
                }
            }
        }

        foreach (Node item in ((DirectoryNode)currentNode).DirectoryItems)
        {
            if (item.Name.Equals(filePathElements[filePathElements.Length-1]))
            {
                strBuilder.Append(((FileNode)item).Content);
                break;
            }
        }

        return strBuilder.ToString();
    }
}

public abstract class Node
{
    public string Name { get; set; }
}

public class FileNode : Node
{
    public string Content { get; set; }
}

public class DirectoryNode : Node
{
    public IList<Node> DirectoryItems { get; set; } = new List<Node>();
}
