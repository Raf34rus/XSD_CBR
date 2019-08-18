
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
public partial class PayerRU : EntityBase<PayerRU>
{
        [StringLengthAttribute(160, MinimumLength=1)]
        public string Name { get; set; }
        public BankRU Bank { get; set; }
    /// <summary>
    /// Номер счета плательщика (поле 9).
    /// </summary>
    /// <summary>
    /// Payer's Account (Field 9).
    /// </summary>
        [XmlAttribute]
        public string PersonalAcc { get; set; }
    /// <summary>
    /// ИНН плательщика (поле 60).
    /// </summary>
    /// <summary>
    /// Payer's INN if assigned (Field 60).
    /// </summary>
        [XmlAttribute]
        public string INN { get; set; }
    /// <summary>
    /// Код постановки на учет (КПП) плательщика (поле 102).
    /// </summary>
    /// <summary>
    /// Payer's Tax Registration Code (KPP) if assigned (Field 102).
    /// </summary>
        [XmlAttribute]
        public string KPP { get; set; }
    
    public PayerRU()
    {
        Bank = new BankRU();
    }
}
}
