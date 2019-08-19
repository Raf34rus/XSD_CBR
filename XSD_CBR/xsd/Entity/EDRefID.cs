
namespace ClassByXSD
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

[XmlIncludeAttribute(typeof(ED))]
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
public partial class EDRefID : EntityBase<EDRefID>
{
        [XmlAttribute(DataType="integer")]
        public string EDNo { get; set; }
        [XmlAttribute(DataType="date")]
        public System.DateTime EDDate { get; set; }
        [XmlAttribute]
        public string EDAuthor { get; set; }
}
}
