// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_3
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="LanguageString.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p3/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("LanguageStringType")]
public partial class LanguageStringType
{
    
    #region Private fields
    private string _language;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    
    private string _value;
    #endregion
    
    public LanguageStringType()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="language")]
    public string Language
    {
        get
        {
            return this._language;
        }
        set
        {
            this._language = value;
        }
    }
    
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public List<System.Xml.XmlAttribute> AnyAttr
    {
        get
        {
            return this._anyAttr;
        }
        set
        {
            this._anyAttr = value;
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
