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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Educational.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p1/LOM/resource")]
[System.Xml.Serialization.XmlRootAttribute("EducationalType1")]
public partial class EducationalType1
{
    
    #region Private fields
    private ContextType1 _context;
    
    private List<IntendedEndUserRoleType1> _intendedEndUserRole;
    #endregion
    
    public EducationalType1()
    {
        this._intendedEndUserRole = new List<IntendedEndUserRoleType1>();
        this._context = new ContextType1();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("context")]
    public ContextType1 Context
    {
        get
        {
            return this._context;
        }
        set
        {
            this._context = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("intendedEndUserRole", ElementName="intendedEndUserRole")]
    public List<IntendedEndUserRoleType1> IntendedEndUserRole
    {
        get
        {
            return this._intendedEndUserRole;
        }
        set
        {
            this._intendedEndUserRole = value;
        }
    }
}
}
#pragma warning restore
