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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="DefaultValue.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("defaultValue", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class DefaultValueType
{
    
    #region Private fields
    private List<ValueType> _value;
    
    private string _interpretation;
    #endregion
    
    public DefaultValueType()
    {
        this._value = new List<ValueType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("value", ElementName="value")]
    public List<ValueType> Value
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString", AttributeName="interpretation")]
    public string Interpretation
    {
        get
        {
            return this._interpretation;
        }
        set
        {
            this._interpretation = value;
        }
    }
}
}
#pragma warning restore