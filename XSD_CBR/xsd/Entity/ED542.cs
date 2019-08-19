
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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:cbr-ru:ed:v2.0")]
[XmlRootAttribute(Namespace="urn:cbr-ru:ed:v2.0", IsNullable=false)]
public partial class ED542 : ED
{
        [XmlElement("EDRefID")]
        public EDRefID EDRefID1 { get; set; }
    /// <summary>
    /// Тип запроса
    /// </summary>
        [XmlAttribute]
        public string RepeatReceptInqCode { get; set; }
    /// <summary>
    /// Тип ЭС.
    /// </summary>
        [XmlAttribute]
        public string EDTypeNo { get; set; }
        /// <summary>
        /// Номер АРМ.
        /// </summary>
        [XmlAttribute]
        public string ARMNo { get; set; }
    
    public ED542()
    {
        EDRefID1 = new EDRefID();
    }
}
}
