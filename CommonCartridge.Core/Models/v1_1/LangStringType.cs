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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="LangString.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p1/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("LangStringType")]
public partial class LangStringType
{
    
    #region Private fields
    private List<LanguageStringType> _string;
    #endregion
    
    public LangStringType()
    {
        this._string = new List<LanguageStringType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("string", ElementName="string")]
    public List<LanguageStringType> String
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
}
}
#pragma warning restore
