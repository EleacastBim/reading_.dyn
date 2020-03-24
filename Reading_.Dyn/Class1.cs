using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_.Dyn
{
    public class ResolutionMap
    {
    }

    public class ElementResolver
    {
        public ResolutionMap ResolutionMap { get; set; }
    }

    public class Output
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool UsingDefaultValue { get; set; }
        public int Level { get; set; }
        public bool UseLevels { get; set; }
        public bool KeepListStructure { get; set; }
    }

    public class Node
    {
        public string ConcreteType { get; set; }
        public string NodeType { get; set; }
        public string FunctionSignature { get; set; }
        public string Id { get; set; }
        public List<object> Inputs { get; set; }
        public List<Output> Outputs { get; set; }
        public string Replication { get; set; }
        public string Description { get; set; }
        public string FunctionType { get; set; }
        public bool? VariableInputPorts { get; set; }
    }

    public class Connector
    {
        public string Start { get; set; }
        public string End { get; set; }
        public string Id { get; set; }
    }

    public class NodeLibraryDependency
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string ReferenceType { get; set; }
        public List<string> Nodes { get; set; }
    }

    public class Dynamo
    {
        public double ScaleFactor { get; set; }
        public bool HasRunWithoutCrash { get; set; }
        public bool IsVisibleInDynamoLibrary { get; set; }
        public string Version { get; set; }
        public string RunType { get; set; }
        public string RunPeriod { get; set; }
    }

    public class Camera
    {
        public string Name { get; set; }
        public double EyeX { get; set; }
        public double EyeY { get; set; }
        public double EyeZ { get; set; }
        public double LookX { get; set; }
        public double LookY { get; set; }
        public double LookZ { get; set; }
        public double UpX { get; set; }
        public double UpY { get; set; }
        public double UpZ { get; set; }
    }

    public class NodeView
    {
        public bool ShowGeometry { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public bool IsSetAsInput { get; set; }
        public bool IsSetAsOutput { get; set; }
        public bool Excluded { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class View
    {
        public Dynamo Dynamo { get; set; }
        public Camera Camera { get; set; }
        public List<NodeView> NodeViews { get; set; }
        public List<object> Annotations { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Zoom { get; set; }
    }

    public class RootObject
    {
        public string Uuid { get; set; }
        public bool IsCustomNode { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public ElementResolver ElementResolver { get; set; }
        public List<object> Inputs { get; set; }
        public List<object> Outputs { get; set; }
        public List<Node> Nodes { get; set; }
        public List<Connector> Connectors { get; set; }
        public List<string> Dependencies { get; set; }
        public List<NodeLibraryDependency> NodeLibraryDependencies { get; set; }
        public List<object> Bindings { get; set; }
        public View View { get; set; }
    }
}