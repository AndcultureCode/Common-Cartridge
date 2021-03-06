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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="varequalType")]
[System.Xml.Serialization.XmlRootAttribute("varequalType")]
public partial class VarequalType
{
    
    #region Private fields
    private string _respident;
    
    private VarequalTypeCase _case;
    
    private string _value;
    #endregion
    
    public VarequalType()
    {
        this._case = VarequalTypeCase.No;
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="respident")]
    public string Respident
    {
        get
        {
            return this._respident;
        }
        set
        {
            this._respident = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="case")]
    [System.ComponentModel.DefaultValueAttribute(VarequalTypeCase.No)]
    public VarequalTypeCase Case
    {
        get
        {
            return this._case;
        }
        set
        {
            this._case = value;
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
