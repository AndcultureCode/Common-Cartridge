// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_1
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="CopyrightAndOtherRestrictions.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p1/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("CopyrightAndOtherRestrictionsType")]
public partial class CopyrightAndOtherRestrictionsType
{
    
    #region Private fields
    private CopyrightAndOtherRestrictionsTypeValue _value;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CopyrightAndOtherRestrictionsTypeValue Value
    {
        get
        {
            return this._value;
        }
        set
        {
            this._value = value;
        }
    }
}
}
#pragma warning restore
