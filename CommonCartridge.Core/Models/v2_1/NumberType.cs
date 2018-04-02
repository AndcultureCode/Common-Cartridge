// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v2_1
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Number.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("numberCorrect", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class NumberType : EmptyPrimitiveTypeType
{
    
    #region Private fields
    private string _sectionIdentifier;
    
    private List<string> _includeCategory;
    
    private List<string> _excludeCategory;
    #endregion
    
    public NumberType()
    {
        this._excludeCategory = new List<string>();
        this._includeCategory = new List<string>();
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="sectionIdentifier")]
    public string SectionIdentifier
    {
        get
        {
            return this._sectionIdentifier;
        }
        set
        {
            this._sectionIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="includeCategory")]
    public List<string> IncludeCategory
    {
        get
        {
            return this._includeCategory;
        }
        set
        {
            this._includeCategory = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="excludeCategory")]
    public List<string> ExcludeCategory
    {
        get
        {
            return this._excludeCategory;
        }
        set
        {
            this._excludeCategory = value;
        }
    }
}
}
#pragma warning restore