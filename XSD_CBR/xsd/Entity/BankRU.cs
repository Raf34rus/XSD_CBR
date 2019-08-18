
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
public partial class BankRU : EntityBase<BankRU>
{
    /// <summary>
    /// БИК КО, филиала КО, иностранного банка или ПБР (поле 11 или 14).
    /// </summary>
    /// <summary>
    /// Bank, Bank Branch or CBR Subdivision BIC (Field 11 or 14).
    /// </summary>
        [XmlAttribute]
        public string BIC { get; set; }
    /// <summary>
    /// Номер счета банка плательщика (поле 12) или номер счета банка получателя средств (поле 15).
    /// </summary>
    /// <summary>
    /// Payer Agent Account Number (Field 12) or Beneficiary Agent Account Number (Field 15) opened in CBR Subdivision.
    /// </summary>
        [XmlAttribute]
        public string CorrespAcc { get; set; }
}
}
