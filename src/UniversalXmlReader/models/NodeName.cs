using System;
using System.Collections.Generic;

namespace UniversalXmlReader.models
{
    public class NodeName
    {
        public string Name { get; set; }
        public List<NodeName> Children { get; set; }
        public bool IsRecurrent { get; set; }

        public NodeName(string name){
            Name = name;
        }
    }
}