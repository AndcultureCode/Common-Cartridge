// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_0
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Linq;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="File.Type", Namespace="http://www.imsglobal.org/xsd/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("FileType")]
public partial class FileType
{

    #region Private fields
    private XDocument _data;

    private MetadataType _metadata;
    
    private List<System.Xml.XmlElement> _any;
    
    private string _href;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public FileType()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
        this._any = new List<System.Xml.XmlElement>();
        this._metadata = new MetadataType();
    }

    [System.Xml.Serialization.XmlIgnore]
    public XDocument Data
    {
        get
        {
            return this._data;
        }
        set
        {
            this._data = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("metadata")]
    public MetadataType Metadata
    {
        get
        {
            return this._metadata;
        }
        set
        {
            this._metadata = value;
        }
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public List<System.Xml.XmlElement> Any
    {
        get
        {
            return this._any;
        }
        set
        {
            this._any = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI", AttributeName="href")]
    public string Href
    {
        get
        {
            return this._href;
        }
        set
        {
            this._href = value;
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
