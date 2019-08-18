
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
public partial class PartInfo : EntityBase<PartInfo>
{
    /// <summary>
    /// Номер части.
    /// </summary>
    /// <summary>
    /// Partition Number.
    /// </summary>
        [XmlAttribute(DataType="integer")]
        public string PartNo { get; set; }
    /// <summary>
    /// Количество частей.
    /// </summary>
    /// <summary>
    /// Quantity of Partitions.
    /// </summary>
        [XmlAttribute(DataType="integer")]
        public string PartQuantity { get; set; }
    /// <summary>
    /// Уникальный идентификатор совокупности частей
    /// </summary>
        [XmlAttribute]
        public string PartAggregateID { get; set; }
}
}
