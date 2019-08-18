
namespace classByXSD
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:cbr-ru:ed:v2.0")]
public partial class PacketEDWithPartInfo : ED
{
        public PartInfo PartInfo { get; set; }
        public EDRefID InitialED { get; set; }
    
    public PacketEDWithPartInfo()
    {
        InitialED = new EDRefID();
        PartInfo = new PartInfo();
    }
}
}
