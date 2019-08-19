
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
public partial class PayeeRU : EntityBase<PayeeRU>
{
        [StringLengthAttribute(160, MinimumLength=1)]
        public string Name { get; set; }
        public BankRU Bank { get; set; }
    /// <summary>
    /// Номер счета получателя средств (поле 17).
    /// </summary>
    /// <summary>
    /// Beneficiary's Account (Field 17).
    /// </summary>
        [XmlAttribute]
        public string PersonalAcc { get; set; }
    /// <summary>
    /// ИНН получателя средств (поле 61).
    /// </summary>
    /// <summary>
    /// Beneficiary's INN if assigned (Field 61).
    /// </summary>
        [XmlAttribute]
        public string INN { get; set; }
    /// <summary>
    /// Код постановки на учет (КПП) получателя средств (поле 103).
    /// </summary>
    /// <summary>
    /// Beneficiary's Tax Registration Code (KPP) if assigned (Field 103).
    /// </summary>
        [XmlAttribute]
        public string KPP { get; set; }
    
    public PayeeRU()
    {
        Bank = new BankRU();
    }
}
}
