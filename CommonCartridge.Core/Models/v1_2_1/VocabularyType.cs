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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiresv1p2", TypeName="vocabularyType")]
[System.Xml.Serialization.XmlRootAttribute("vocabulary", Namespace="http://www.imsglobal.org/xsd/ims_qtiresv1p2", IsNullable=false, ElementName="vocabularyType")]
public partial class VocabularyType
{
    
    #region Private fields
    private string _uri;
    
    private string _entityref;
    
    private string _vocab_type;
    
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="vocab_type")]
    public string Vocab_type
    {
        get
        {
            return this._vocab_type;
        }
        set
        {
            this._vocab_type = value;
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