﻿namespace DesignPatternsDemosClient.Services.Minis.RulesEngines.Rules;

public class GeneralLiabilityDeductiblesConverter : IPolicyConverterRule
{
    public PolicyRoot Convert(Acord acord, PolicyRoot policy)
    {
        ArgumentNullException.ThrowIfNull(acord);
        ArgumentNullException.ThrowIfNull(policy);

        if (policy.GeneralLiability == null) return policy;

        var generalLiabilityDeductible = new GeneralLiabilityDeductible();
        
        var propertyDamageDeductible = acord.InsuranceSvcRq.CommlPkgPolicyAddRq.GeneralLiabilityLineBusiness.Deductibles.FirstOrDefault(d => d.DeductibleAppliesToCd == DeductibleAppliesCode.PropertyDamage);
        if (propertyDamageDeductible is not null)
        {
            generalLiabilityDeductible.PropertyDamageDeductibleType = propertyDamageDeductible.DeductibleTypeCd;
            generalLiabilityDeductible.PropertyDamageDeductible = propertyDamageDeductible.FormatInteger.GetValueOrDefault();
        }

        var bodilyInjuryDeductible = acord.InsuranceSvcRq.CommlPkgPolicyAddRq.GeneralLiabilityLineBusiness.Deductibles.FirstOrDefault(d => d.DeductibleAppliesToCd == DeductibleAppliesCode.BodilyInjury);
        if (bodilyInjuryDeductible is not null)
        {
            generalLiabilityDeductible.BodilyInjuryeDeductibleType = bodilyInjuryDeductible.DeductibleTypeCd;
            generalLiabilityDeductible.BodilyInjuryeDeductible = bodilyInjuryDeductible.FormatInteger.GetValueOrDefault();
        }

        policy.GeneralLiability.GeneralLiabilityDeductible = generalLiabilityDeductible;

        return policy;
    }
}