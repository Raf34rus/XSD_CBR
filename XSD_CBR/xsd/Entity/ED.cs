
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

[XmlIncludeAttribute(typeof(ED542))]
[XmlIncludeAttribute(typeof(PacketEDWithPartInfo))]
[XmlIncludeAttribute(typeof(ESWithMandatoryEDReceiver))]
[XmlIncludeAttribute(typeof(ESWithEDSender))]
[XmlIncludeAttribute(typeof(ESID))]
[XmlIncludeAttribute(typeof(ESIDResponse))]
[XmlIncludeAttribute(typeof(ESIDWithPartInfo))]
[XmlIncludeAttribute(typeof(EPDComplete))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED : EDRefID
{
        [XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any { get; set; }
    
    public ED()
    {
        Any = new List<System.Xml.XmlElement>();
    }
}
}
