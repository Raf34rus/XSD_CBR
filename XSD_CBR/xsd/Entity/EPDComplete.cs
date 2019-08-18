
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
public partial class EPDComplete : ED
{
        public SettleNotEarlier SettleNotEarlier { get; set; }
        public SettleNotLater SettleNotLater { get; set; }
        public AccDocRefID AccDoc { get; set; }
        public PayerRU Payer { get; set; }
        public PayeeRU Payee { get; set; }
    /// <summary>
    /// Уникальный идентификатор получателя ЭС.
    /// </summary>
    /// <summary>
    /// EM Receiver Unique Identifier.
    /// </summary>
        [XmlAttribute]
        public string EDReceiver { get; set; }
    /// <summary>
    /// Вид платежа (поле 5).
    /// </summary>
    /// <summary>
    /// FTI's Type (Field 5).
    /// </summary>
        [XmlAttribute]
        public string PaytKind { get; set; }
    /// <summary>
    /// Сумма (поле 7).
    /// </summary>
    /// <summary>
    /// Amount (Field 7).
    /// </summary>
        [XmlAttribute(DataType="integer")]
        public string Sum { get; set; }
    /// <summary>
    /// Приоритет платежа.
    /// </summary>
    /// <summary>
    /// Payment Priority.
    /// </summary>
        [XmlAttribute]
        public string PaymentPrecedence { get; set; }
    /// <summary>
    /// Запрошенная (требуемая) дата исполнения распоряжения.
    /// </summary>
    /// <summary>
    /// Requested Setllement Date.
    /// </summary>
        [XmlAttribute(DataType="date")]
        public System.DateTime ReqSettlementDate { get; set; }
    
    public EPDComplete()
    {
        Payee = new PayeeRU();
        Payer = new PayerRU();
        AccDoc = new AccDocRefID();
        SettleNotLater = new SettleNotLater();
        SettleNotEarlier = new SettleNotEarlier();
    }
}
}
