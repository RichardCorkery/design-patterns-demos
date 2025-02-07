﻿using Newtonsoft.Json;

namespace DesignPatternsDemosClient.Models.Policy;

public class PolicyRoot
{
    public Guid RequestId { get; set; }
        
    public string? PolicyNumber { get; set; }

    public DateTime EffectiveDate { get; set; }

    public DateTime ExpirationDate { get; set; }
    
    public int Term { get; set; }

    public string? PrimaryState { get; set; }

    public Guid TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public string? PolicyStatusCd { get; set; }

    [JsonProperty("LOBCd")]
    public string LobCd { get; set; }

    [JsonProperty("NAICCd")]
    public string NaicCd { get; set; }

    [JsonProperty("BroadLOBCd")]
    public string BroadLobCd { get; set; }

    public string SystemSource { get; set; }

    public decimal Premium { get; set; }

    public Insured? Insured { get; set; }

    public Agency? Agency { get; set; }
    public GeneralLiability? GeneralLiability { get; set; }
}