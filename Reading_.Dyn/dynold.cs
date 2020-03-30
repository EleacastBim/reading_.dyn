using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading.Dyn
{
    public class Instance
    {
        public string @id { get; set; }
    }

    public class DynamoNodesDSModelElementsSelection
    {
        public string @guid { get; set; }
        public string @type { get; set; }
        public string @nickname { get; set; }
        public string @x { get; set; }
        public string @y { get; set; }
        public string @isVisible { get; set; }
        public string @isUpstreamVisible { get; set; }
        public string @lacing { get; set; }
        public string @isSelectedInput { get; set; }
        public string @IsFrozen { get; set; }
        public string @isPinned { get; set; }
        public List<Instance> instance { get; set; }
    }

    public class DynamoGraphNodesZeroTouchDSFunction
    {
        public string @guid { get; set; }
        public string @type { get; set; }
        public string @nickname { get; set; }
        public string @x { get; set; }
        public string @y { get; set; }
        public string @isVisible { get; set; }
        public string @isUpstreamVisible { get; set; }
        public string @lacing { get; set; }
        public string @isSelectedInput { get; set; }
        public string @IsFrozen { get; set; }
        public string @isPinned { get; set; }
        public string @assembly { get; set; }
        public string @function { get; set; }
        public object PortInfo { get; set; }
    }

    public class ID
    {
        public string @value { get; set; }
    }

    public class Name
    {
        public string @value { get; set; }
    }

    public class Description
    {
        public string @value { get; set; }
    }

    public class Inputs
    {
        public object Input { get; set; }
    }

    public class Output
    {
        public string @value { get; set; }
    }

    public class Outputs
    {
        public Output Output { get; set; }
    }

    public class DynamoGraphNodesCustomNodesFunction
    {
        public string @guid { get; set; }
        public string @type { get; set; }
        public string @nickname { get; set; }
        public string @x { get; set; }
        public string @y { get; set; }
        public string @isVisible { get; set; }
        public string @isUpstreamVisible { get; set; }
        public string @lacing { get; set; }
        public string @isSelectedInput { get; set; }
        public string @IsFrozen { get; set; }
        public string @isPinned { get; set; }
        public object PortInfo { get; set; }
        public ID ID { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public Inputs Inputs { get; set; }
        public Outputs Outputs { get; set; }
    }

    public class Elements
    {
        //public DynamoNodesDSModelElementsSelection Dynamo.Nodes.DSModelElementsSelection { get; set; }
        //public List<DynamoGraphNodesZeroTouchDSFunction> Dynamo.Graph.Nodes.ZeroTouch.DSFunction { get; set; }
        //public List<DynamoGraphNodesCustomNodesFunction> Dynamo.Graph.Nodes.CustomNodes.Function { get; set; }
    }

    public class DynamoGraphConnectorsConnectorModel
    {
        public string @start { get; set; }
        public string @startindex { get; set; }
        public string @end { get; set; }
        public string @endindex { get; set; }
        public string @portType { get; set; }
    }

    public class Connectors
    {
        //public DynamoGraphConnectorsConnectorModel Dynamo.Graph.Connectors.ConnectorModel { get; set; }
    }

    public class Camera
    {
        public string @Name { get; set; }
        public string @eyeX { get; set; }
        public string @eyeY { get; set; }
        public string @eyeZ { get; set; }
        public string @lookX { get; set; }
        public string @lookY { get; set; }
        public string @lookZ { get; set; }
        public string @upX { get; set; }
        public string @upY { get; set; }
        public string @upZ { get; set; }
    }

    public class Cameras
    {
        public Camera Camera { get; set; }
    }

    public class Workspace
    {
        public string @Version { get; set; }
        public string @X { get; set; }
        public string @Y { get; set; }
        public string @zoom { get; set; }
        public string @ScaleFactor { get; set; }
        public string @Name { get; set; }
        public string @Description { get; set; }
        public string @RunType { get; set; }
        public string @RunPeriod { get; set; }
        public string @HasRunWithoutCrash { get; set; }
        public object NamespaceResolutionMap { get; set; }
        public Elements Elements { get; set; }
        public Connectors Connectors { get; set; }
        public object Notes { get; set; }
        public object Annotations { get; set; }
        public object Presets { get; set; }
        public Cameras Cameras { get; set; }
    }

    public class Root
    {
        public Workspace Workspace { get; set; }
    }
    
}
