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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ObjectFileInfo.Type", Namespace="http://www.imsglobal.org/xsd/apip/apipv1p0/imsapip_qtiv1p0")]
[System.Xml.Serialization.XmlRootAttribute("ObjectFileInfoType")]
public partial class ObjectFileInfoType
{
    
    #region Private fields
    private string _fileHref;
    
    private string _contentLinkIdentifier;
    
    private string _mimeType;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", ElementName="fileHref")]
    public string FileHref
    {
        get
        {
            return this._fileHref;
        }
        set
        {
            this._fileHref = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="contentLinkIdentifier")]
    public string ContentLinkIdentifier
    {
        get
        {
            return this._contentLinkIdentifier;
        }
        set
        {
            this._contentLinkIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString", AttributeName="mimeType")]
    public string MimeType
    {
        get
        {
            return this._mimeType;
        }
        set
        {
            this._mimeType = value;
        }
    }
}
}
#pragma warning restore