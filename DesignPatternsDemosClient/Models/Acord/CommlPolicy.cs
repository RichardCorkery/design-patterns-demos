﻿namespace DesignPatternsDemosClient.Models.Acord;

[XmlRoot("CommlPolicy")]
public class CommlPolicy
{
    [XmlElement("PolicyNumber")]
    public string PolicyNumber { get; set; }

    [XmlElement("LOBCd")]
    public string LobCd { get; set; }

    [XmlElement("NAICCd")]
    public string NaicCd { get; set; }

    [XmlElement("PolicyStatusCd")]
    public string PolicyStatusCd { get; set; }

    [XmlElement("ContractTerm")]
    public ContractTerm ContractTerm { get; set; }

    [XmlElement("CurrentTermAmt")]
    public CurrentTermAmt CurrentTermAmt { get; set; }
}