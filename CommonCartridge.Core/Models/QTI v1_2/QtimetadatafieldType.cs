// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.QTIv1_2
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="qtimetadatafieldType")]
[System.Xml.Serialization.XmlRootAttribute("qtimetadatafieldType")]
public partial class QtimetadatafieldType
{
    
    #region Private fields
    private string _fieldlabel;
    
    private string _fieldentry;
    
    private string _lang;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("fieldlabel")]
    public string Fieldlabel
    {
        get
        {
            return this._fieldlabel;
        }
        set
        {
            this._fieldlabel = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("fieldentry")]
    public string Fieldentry
    {
        get
        {
            return this._fieldentry;
        }
        set
        {
            this._fieldentry = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="lang")]
    public string Lang
    {
        get
        {
            return this._lang;
        }
        set
        {
            this._lang = value;
        }
    }
}
}
#pragma warning restore