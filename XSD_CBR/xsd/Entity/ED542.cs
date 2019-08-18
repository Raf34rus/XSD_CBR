
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

namespace XSD_CBR
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:cbr-ru:ed:v2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:cbr-ru:ed:v2.0", IsNullable=false)]
    public partial class ED542 : ED
    {
    
            [System.Xml.Serialization.XmlElementAttribute("EDRefID", Order=0)]
            public EDRefID EDRefID { get; set; }
        /// <summary>
        /// Тип запроса
        /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RepeatReceptInqCode { get; set; }
        /// <summary>
        /// Тип ЭС.
        /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string EDTypeNo { get; set; }
        /// <summary>
        /// Номер АРМ.
        /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ARMNo { get; set; }
            [XmlIgnore()]
            public bool EDRefID1Specified { get; set; }
            [XmlIgnore()]
            public bool RepeatReceptInqCodeSpecified { get; set; }
            [XmlIgnore()]
            public bool EDTypeNoSpecified { get; set; }
            [XmlIgnore()]
            public bool ARMNoSpecified { get; set; }
    
        public ED542()
        {
            this.EDRefID = new EDRefID();
        }

    }
}

