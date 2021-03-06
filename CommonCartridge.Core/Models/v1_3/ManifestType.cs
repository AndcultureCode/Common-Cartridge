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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Manifest.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("manifest", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscp_v1p1", IsNullable=false)]
public partial class ManifestType
{
    
    #region Private fields
    private ManifestMetadataType _metadata;
    
    private OrganizationsType _organizations;
    
    private ResourcesType _resources;
    
    private AuthorizationsType _authorizations;
    
    private string _identifier;
    
    private string _base;
    #endregion
    
    public ManifestType()
    {
        this._authorizations = new AuthorizationsType();
        this._resources = new ResourcesType();
        this._organizations = new OrganizationsType();
        this._metadata = new ManifestMetadataType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("metadata")]
    public ManifestMetadataType Metadata
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
    
    [System.Xml.Serialization.XmlElementAttribute("organizations")]
    public OrganizationsType Organizations
    {
        get
        {
            return this._organizations;
        }
        set
        {
            this._organizations = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("resources")]
    public ResourcesType Resources
    {
        get
        {
            return this._resources;
        }
        set
        {
            this._resources = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imsccauth_v1p3", ElementName="authorizations")]
    public AuthorizationsType Authorizations
    {
        get
        {
            return this._authorizations;
        }
        set
        {
            this._authorizations = value;
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
}
}
#pragma warning restore
