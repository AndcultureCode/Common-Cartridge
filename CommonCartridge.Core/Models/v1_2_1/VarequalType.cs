// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_2_1
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtilitev1p2", TypeName="varequalType")]
[System.Xml.Serialization.XmlRootAttribute("varequal", Namespace="http://www.imsglobal.org/xsd/ims_qtilitev1p2", IsNullable=false, ElementName="varequalType")]
public partial class VarequalType
{
    
    #region Private fields
    private string _respident;
    
    private string _value;
    #endregion
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="respident")]
    public string Respident
    {
        get
        {
            return this._respident;
        }
        set
        {
            this._respident = value;
        }
    }
    
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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