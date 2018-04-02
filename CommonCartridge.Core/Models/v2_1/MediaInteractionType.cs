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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="MediaInteraction.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("mediaInteraction", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class MediaInteractionType
{
    
    #region Private fields
    private PromptType _prompt;
    
    private ObjectType _object;
    
    private string _base;
    
    private string _id;
    
    private List<string> _class;
    
    private string _lang;
    
    private string _label;
    
    private string _responseIdentifier;
    
    private bool _autostart;
    
    private int _minPlays;
    
    private int _maxPlays;
    
    private bool _loop;
    #endregion
    
    public MediaInteractionType()
    {
        this._class = new List<string>();
        this._object = new ObjectType();
        this._prompt = new PromptType();
        this._minPlays = 0;
        this._maxPlays = 0;
        this._loop = false;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("prompt")]
    public PromptType Prompt
    {
        get
        {
            return this._prompt;
        }
        set
        {
            this._prompt = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("object")]
    public ObjectType Object
    {
        get
        {
            return this._object;
        }
        set
        {
            this._object = value;
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="id")]
    public string Id
    {
        get
        {
            return this._id;
        }
        set
        {
            this._id = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="class")]
    public List<string> Class
    {
        get
        {
            return this._class;
        }
        set
        {
            this._class = value;
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="label")]
    public string Label
    {
        get
        {
            return this._label;
        }
        set
        {
            this._label = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="responseIdentifier")]
    public string ResponseIdentifier
    {
        get
        {
            return this._responseIdentifier;
        }
        set
        {
            this._responseIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="autostart")]
    public bool Autostart
    {
        get
        {
            return this._autostart;
        }
        set
        {
            this._autostart = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="minPlays")]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MinPlays
    {
        get
        {
            return this._minPlays;
        }
        set
        {
            this._minPlays = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="maxPlays")]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxPlays
    {
        get
        {
            return this._maxPlays;
        }
        set
        {
            this._maxPlays = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="loop")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Loop
    {
        get
        {
            return this._loop;
        }
        set
        {
            this._loop = value;
        }
    }
}
}
#pragma warning restore