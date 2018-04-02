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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Mapping.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("mapping", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class MappingType
{
    
    #region Private fields
    private List<MapEntryType> _mapEntry;
    
    private double _lowerBound;
    
    private double _upperBound;
    
    private double _defaultValue;
    #endregion
    
    public MappingType()
    {
        this._mapEntry = new List<MapEntryType>();
        this._defaultValue = 0D;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("mapEntry", ElementName="mapEntry")]
    public List<MapEntryType> MapEntry
    {
        get
        {
            return this._mapEntry;
        }
        set
        {
            this._mapEntry = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="lowerBound")]
    public double LowerBound
    {
        get
        {
            return this._lowerBound;
        }
        set
        {
            this._lowerBound = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="upperBound")]
    public double UpperBound
    {
        get
        {
            return this._upperBound;
        }
        set
        {
            this._upperBound = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="defaultValue")]
    [System.ComponentModel.DefaultValueAttribute(0D)]
    public double DefaultValue
    {
        get
        {
            return this._defaultValue;
        }
        set
        {
            this._defaultValue = value;
        }
    }
}
}
#pragma warning restore