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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Resource.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p1/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("ResourceType1")]
public partial class ResourceType1
{
    
    #region Private fields
    private ResourceMetadataType _metadata;
    
    private List<FileType> _file;
    
    private List<DependencyType> _dependency;
    
    private string _identifier;
    
    private ResourceTypeType _type;
    
    private string _href;
    
    private string _base;
    
    private ResourceTypeIntendeduse _intendeduse;
    
    private bool _protected;
    #endregion
    
    public ResourceType1()
    {
        this._dependency = new List<DependencyType>();
        this._file = new List<FileType>();
        this._metadata = new ResourceMetadataType();
        this._protected = false;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("metadata")]
    public ResourceMetadataType Metadata
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
    
    [System.Xml.Serialization.XmlElementAttribute("file", ElementName="file")]
    public List<FileType> File
    {
        get
        {
            return this._file;
        }
        set
        {
            this._file = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("dependency", ElementName="dependency")]
    public List<DependencyType> Dependency
    {
        get
        {
            return this._dependency;
        }
        set
        {
            this._dependency = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="identifier")]
    public string Identifier
    {
        get
        {
            return this._identifier;
        }
        set
        {
            this._identifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="type")]
    public ResourceTypeType Type
    {
        get
        {
            return this._type;
        }
        set
        {
            this._type = value;
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="base")]
    public string Base
    {
        get
        {
            return this._base;
        }
        set
        {
            this._base = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="intendeduse")]
    public ResourceTypeIntendeduse Intendeduse
    {
        get
        {
            return this._intendeduse;
        }
        set
        {
            this._intendeduse = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.imsglobal.org/xsd/imsccv1p1/imsccauth_v1p1", AttributeName="protected")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Protected
    {
        get
        {
            return this._protected;
        }
        set
        {
            this._protected = value;
        }
    }
}
}
#pragma warning restore
