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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="LangString.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p3/LOM/resource")]
[System.Xml.Serialization.XmlRootAttribute("LangStringType1")]
public partial class LangStringType1
{
    
    #region Private fields
    private List<LanguageStringType1> _string;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public LangStringType1()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
        this._string = new List<LanguageStringType1>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("string", ElementName="string")]
    public List<LanguageStringType1> String
    {
        get
        {
            return this._string;
        }
        set
        {
            this._string = value;
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
}
}
#pragma warning restore
