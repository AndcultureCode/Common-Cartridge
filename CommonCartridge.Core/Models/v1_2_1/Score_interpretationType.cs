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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiresv1p2", TypeName="score_interpretationType")]
[System.Xml.Serialization.XmlRootAttribute("score_interpretation", Namespace="http://www.imsglobal.org/xsd/ims_qtiresv1p2", IsNullable=false, ElementName="score_interpretationType")]
public partial class Score_interpretationType
{
    
    #region Private fields
    private string _uri;
    
    private string _entityref;
    
    private string _value;
    #endregion
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="uri")]
    public string Uri
    {
        get
        {
            return this._uri;
        }
        set
        {
            this._uri = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ENTITY", AttributeName="entityref")]
    public string Entityref
    {
        get
        {
            return this._entityref;
        }
        set
        {
            this._entityref = value;
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