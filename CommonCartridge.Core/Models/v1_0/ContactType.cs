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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Contact.Type", Namespace="http://www.imsglobal.org/xsd/imslticp_v1p0")]
[System.Xml.Serialization.XmlRootAttribute("ContactType")]
public partial class ContactType
{
    
    #region Private fields
    private string _email;
    
    private List<System.Xml.XmlElement> _any;
    #endregion
    
    public ContactType()
    {
        this._any = new List<System.Xml.XmlElement>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("email")]
    public string Email
    {
        get
        {
            return this._email;
        }
        set
        {
            this._email = value;
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
}
}
#pragma warning restore
